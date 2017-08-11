using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Data.Linq;

namespace IndustryProject
{
    public partial class Form1 : Form
    {
        private DataTable bds = new DataTable();

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(f_FormClosed);
        }

        private void f_FormClosed(object sender, FormClosingEventArgs e)
        {
            ConnectionClass.myClose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comboData.NAME_PLACES' table. You can move, or remove it, as needed.
            this.nAME_PLACESTableAdapter.Fill(this.comboData.NAME_PLACES);
            // TODO: This line of code loads data into the 'comboData.FEATURE_TYPES' table. You can move, or remove it, as needed.
            this.fEATURE_TYPESTableAdapter.Fill(this.comboData.FEATURE_TYPES);

            chkInactive.Checked = true;


            this.AcceptButton = this.btnSearch;
            txtSearch.Focus();
            ConnectionClass.Initialize();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.ToString() != null)
            {
                grpNameList.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string enteredName = txtSearch.Text;

            txtSearch.SelectAll();
            txtSearch.Focus();

            string basicQuery = @"SELECT NAMES.NAME_ACTUAL AS 'Geographical Name', 
                        NAME_PLACES.FEATURE_ID AS 'Unique National Identifier', NAME_PLACES.DATE_CH AS 'Date Changed',
                        NAME_PLACES.STATUS_CODE AS 'Status', NAMES.CASUALTY AS 'Casualty',
                        NAME_PLACES.ACT_FROM AS 'Act From', NAME_PLACES.ACT_TO AS 'Act To',
                        PLACES.FEAT_CODE AS 'Feature Code', PLACES.MS250 AS 'NTS 250000 Map Sheet',
                        PLACES.MS50 AS 'NTS 50000 Submap Sheet', PLACES.LAT_DEG AS 'LATITUDE Degrees',
                        PLACES.LAT_MIN AS 'LATITUDE Minutes', PLACES.LAT_SEC AS 'LATITUDE Seconds',
                        PLACES.LONG_DEG AS 'LONGITUDE Degrees', PLACES.LONG_MIN AS 'LONGITUDE Minutes',
                        PLACES.LONG_SEC AS 'LONGITUDE Seconds', CASUALTIES.COMMUNITY AS 'Casualty Hometown',
                        CASUALTIES.REG_NO AS 'Casualty Regimental Number', CASUALTIES.RANK_CASUALTY AS 'Casualty Rank',
                        CASUALTIES.SURNAME AS 'Casualty Surname', CASUALTIES.GIVNAME AS 'Casualty Given Name',
                        CASUALTIES.DATE_DECEASED AS 'Casualty Date of Death', CASUALTIES.SERVED AS 'Casualty Regiment',
                        CASUALTIES.BURIED AS 'Casualty Place of Burial', FEATURE_TYPES.FEAT_TYPE AS 'Feature Type',
                        FEATURE_TYPES.DESCR AS 'Feature Type Description', PLACES.LONGITUDE, PLACES.LATITUDE
                        FROM NAMES JOIN NAME_PLACES ON NAMES.NAME_ID = NAME_PLACES.NAME_ID JOIN PLACES
                        ON PLACES.PLACE_ID = NAME_PLACES.PLACE_ID LEFT JOIN CASUALTIES ON NAMES.CASUALTY_ID = CASUALTIES.CASUALTY_ID
                        LEFT JOIN FEATURE_TYPES ON PLACES.FEAT_CODE = FEATURE_TYPES.FEAT_CODE ";

            
            if (radMaps.Checked)
            {
                MakeSpecificRadioAvailabel(sender, e);
            }

            if (radMS250.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " WHERE PLACES.MS250 = @ms250";
                ConnectionClass.AddParam("ms250", enteredName);
            }

            else if (radMS50.Checked && !String.IsNullOrWhiteSpace(enteredName))
            { 
                basicQuery += " WHERE PLACES.MS250 = @ms250" + " AND PLACES.MS50 = @ms50";
                ConnectionClass.AddParam("ms250".ToString(), enteredName.ToString());
                ConnectionClass.AddParam("ms50".ToString(), enteredName.ToString());
            }

            else if (radLocation.Checked && !String.IsNullOrWhiteSpace(txtLatDeg.Text) && !String.IsNullOrWhiteSpace(txtLatMin.Text) &&
                !String.IsNullOrWhiteSpace(txtLatSec.Text) && !String.IsNullOrWhiteSpace(txtLongDeg.Text) &&
                !String.IsNullOrWhiteSpace(txtLongMin.Text) && !String.IsNullOrWhiteSpace(txtLongSec.Text))
            {
                basicQuery += " WHERE PLACES.LAT_DEG = @LatDeg";
                basicQuery += " AND PLACES.LAT_MIN = @LatMin";
                basicQuery += " AND PLACES.LAT_SEC = @LatSec";
                basicQuery += " AND PLACES.LONG_DEG = @LongDeg";
                basicQuery += " AND PLACES.LONG_MIN = @LongMin";
                basicQuery += " AND PLACES.LONG_SEC = @LongSec";

                ConnectionClass.AddParam("LatDeg", txtLatDeg.Text);
                ConnectionClass.AddParam("LatMin", txtLatMin.Text);
                ConnectionClass.AddParam("LatSec", txtLatSec.Text);
                ConnectionClass.AddParam("LongDeg", txtLongDeg.Text);
                ConnectionClass.AddParam("LongMin", txtLongMin.Text);
                ConnectionClass.AddParam("LongSec", txtLongSec.Text);
            }
            else if (radName.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " WHERE NAMES.NAME_ACTUAL LIKE @name + '%'";
                ConnectionClass.AddParam("name", enteredName);
            }

            else if (radFID.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " WHERE NAME_PLACES.FEATURE_ID = @ident";
                ConnectionClass.AddParam("ident", enteredName);
            }          

            else if (radStatus.Checked && !String.IsNullOrWhiteSpace(enteredName))
            {
                basicQuery += " WHERE NAME_PLACES.STATUS_CODE = @statuscode";
                ConnectionClass.AddParam("statuscode", enteredName);
            }

            bds = ConnectionClass.getSQLData(basicQuery).Tables[0];
                                   
            dgvSearch.DataSource = bds;

            for (int i = 1; i < dgvSearch.ColumnCount; i++)
            {
                dgvSearch.Columns[i].Visible = false;
            }

            dgvSearch.Columns[0].Width = dgvSearch.Width;
        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count > 0)
            {
                UpdateCasualtyCheckBox();

                lblFID.Text = dgvSearch.CurrentRow.Cells["Unique National Identifier"].Value.ToString();

                //Act From
                if (String.IsNullOrEmpty(dgvSearch.CurrentRow.Cells["Act From"].Value.ToString()))
                {
                    lblFrom.Text = "No Data";
                }

                else
                {
                    lblFrom.Text = DateTime.Parse(dgvSearch.CurrentRow.Cells["Act From"].Value.ToString()).ToShortDateString(); 
                }

                //Act To
                if (String.IsNullOrEmpty(dgvSearch.CurrentRow.Cells["Act To"].Value.ToString()))
                {
                    lblTo.Text = "No Data";
                }

                else
                {
                    lblTo.Text = DateTime.Parse(dgvSearch.CurrentRow.Cells["Act To"].Value.ToString()).ToShortDateString();  
                }

                lblLatitudeDegree.Text = dgvSearch.CurrentRow.Cells["LATITUDE Degrees"].Value.ToString();
                lblLatitudeMinute.Text = dgvSearch.CurrentRow.Cells["LATITUDE Minutes"].Value.ToString();
                lblLatitudeSecond.Text = dgvSearch.CurrentRow.Cells["LATITUDE Seconds"].Value.ToString();
                lblLongitudeDegree.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Degrees"].Value.ToString();
                lblLongitudeMinute.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Minutes"].Value.ToString();
                lblLongitudeSecond.Text = dgvSearch.CurrentRow.Cells["LONGITUDE Seconds"].Value.ToString();
                lbl250.Text = dgvSearch.CurrentRow.Cells["NTS 250000 Map Sheet"].Value.ToString();
                lbl50.Text = dgvSearch.CurrentRow.Cells["NTS 50000 Submap Sheet"].Value.ToString();


                
            }
        }

        private void UpdateCasualtyCheckBox()
        {
            if (String.IsNullOrEmpty(dgvSearch.CurrentRow.Cells["Casualty Given Name"].Value.ToString()))
            {
                chkCasualty.Checked = false;
                chkCasualty.BackColor = Color.LightGray;
                btnCasualtyHistory.Enabled = false;

            }
            else
            {
                chkCasualty.Checked = true;
                chkCasualty.BackColor = Color.Red;
                btnCasualtyHistory.Enabled = true;
            }
        }

        private void ChkCasualty_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCasualtyCheckBox();
        }

        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cboFeature_SelectedIndexChanged(object sender, EventArgs e)
        { 
           
            string basicQuery = @"SELECT NAMES.NAME_ACTUAL AS 'Geographical Name', 
                        NAME_PLACES.FEATURE_ID AS 'Unique National Identifier', NAME_PLACES.DATE_CH AS 'Date Changed',
                        NAME_PLACES.STATUS_CODE AS 'Status', NAMES.CASUALTY AS 'Casualty',
                        NAME_PLACES.ACT_FROM AS 'Act From', NAME_PLACES.ACT_TO AS 'Act To',
                        PLACES.FEAT_CODE AS 'Feature Code', PLACES.MS250 AS 'NTS 250000 Map Sheet',
                        PLACES.MS50 AS 'NTS 50000 Submap Sheet', PLACES.LAT_DEG AS 'LATITUDE Degrees',
                        PLACES.LAT_MIN AS 'LATITUDE Minutes', PLACES.LAT_SEC AS 'LATITUDE Seconds',
                        PLACES.LONG_DEG AS 'LONGITUDE Degrees', PLACES.LONG_MIN AS 'LONGITUDE Minutes',
                        PLACES.LONG_SEC AS 'LONGITUDE Seconds', CASUALTIES.COMMUNITY AS 'Casualty Hometown',
                        CASUALTIES.REG_NO AS 'Casualty Regimental Number', CASUALTIES.RANK_CASUALTY AS 'Casualty Rank',
                        CASUALTIES.SURNAME AS 'Casualty Surname', CASUALTIES.GIVNAME AS 'Casualty Given Name',
                        CASUALTIES.DATE_DECEASED AS 'Casualty Date of Death', CASUALTIES.SERVED AS 'Casualty Regiment',
                        CASUALTIES.BURIED AS 'Casualty Place of Burial', FEATURE_TYPES.FEAT_TYPE AS 'Feature Type',
                        FEATURE_TYPES.DESCR AS 'Feature Type Description', PLACES.LONGITUDE, PLACES.LATITUDE
                        FROM NAMES JOIN NAME_PLACES ON NAMES.NAME_ID = NAME_PLACES.NAME_ID JOIN PLACES
                        ON PLACES.PLACE_ID = NAME_PLACES.PLACE_ID LEFT JOIN CASUALTIES ON NAMES.CASUALTY_ID = CASUALTIES.CASUALTY_ID
                        LEFT JOIN FEATURE_TYPES ON PLACES.FEAT_CODE = FEATURE_TYPES.FEAT_CODE ";

            if (radFeature.Checked)
            {
                basicQuery += " WHERE FEATURE_TYPES.FEAT_TYPE = @feattype";
                ConnectionClass.AddParam("feattype", cboFeature.SelectedValue.ToString()); 
            }

            //dgvSearch.DataSource = ConnectionClass.getSQLData(basicQuery).Tables[0];

            bds = ConnectionClass.getSQLData(basicQuery).Tables[0];
            dgvSearch.DataSource = bds;

            for (int i = 1; i < dgvSearch.ColumnCount; i++)
            {
                dgvSearch.Columns[i].Visible = false;
            }

            dgvSearch.Columns[0].Width = dgvSearch.Width;

        }

        private void radFeature_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cboFeature.Visible = true;
            btnSearch.Visible = false;
            lblSearch.Visible = false;
            cboFeature.DataSource = fEATURETYPESBindingSource;
            cboFeature.DisplayMember = "FEAT_TYPE";
            cboFeature.ValueMember = "FEAT_TYPE";
        }

        private void cboFeature_SelectionChangeCommitted(object sender, EventArgs e)
        {
            grpNameList.Enabled = true;
        }

        private void MakeSpecificRadioAvailabel(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;

            if (btn.Name == radName.Name)
            {
                txtSearch.Visible = true;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = true;
            }

            else if (btn.Name == radFeature.Name)
            {
                txtSearch.Visible = false;
                cboFeature.Visible = true;
                btnSearch.Visible = false;
                lblSearch.Visible = false;
                cboFeature.DataSource = fEATURETYPESBindingSource;
                cboFeature.DisplayMember = "Feature Type";
                cboFeature.ValueMember = "FEAT_TYPE";
            }

            else if (btn.Name == radMaps.Name)
            {
                txtSearch.Visible = true;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = true;

                if (radMaps.Checked || radMS250.Checked | radMS50.Checked)
                {
                    radMS250.Visible = true;
                    radMS50.Visible = true;
                }

                else
                {
                    radMS250.Visible = false;
                    radMS50.Visible = false;
                }
            }

            else if (btn.Name == radLocation.Name)
            {
                txtSearch.Visible = false;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = false;

                if (radLocation.Checked)
                {
                    gpCoordinates.Visible = true;
                    lblSearch.Visible = false;
                    txtSearch.Visible = false;
                }
                else
                {
                    gpCoordinates.Visible = false;
                    lblSearch.Visible = true;
                    txtSearch.Visible = true;
                }
            }

            else if (btn.Name == radFID.Name)
            {
                txtSearch.Visible = true;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = true;
            }

            else if (btn.Name == radStatus.Name)
            {
                txtSearch.Visible = true;
                cboFeature.Visible = false;
                btnSearch.Visible = true;
                lblSearch.Visible = true;
            }
        }

        private void dgvSearch_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {      
            cboFear.DataSource = ConnectionClass.getSQLData("SELECT DISTINCT * FROM FEATURE_TYPES ORDER BY FEAT_TYPE ASC").Tables[0];
            cboFear.DisplayMember=
            cboFear.ValueMember = "FEAT_TYPE";

            cboStatus.DataSource = ConnectionClass.getSQLData("SELECT DISTINCT STATUS_CODE FROM NAME_PLACES ORDER BY STATUS_CODE ASC").Tables[0];
            cboStatus.DisplayMember =
            cboStatus.ValueMember = "STATUS_CODE";
        }

        /// <summary>
        /// Opens a new form
        /// Displays casualties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCasualtyHistory_Click(object sender, EventArgs e)
        {
            frmCasualty frmCasualty = new frmCasualty(dgvSearch);

            frmCasualty.ShowDialog();
        }

        /// <summary>
        /// Ends the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNewPlace_Click(object sender, EventArgs e)
        {
            newplace frm2 = new newplace();
            frm2.Show();
        }

        private void btnNewPlace_Click_1(object sender, EventArgs e)
        {
            newplace place = new newplace();
            place.Show();            
        }
    }
}