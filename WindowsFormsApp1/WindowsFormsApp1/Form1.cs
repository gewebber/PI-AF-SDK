using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OSIsoft.AF;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Time;
using OSIsoft.AF.UnitsOfMeasure;
using OSIsoft.AF.Data;
using OSIsoft.AF.Notification;
using OSIsoft.AF.EventFrame;
using OSIsoft.AF.Search;

using System.Net.NetworkInformation;

using System.Net;

using System.Diagnostics;

using OSIsoft.AF.PI;

namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            //Connect PI system picker to database picker.
            afDatabasePicker1.SystemPicker = piSystemPicker1;
        }

        private void afTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Initialise objects.
            AFElement selectedElement = afTreeView1.AFSelection as AFElement;
            AFAttributes attributeTree = null;

            //Clear data items
            lbCurrentVal.Text = "";
            lbTagName.Text = "";
            afStartDate.Text = "";
            afEndTime.Text = "";
            lbTimestamp.Text = "";
            lbData.Items.Clear();
            cbUOM.Items.Clear();
            btnInspectTag.Hide();
            lbAttribName.Text = "";

            afDataChart.Series["dataSeries"].Points.Clear();


            //Check for null case
            if (selectedElement != null)
            {
                //Get attributes of selected element
                attributeTree = selectedElement.Attributes;

                //Fill afTreeView2 with attributeList
                afTreeView2.AFRoot = attributeTree;

            }
            
        }

        private void afDatabasePicker1_SelectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            AFDatabase db = afDatabasePicker1.AFDatabase;

            //Clear data items
            lbCurrentVal.Text = "";
            lbTagName.Text = "";
            afStartDate.Text = "";
            afEndTime.Text = "";
            lbTimestamp.Text = "";
            lbData.Items.Clear();
            cbUOM.Items.Clear();
            btnInspectTag.Hide();
            lbAttribName.Text = "";
            afDataChart.Series["dataSeries"].Points.Clear();

            //Clear treeviews
            afTreeView1.AFRoot = null;
            afTreeView2.AFRoot = null;

            //If database is not null, set afTreeView1 to hold database elements.
            if (db != null)
            {
                afTreeView1.AFRoot = db.Elements;
            }

        }

        private void afTreeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AFAttribute selectedAttribute = afTreeView2.AFSelection as AFAttribute;

            //Clear data items
            lbCurrentVal.Text = "";
            lbTagName.Text = "";
            lbTimestamp.Text = "";
            lbData.Items.Clear();
            cbUOM.Items.Clear();
            btnInspectTag.Hide();
            afDataChart.Series["dataSeries"].Points.Clear();

            //Set timerange to default value
            afStartDate.Text = "*-12h";
            afEndTime.Text = "*";


            if (selectedAttribute != null)
            {
                if (selectedAttribute.DefaultUOM != null)
                {
                    cbUOM.Text = null;

                    //Fill out the UoM drop-down list
                    UOMClass selectedUOMClass = selectedAttribute.DefaultUOM.Class;
                    cbUOM.Items.AddRange(selectedUOMClass.UOMs.ToArray());
                    cbUOM.SelectedItem = selectedAttribute.DefaultUOM;
                }

                lbAttribName.Text = selectedAttribute.ToString();
                
                if (selectedAttribute.GetValue() != null) //Check that an attribute has been selected
                {
                    //Set lbCurrentVal to hold the current attribute value and timestamp
                    lbCurrentVal.Text = selectedAttribute.GetValue().ToString();
                    lbTimestamp.Text = selectedAttribute.GetValue().Timestamp.ToString();
                }
                    
                try//Check attribute for association with a PI Tag
                {
                    lbTagName.Text = selectedAttribute.PIPoint.Name.ToString(); //Set lbTagName to hold associated PI tag name
                    btnInspectTag.Show();
                } catch (OSIsoft.AF.PI.PIPointInvalidException) { //No tag association exists
                    lbTagName.Text = "INVALID PI POINT";
                } catch (System.NullReferenceException)
                {
                    lbTagName.Text = "NO PI POINT";
                }

                bntShowTrend.PerformClick();
            }
        }

        private void bntShowTrend_Click(object sender, EventArgs e)
        {
            lbData.Items.Clear();

            //Set time-range
            AFTime startTime = new AFTime(afStartDate.Text);
            AFTime endTime = new AFTime(afEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime, endTime);


            //Clear chart of any previous data
            afDataChart.Series["dataSeries"].Points.Clear();

            //Set UoM
            UOM selectedUOM = cbUOM.SelectedItem as UOM;

            if (afTreeView2.AFSelection != null)
            {
                AFAttribute selectedAttribute = afTreeView2.AFSelection as AFAttribute;
                AFValues vals;
                if (selectedAttribute != null)
                {
                    //Get values and convert to desired UoM if necessary
                    if (selectedAttribute.DefaultUOM != null)
                    {
                        vals = selectedAttribute.GetValues(timeRange, 0, null).Convert(selectedUOM);
                    } else
                    {
                        vals = selectedAttribute.GetValues(timeRange, 0, null);
                    }
                    
                    //Fill out list and chart of values.
                    foreach (AFValue val in vals)
                    {
                        string s = String.Format("{0} \t {1} {2}", val.Timestamp.LocalTime, val.Value,
                                                    selectedUOM != null ? selectedUOM.Abbreviation : null);
                        lbData.Items.Add(s);

                        try
                        {
                            afDataChart.Series["dataSeries"].Points.AddXY(val.Timestamp.ToString(), val.Value);
                        }
                        catch (System.ArgumentException)
                        {
                            continue;
                        }
                    }
                }
            }

        }

        private void cbUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            UOM selectedUOM = cbUOM.SelectedItem as UOM;
            AFAttribute selectedAttribute = afTreeView2.AFSelection as AFAttribute;

            //Clear list of values
            lbData.Items.Clear();

            //Convert current value to new UoM
            lbCurrentVal.Text = selectedAttribute.GetValue().Convert(selectedUOM).ToString();
            lbTimestamp.Text = selectedAttribute.GetValue().Timestamp.ToString();

            //Clear chart
            afDataChart.Series["dataSeries"].Points.Clear();

            if (lbData.Items != null)
            {
                //Get time-range
                AFTime startTime = new AFTime(afStartDate.Text);
                AFTime endTime = new AFTime(afEndTime.Text);
                AFTimeRange timeRange = new AFTimeRange(startTime, endTime);

                AFValues vals;

                if (selectedAttribute != null)
                {
                    //Convert to new Uom if required
                    if (selectedAttribute.DefaultUOM != null)
                    {
                        vals = selectedAttribute.GetValues(timeRange, 0, null).Convert(selectedUOM);
                    }
                    else
                    {
                        vals = selectedAttribute.GetValues(timeRange, 0, null);
                    }

                    //Fill out list and chart
                    foreach (AFValue val in vals)
                    {
                        string s = String.Format("{0} \t {1} {2}", val.Timestamp.LocalTime, val.Value,
                                                    selectedUOM != null ? selectedUOM.Abbreviation : null);
                        lbData.Items.Add(s);

                        try
                        {
                            afDataChart.Series["dataSeries"].Points.AddXY(val.Timestamp.ToString(), val.Value);
                        }
                        catch (System.ArgumentException)
                        {
                            continue;
                        }
                    }
                }
            }
        }

        private void btnInspectTag_Click(object sender, EventArgs e)
        {
            AFAttribute selectedAttribute = afTreeView2.AFSelection as AFAttribute;

            //Change tab to Data Archive tab
            tabControl1.SelectedIndex = 1;

            //Prefill tagname field
            tbEnterTag.Text = lbTagName.Text;

            //Prefill timerange
            piStartTime.Text = "*-12h";
            piEndTime.Text = "*";

            //Prefill server picker
            piServerPicker1.Text = piSystemPicker1.AFSelection.ToString();

            //Perform button actions
            btnGetTagInfo.PerformClick();

            try
            {
                btnGetTagData.PerformClick();
            } catch (System.InvalidOperationException)
            {
                //Sometimes data does not correctly prefill on Data Archive tab (not sure why) and
                //so this catch operation attempts to fillout the data again.
                tbEnterTag.Text = lbTagName.Text;
                piStartTime.Text = "*-12h";
                piEndTime.Text = "*";
                piServerPicker1.Text = piSystemPicker1.AFSelection.ToString();
                btnGetTagInfo.PerformClick();
                btnGetTagData.PerformClick();
            }
        }

        private void btnGetTagInfo_Click(object sender, EventArgs e)
        {
            //Enable time-range picker
            btnGetTagData.Enabled = true;
            piStartTime.Enabled = true;
            piEndTime.Enabled = true;

            //Prefill time-range
            piStartTime.Text = "*-12h";
            piEndTime.Text = "*";

            //Clear chart
            piDataChart.Series["dataSeries"].Points.Clear();

            //Clear list of data
            lbPIData.Items.Clear();

            //Connect to server
            PIServers servers = new PIServers();
            PIServer server = servers[piServerPicker1.PIServer.ToString()];

            try
            {
                //Connect to server
                server.Connect();

                //Extract tag name
                string tagname = tbEnterTag.Text;

                //Search for tag
                IList<PIPoint> points = PIPoint.FindPIPoints(server, new List<string>() { tagname });

                if (points.Count == 1)
                {
                    lbTagFound.Text = "PI tag found!";

                    //Obtain pi point.
                    PIPoint point = PIPoint.FindPIPoint(server, tagname);

                    //Extract point attributes
                    IDictionary<string, object> pointAttribs = point.GetAttributes();

                    //Extract tag attributes
                    string tag = pointAttribs["tag"].ToString();
                    string descriptor = pointAttribs["descriptor"].ToString();
                    string engunits = pointAttribs["engunits"].ToString();
                    string pointtype = pointAttribs["pointtype"].ToString();
                    string pointsource = pointAttribs["pointsource"].ToString();
                    string creationdate = pointAttribs["creationdate"].ToString();
                    string creator = pointAttribs["creator"].ToString();
                    string location1 = pointAttribs["location1"].ToString();
                    string location2 = pointAttribs["location2"].ToString();
                    string location3 = pointAttribs["location3"].ToString();
                    string location4 = pointAttribs["location4"].ToString();
                    string location5 = pointAttribs["location5"].ToString();
                    string instrumenttag = pointAttribs["instrumenttag"].ToString();

                    //Set tag attributes in relevant text fields
                    piTag.Text = tag;
                    piDescriptor.Text = descriptor;
                    piEngUnits.Text = engunits;
                    piPointType.Text = pointtype;
                    piPointSource.Text = pointsource;
                    piCreationDate.Text = creationdate;
                    piCreator.Text = creator;
                    piLocation1.Text = location1;
                    piLocation2.Text = location2;
                    piLocation3.Text = location3;
                    piLocation4.Text = location4;
                    piLocation5.Text = location5;
                    piInstrumentTag.Text = instrumenttag;

                    piCurrentValue.Text = point.CurrentValue().ToString();
                    piCurrentTimestamp.Text = point.CurrentValue().Timestamp.ToString();

                    //Get data for the tag
                    btnGetTagData.PerformClick();

                } else if (points.Count > 1)
                {
                    //If more than one tag is found matching that name, skip.
                    //Application is designed to handle only one tag at a time.
                    lbTagFound.Text = "Single tag use only.";
                }
                else
                {
                    //If tag cannot be found display message
                    lbTagFound.Text = "PI tag not found.";
                }
            } catch (OSIsoft.AF.PI.PIAuthenticationException)
            {
                //If there is an authentication error trying to connect to the server, display message
                lbTagFound.Text = "Permissions Error!";
            }

            
            
        }

        private void piServerPicker1_SelectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {
            //Reset all attribute and data fields
            piTag.Text = "..";
            piDescriptor.Text = "..";
            piEngUnits.Text = "..";
            piPointType.Text = "..";
            piPointSource.Text = "..";
            piCreationDate.Text = "..";
            piCreator.Text = "..";
            piLocation1.Text = "..";
            piLocation2.Text = "..";
            piLocation3.Text = "..";
            piLocation4.Text = "..";
            piLocation5.Text = "..";
            piInstrumentTag.Text = "..";
            tbEnterTag.Text = "";
            lbTagFound.Text = "";
            piCurrentValue.Text = "..";
            piCurrentTimestamp.Text = "..";

            btnGetTagData.Enabled = false;
            piStartTime.Enabled = false;
            piEndTime.Enabled = false;

            piStartTime.Text = "";
            piEndTime.Text = "";

            piDataChart.Series["dataSeries"].Points.Clear();
        }

        private void btnGetTagData_Click(object sender, EventArgs e)
        {
            //Set timerange
            AFTime startTime = new AFTime(piStartTime.Text);
            AFTime endTime = new AFTime(piEndTime.Text);
            AFTimeRange timeRange = new AFTimeRange(startTime, endTime);

            //Get tagname
            string tagname = tbEnterTag.Text;

            //Get pi server
            PIServers servers = new PIServers();
            PIServer server = servers[piServerPicker1.PIServer.ToString()];

            //Get pi point
            PIPoint point = PIPoint.FindPIPoint(server, tagname);

            //extract values for tag across timerange
            AFValues values = point.RecordedValues(timeRange, AFBoundaryType.Inside, null, false, 0);

            //Get current value and timestamp
            piCurrentValue.Text = point.CurrentValue().ToString();
            piCurrentTimestamp.Text = point.CurrentValue().Timestamp.ToString();

            //Clear data chart
            piDataChart.Series["dataSeries"].Points.Clear();

            if (values != null)
            {
                foreach (AFValue value in values)
                {
                    //Write data into list box
                    string output = String.Format("{0} \t {1} {2}", value.Timestamp, value.Value, 
                                                    value.UOM != null ? value.UOM.Abbreviation : null);
                    lbPIData.Items.Add(output);

                    try
                    {
                        //chart data
                        piDataChart.Series["dataSeries"].Points.AddXY(value.Timestamp.ToString(), value.Value);
                    } catch (System.ArgumentException)
                    {
                        continue;
                    }

                    
                }
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            int index = 0;
            List<long> results = new List<long>();

            //Hide all data points
            pingResults.Series["ping"].Points.Clear();
            pingResults.Visible = false;
            lbPingFailure.Text = "";
            lbReturnTime.Visible = false;
            lbAverageReturnTime.Visible = false;
            lbMinReturnTime.Visible = false;
            lbMinTime.Visible = false;
            lbMaxReturnTime.Visible = false;
            lbMaxTime.Visible = false;
            lbConnectionStatus.Visible = false;
            lbConnectionStatusLabel.Visible = false;
            lbAuthenticationStatus.Visible = false;
            lbAuthenticationStatusLabel.Visible = false;

            int timeout = 1000;

            do
            {
               
                try
                {
                    //Ping server selected in drop-down box
                    Ping pinger = new Ping();
                    System.Threading.Thread.Sleep(50);
                    PingReply reply = pinger.Send(piServerPicker2.Text.ToString(), timeout);
                    
                    //if successful, and round trip time to array and chart 
                    if (reply.Status == IPStatus.Success) 
                    {
                        long speed = reply.RoundtripTime;
                        pingResults.Visible = true;
                        pingResults.Series["ping"].Points.AddY(speed);
                        results.Add(speed);
                    }
                    else
                    {
                        //If timeout occurs, display message and exit loop
                        pingResults.Visible = false;
                        lbPingFailure.Text = "Ping Timeout!";
                        break;
                    }
                    pinger.Dispose();
                    index++;

                }
                catch (PingException)//Catch any exceptions and continue with loop
                {
                    continue;
                }
                
            } while (index < 20);

            //Make information items visible
            lbAuthenticationStatus.Visible = true;
            lbAuthenticationStatusLabel.Visible = true;
            lbConnectionStatus.Visible = true;
            lbConnectionStatusLabel.Visible = true;

            //Set information item values depending on ping results
            if (lbPingFailure.Text.Equals("Ping Timeout!"))
            {
                lbAuthenticationStatus.Text = " - ";
                lbConnectionStatus.Text = " - ";
            }
            else
            {
                long pingAverage = (long)results.Average();
                lbAverageReturnTime.Text = pingAverage.ToString() + " ms";
                lbReturnTime.Visible = true;
                lbAverageReturnTime.Visible = true;

                long pingMax = (long)results.Max();
                lbMaxReturnTime.Text = pingMax.ToString() + " ms";
                lbMaxReturnTime.Visible = true;
                lbMaxTime.Visible = true;

                long pingMin = (long)results.Min();
                lbMinReturnTime.Text = pingMin.ToString() + " ms";
                lbMinReturnTime.Visible = true;
                lbMinTime.Visible = true;

                PIServers servers = new PIServers();
                PIServer server = servers[piServerPicker2.PIServer.ToString()];

                //Attempt to connect to server
                try
                {
                    //If sucessful and both 'connection' and 'authentication' information items display this success
                    server.Connect();
                    lbAuthenticationStatus.Text = "Authentication successful";
                    lbConnectionStatus.Text = "Connection successful";
                } catch (OSIsoft.AF.PI.PIAuthenticationException)
                {
                    //If authentication exception occurs, display this
                    lbAuthenticationStatus.Text = "Authentication unsuccessful";
                    lbConnectionStatus.Text = " - ";
                } catch (Exception ex)
                {
                    //If any other exception then unsuccessful connection
                    lbAuthenticationStatus.Text = " - ";
                    lbConnectionStatus.Text = "Connection unsuccessful";

                }
                
                
            }

        }

    }
}
