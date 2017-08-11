    namespace IndustryProject
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.cboFeature = new System.Windows.Forms.ComboBox();
            this.gpCoordinates = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLongSec = new System.Windows.Forms.TextBox();
            this.txtLongMin = new System.Windows.Forms.TextBox();
            this.txtLongDeg = new System.Windows.Forms.TextBox();
            this.txtLatSec = new System.Windows.Forms.TextBox();
            this.txtLatMin = new System.Windows.Forms.TextBox();
            this.txtLatDeg = new System.Windows.Forms.TextBox();
            this.radMaps = new System.Windows.Forms.RadioButton();
            this.radMS50 = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewPlace = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.radStatus = new System.Windows.Forms.RadioButton();
            this.radFID = new System.Windows.Forms.RadioButton();
            this.radLocation = new System.Windows.Forms.RadioButton();
            this.radMS250 = new System.Windows.Forms.RadioButton();
            this.radFeature = new System.Windows.Forms.RadioButton();
            this.radName = new System.Windows.Forms.RadioButton();
            this.grpNameList = new System.Windows.Forms.GroupBox();
            this.grpGroupName = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl250 = new System.Windows.Forms.Label();
            this.lblLongitudeSecond = new System.Windows.Forms.Label();
            this.lblLongitudeMinute = new System.Windows.Forms.Label();
            this.lblLongitudeDegree = new System.Windows.Forms.Label();
            this.lblLatitudeSecond = new System.Windows.Forms.Label();
            this.lblLatitudeMinute = new System.Windows.Forms.Label();
            this.lblLatitudeDegree = new System.Windows.Forms.Label();
            this.btnCasualtyHistory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSearchBottom = new System.Windows.Forms.GroupBox();
            this.lblFID = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCasualty = new System.Windows.Forms.CheckBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.manitoba_MapperTableAdapter = new IndustryProject.dbIndigenousPlaceNamesDataSetTableAdapters.Manitoba_MapperTableAdapter();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableAdapterManager1 = new IndustryProject.LoginDataSetTableAdapters.TableAdapterManager();
            this.comboData = new IndustryProject.ComboData();
            this.fEATURETYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fEATURE_TYPESTableAdapter = new IndustryProject.ComboDataTableAdapters.FEATURE_TYPESTableAdapter();
            this.comboDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMEPLACESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAME_PLACESTableAdapter = new IndustryProject.ComboDataTableAdapters.NAME_PLACESTableAdapter();
            this.fEATURETYPESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpSearch.SuspendLayout();
            this.gpCoordinates.SuspendLayout();
            this.grpNameList.SuspendLayout();
            this.grpGroupName.SuspendLayout();
            this.grpSearchBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEATURETYPESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMEPLACESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEATURETYPESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.chkInactive);
            this.grpSearch.Controls.Add(this.cboFeature);
            this.grpSearch.Controls.Add(this.gpCoordinates);
            this.grpSearch.Controls.Add(this.radMaps);
            this.grpSearch.Controls.Add(this.radMS50);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.btnNewPlace);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearch);
            this.grpSearch.Controls.Add(this.radStatus);
            this.grpSearch.Controls.Add(this.radFID);
            this.grpSearch.Controls.Add(this.radLocation);
            this.grpSearch.Controls.Add(this.radMS250);
            this.grpSearch.Controls.Add(this.radFeature);
            this.grpSearch.Controls.Add(this.radName);
            this.grpSearch.Location = new System.Drawing.Point(29, 22);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(542, 164);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Box";
            // 
            // chkInactive
            // 
            this.chkInactive.AutoSize = true;
            this.chkInactive.Location = new System.Drawing.Point(32, 127);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(100, 17);
            this.chkInactive.TabIndex = 27;
            this.chkInactive.Text = "Inactive Names";
            this.chkInactive.UseVisualStyleBackColor = true;
            // 
            // cboFeature
            // 
            this.cboFeature.DisplayMember = "FEAT_TYPE";
            this.cboFeature.FormattingEnabled = true;
            this.cboFeature.Location = new System.Drawing.Point(70, 72);
            this.cboFeature.Margin = new System.Windows.Forms.Padding(1);
            this.cboFeature.Name = "cboFeature";
            this.cboFeature.Size = new System.Drawing.Size(406, 21);
            this.cboFeature.TabIndex = 26;
            this.cboFeature.ValueMember = "FEAT_TYPE";
            this.cboFeature.Visible = false;
            this.cboFeature.SelectedIndexChanged += new System.EventHandler(this.cboFeature_SelectedIndexChanged);
            this.cboFeature.SelectionChangeCommitted += new System.EventHandler(this.cboFeature_SelectionChangeCommitted);
            // 
            // gpCoordinates
            // 
            this.gpCoordinates.Controls.Add(this.label17);
            this.gpCoordinates.Controls.Add(this.label16);
            this.gpCoordinates.Controls.Add(this.label15);
            this.gpCoordinates.Controls.Add(this.label14);
            this.gpCoordinates.Controls.Add(this.label13);
            this.gpCoordinates.Controls.Add(this.label12);
            this.gpCoordinates.Controls.Add(this.label10);
            this.gpCoordinates.Controls.Add(this.label9);
            this.gpCoordinates.Controls.Add(this.txtLongSec);
            this.gpCoordinates.Controls.Add(this.txtLongMin);
            this.gpCoordinates.Controls.Add(this.txtLongDeg);
            this.gpCoordinates.Controls.Add(this.txtLatSec);
            this.gpCoordinates.Controls.Add(this.txtLatMin);
            this.gpCoordinates.Controls.Add(this.txtLatDeg);
            this.gpCoordinates.Location = new System.Drawing.Point(15, 54);
            this.gpCoordinates.Margin = new System.Windows.Forms.Padding(1);
            this.gpCoordinates.Name = "gpCoordinates";
            this.gpCoordinates.Padding = new System.Windows.Forms.Padding(1);
            this.gpCoordinates.Size = new System.Drawing.Size(470, 55);
            this.gpCoordinates.TabIndex = 21;
            this.gpCoordinates.TabStop = false;
            this.gpCoordinates.Text = "Coordinates";
            this.gpCoordinates.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(420, 16);
            this.label17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 7);
            this.label17.TabIndex = 25;
            this.label17.Text = "Seconds";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(381, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 7);
            this.label16.TabIndex = 22;
            this.label16.Text = "Minutes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(339, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 7);
            this.label15.TabIndex = 24;
            this.label15.Text = "Degrees";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(153, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 7);
            this.label14.TabIndex = 23;
            this.label14.Text = "Seconds";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(113, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 7);
            this.label13.TabIndex = 22;
            this.label13.Text = "Minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 7);
            this.label12.TabIndex = 21;
            this.label12.Text = "Degrees";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Longitude:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Latitude:";
            // 
            // txtLongSec
            // 
            this.txtLongSec.Location = new System.Drawing.Point(415, 29);
            this.txtLongSec.Margin = new System.Windows.Forms.Padding(1);
            this.txtLongSec.Name = "txtLongSec";
            this.txtLongSec.Size = new System.Drawing.Size(40, 20);
            this.txtLongSec.TabIndex = 18;
            this.txtLongSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLongMin
            // 
            this.txtLongMin.Location = new System.Drawing.Point(373, 29);
            this.txtLongMin.Margin = new System.Windows.Forms.Padding(1);
            this.txtLongMin.Name = "txtLongMin";
            this.txtLongMin.Size = new System.Drawing.Size(40, 20);
            this.txtLongMin.TabIndex = 17;
            this.txtLongMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLongDeg
            // 
            this.txtLongDeg.Location = new System.Drawing.Point(332, 29);
            this.txtLongDeg.Margin = new System.Windows.Forms.Padding(1);
            this.txtLongDeg.Name = "txtLongDeg";
            this.txtLongDeg.Size = new System.Drawing.Size(40, 20);
            this.txtLongDeg.TabIndex = 16;
            this.txtLongDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLatSec
            // 
            this.txtLatSec.Location = new System.Drawing.Point(146, 29);
            this.txtLatSec.Margin = new System.Windows.Forms.Padding(1);
            this.txtLatSec.Name = "txtLatSec";
            this.txtLatSec.Size = new System.Drawing.Size(40, 20);
            this.txtLatSec.TabIndex = 15;
            this.txtLatSec.Text = " ";
            this.txtLatSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLatMin
            // 
            this.txtLatMin.Location = new System.Drawing.Point(105, 29);
            this.txtLatMin.Margin = new System.Windows.Forms.Padding(1);
            this.txtLatMin.Name = "txtLatMin";
            this.txtLatMin.Size = new System.Drawing.Size(40, 20);
            this.txtLatMin.TabIndex = 14;
            this.txtLatMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLatDeg
            // 
            this.txtLatDeg.Location = new System.Drawing.Point(63, 29);
            this.txtLatDeg.Margin = new System.Windows.Forms.Padding(1);
            this.txtLatDeg.Name = "txtLatDeg";
            this.txtLatDeg.Size = new System.Drawing.Size(40, 20);
            this.txtLatDeg.TabIndex = 13;
            this.txtLatDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radMaps
            // 
            this.radMaps.AutoSize = true;
            this.radMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaps.Location = new System.Drawing.Point(192, 28);
            this.radMaps.Margin = new System.Windows.Forms.Padding(1);
            this.radMaps.Name = "radMaps";
            this.radMaps.Size = new System.Drawing.Size(76, 17);
            this.radMaps.TabIndex = 12;
            this.radMaps.TabStop = true;
            this.radMaps.Text = "M.S. Maps";
            this.radMaps.UseVisualStyleBackColor = true;
            this.radMaps.CheckedChanged += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            this.radMaps.Click += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            // 
            // radMS50
            // 
            this.radMS50.AutoSize = true;
            this.radMS50.Location = new System.Drawing.Point(222, 28);
            this.radMS50.Margin = new System.Windows.Forms.Padding(1);
            this.radMS50.Name = "radMS50";
            this.radMS50.Size = new System.Drawing.Size(62, 17);
            this.radMS50.TabIndex = 11;
            this.radMS50.TabStop = true;
            this.radMS50.Text = "M.S. 50";
            this.radMS50.UseVisualStyleBackColor = true;
            this.radMS50.Visible = false;
            this.radMS50.CheckedChanged += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            this.radMS50.Click += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(170, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewPlace
            // 
            this.btnNewPlace.Location = new System.Drawing.Point(316, 123);
            this.btnNewPlace.Name = "btnNewPlace";
            this.btnNewPlace.Size = new System.Drawing.Size(75, 23);
            this.btnNewPlace.TabIndex = 9;
            this.btnNewPlace.Text = "New Place";
            this.btnNewPlace.UseVisualStyleBackColor = true;
            this.btnNewPlace.Click += new System.EventHandler(this.btnNewPlace_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(70, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(407, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(19, 73);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search: ";
            // 
            // radStatus
            // 
            this.radStatus.AutoSize = true;
            this.radStatus.Location = new System.Drawing.Point(423, 28);
            this.radStatus.Name = "radStatus";
            this.radStatus.Size = new System.Drawing.Size(55, 17);
            this.radStatus.TabIndex = 5;
            this.radStatus.TabStop = true;
            this.radStatus.Text = "Status";
            this.radStatus.UseVisualStyleBackColor = true;
            this.radStatus.Click += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            // 
            // radFID
            // 
            this.radFID.AutoSize = true;
            this.radFID.Location = new System.Drawing.Point(374, 28);
            this.radFID.Name = "radFID";
            this.radFID.Size = new System.Drawing.Size(42, 17);
            this.radFID.TabIndex = 4;
            this.radFID.TabStop = true;
            this.radFID.Text = "FID";
            this.radFID.UseVisualStyleBackColor = true;
            this.radFID.Click += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            // 
            // radLocation
            // 
            this.radLocation.AutoSize = true;
            this.radLocation.Location = new System.Drawing.Point(300, 28);
            this.radLocation.Name = "radLocation";
            this.radLocation.Size = new System.Drawing.Size(66, 17);
            this.radLocation.TabIndex = 3;
            this.radLocation.TabStop = true;
            this.radLocation.Text = "Location";
            this.radLocation.UseVisualStyleBackColor = true;
            this.radLocation.CheckedChanged += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            this.radLocation.Click += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            // 
            // radMS250
            // 
            this.radMS250.AutoSize = true;
            this.radMS250.Location = new System.Drawing.Point(159, 28);
            this.radMS250.Name = "radMS250";
            this.radMS250.Size = new System.Drawing.Size(68, 17);
            this.radMS250.TabIndex = 2;
            this.radMS250.TabStop = true;
            this.radMS250.Text = "M.S. 250";
            this.radMS250.UseVisualStyleBackColor = true;
            this.radMS250.Visible = false;
            this.radMS250.CheckedChanged += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            this.radMS250.Click += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            // 
            // radFeature
            // 
            this.radFeature.AutoSize = true;
            this.radFeature.Location = new System.Drawing.Point(89, 28);
            this.radFeature.Name = "radFeature";
            this.radFeature.Size = new System.Drawing.Size(61, 17);
            this.radFeature.TabIndex = 1;
            this.radFeature.TabStop = true;
            this.radFeature.Text = "Feature";
            this.radFeature.UseVisualStyleBackColor = true;
            this.radFeature.Click += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Location = new System.Drawing.Point(28, 28);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(53, 17);
            this.radName.TabIndex = 0;
            this.radName.TabStop = true;
            this.radName.Text = "Name";
            this.radName.UseVisualStyleBackColor = true;
            this.radName.Click += new System.EventHandler(this.MakeSpecificRadioAvailabel);
            // 
            // grpNameList
            // 
            this.grpNameList.Controls.Add(this.grpGroupName);
            this.grpNameList.Controls.Add(this.grpSearchBottom);
            this.grpNameList.Enabled = false;
            this.grpNameList.Location = new System.Drawing.Point(29, 197);
            this.grpNameList.Name = "grpNameList";
            this.grpNameList.Size = new System.Drawing.Size(585, 293);
            this.grpNameList.TabIndex = 2;
            this.grpNameList.TabStop = false;
            this.grpNameList.Text = "Name List";
            // 
            // grpGroupName
            // 
            this.grpGroupName.Controls.Add(this.lblTo);
            this.grpGroupName.Controls.Add(this.label18);
            this.grpGroupName.Controls.Add(this.lblFrom);
            this.grpGroupName.Controls.Add(this.label1);
            this.grpGroupName.Controls.Add(this.lbl50);
            this.grpGroupName.Controls.Add(this.lbl250);
            this.grpGroupName.Controls.Add(this.lblLongitudeSecond);
            this.grpGroupName.Controls.Add(this.lblLongitudeMinute);
            this.grpGroupName.Controls.Add(this.lblLongitudeDegree);
            this.grpGroupName.Controls.Add(this.lblLatitudeSecond);
            this.grpGroupName.Controls.Add(this.lblLatitudeMinute);
            this.grpGroupName.Controls.Add(this.lblLatitudeDegree);
            this.grpGroupName.Controls.Add(this.btnCasualtyHistory);
            this.grpGroupName.Controls.Add(this.label8);
            this.grpGroupName.Controls.Add(this.label7);
            this.grpGroupName.Controls.Add(this.label6);
            this.grpGroupName.Controls.Add(this.label5);
            this.grpGroupName.Controls.Add(this.label4);
            this.grpGroupName.Controls.Add(this.cboFear);
            this.grpGroupName.Controls.Add(this.label3);
            this.grpGroupName.Location = new System.Drawing.Point(315, 19);
            this.grpGroupName.Name = "grpGroupName";
            this.grpGroupName.Size = new System.Drawing.Size(264, 268);
            this.grpGroupName.TabIndex = 1;
            this.grpGroupName.TabStop = false;
            this.grpGroupName.Text = "Group Name";
            // 
            // lblTo
            // 
            this.lblTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTo.Location = new System.Drawing.Point(141, 75);
            this.lblTo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(100, 25);
            this.lblTo.TabIndex = 32;
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTo.UseCompatibleTextRendering = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 81);
            this.label18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Act To:";
            // 
            // lblFrom
            // 
            this.lblFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFrom.Location = new System.Drawing.Point(141, 45);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(100, 24);
            this.lblFrom.TabIndex = 30;
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFrom.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Act From:";
            // 
            // lbl50
            // 
            this.lbl50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl50.Location = new System.Drawing.Point(211, 201);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(30, 22);
            this.lbl50.TabIndex = 26;
            this.lbl50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl250
            // 
            this.lbl250.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl250.Location = new System.Drawing.Point(132, 201);
            this.lbl250.Name = "lbl250";
            this.lbl250.Size = new System.Drawing.Size(30, 22);
            this.lbl250.TabIndex = 25;
            this.lbl250.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLongitudeSecond
            // 
            this.lblLongitudeSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeSecond.Location = new System.Drawing.Point(196, 138);
            this.lblLongitudeSecond.Name = "lblLongitudeSecond";
            this.lblLongitudeSecond.Size = new System.Drawing.Size(45, 22);
            this.lblLongitudeSecond.TabIndex = 23;
            this.lblLongitudeSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLongitudeMinute
            // 
            this.lblLongitudeMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeMinute.Location = new System.Drawing.Point(147, 138);
            this.lblLongitudeMinute.Name = "lblLongitudeMinute";
            this.lblLongitudeMinute.Size = new System.Drawing.Size(30, 22);
            this.lblLongitudeMinute.TabIndex = 22;
            this.lblLongitudeMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLongitudeDegree
            // 
            this.lblLongitudeDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLongitudeDegree.Location = new System.Drawing.Point(102, 138);
            this.lblLongitudeDegree.Name = "lblLongitudeDegree";
            this.lblLongitudeDegree.Size = new System.Drawing.Size(30, 22);
            this.lblLongitudeDegree.TabIndex = 21;
            this.lblLongitudeDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatitudeSecond
            // 
            this.lblLatitudeSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeSecond.Location = new System.Drawing.Point(196, 108);
            this.lblLatitudeSecond.Name = "lblLatitudeSecond";
            this.lblLatitudeSecond.Size = new System.Drawing.Size(45, 22);
            this.lblLatitudeSecond.TabIndex = 20;
            this.lblLatitudeSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatitudeMinute
            // 
            this.lblLatitudeMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeMinute.Location = new System.Drawing.Point(147, 108);
            this.lblLatitudeMinute.Name = "lblLatitudeMinute";
            this.lblLatitudeMinute.Size = new System.Drawing.Size(30, 22);
            this.lblLatitudeMinute.TabIndex = 19;
            this.lblLatitudeMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatitudeDegree
            // 
            this.lblLatitudeDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLatitudeDegree.Location = new System.Drawing.Point(102, 108);
            this.lblLatitudeDegree.Name = "lblLatitudeDegree";
            this.lblLatitudeDegree.Size = new System.Drawing.Size(30, 22);
            this.lblLatitudeDegree.TabIndex = 18;
            this.lblLatitudeDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCasualtyHistory
            // 
            this.btnCasualtyHistory.Location = new System.Drawing.Point(33, 233);
            this.btnCasualtyHistory.Name = "btnCasualtyHistory";
            this.btnCasualtyHistory.Size = new System.Drawing.Size(116, 23);
            this.btnCasualtyHistory.TabIndex = 16;
            this.btnCasualtyHistory.Text = "Casualty History";
            this.btnCasualtyHistory.UseVisualStyleBackColor = true;
            this.btnCasualtyHistory.Click += new System.EventHandler(this.btnCasualtyHistory_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(181, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "50: ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(97, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "250: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Map Sheets: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Longitude: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Latitude: ";
            // 
            // cboFear
            // 
            this.cboFear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFear.FormattingEnabled = true;
            this.cboFear.Location = new System.Drawing.Point(122, 18);
            this.cboFear.Name = "cboFear";
            this.cboFear.Size = new System.Drawing.Size(121, 21);
            this.cboFear.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Feature: ";
            // 
            // grpSearchBottom
            // 
            this.grpSearchBottom.Controls.Add(this.lblFID);
            this.grpSearchBottom.Controls.Add(this.cboStatus);
            this.grpSearchBottom.Controls.Add(this.label2);
            this.grpSearchBottom.Controls.Add(this.chkCasualty);
            this.grpSearchBottom.Controls.Add(this.lbltext);
            this.grpSearchBottom.Controls.Add(this.dgvSearch);
            this.grpSearchBottom.Location = new System.Drawing.Point(15, 19);
            this.grpSearchBottom.Name = "grpSearchBottom";
            this.grpSearchBottom.Size = new System.Drawing.Size(282, 268);
            this.grpSearchBottom.TabIndex = 0;
            this.grpSearchBottom.TabStop = false;
            this.grpSearchBottom.Text = "Search";
            // 
            // lblFID
            // 
            this.lblFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFID.Location = new System.Drawing.Point(37, 227);
            this.lblFID.Name = "lblFID";
            this.lblFID.Size = new System.Drawing.Size(65, 23);
            this.lblFID.TabIndex = 17;
            this.lblFID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(60, 20);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(57, 21);
            this.cboStatus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status: ";
            // 
            // chkCasualty
            // 
            this.chkCasualty.AutoSize = true;
            this.chkCasualty.Enabled = false;
            this.chkCasualty.Location = new System.Drawing.Point(144, 22);
            this.chkCasualty.Name = "chkCasualty";
            this.chkCasualty.Size = new System.Drawing.Size(66, 17);
            this.chkCasualty.TabIndex = 3;
            this.chkCasualty.Text = "Casualty";
            this.chkCasualty.UseVisualStyleBackColor = true;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(11, 230);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(30, 13);
            this.lbltext.TabIndex = 1;
            this.lbltext.Text = "FID: ";
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(6, 54);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(263, 150);
            this.dgvSearch.TabIndex = 0;
            this.dgvSearch.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSearch_DataBindingComplete);
            this.dgvSearch.SelectionChanged += new System.EventHandler(this.dgvSearch_SelectionChanged);
            // 
            // manitoba_MapperTableAdapter
            // 
            this.manitoba_MapperTableAdapter.ClearBeforeFill = true;
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.msMenu.Size = new System.Drawing.Size(666, 24);
            this.msMenu.TabIndex = 3;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // msExit
            // 
            this.msExit.Image = global::IndustryProject.Properties.Resources.exit;
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(92, 22);
            this.msExit.Text = "Exit";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.LoginTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = IndustryProject.LoginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboData
            // 
            this.comboData.DataSetName = "ComboData";
            this.comboData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fEATURETYPESBindingSource
            // 
            this.fEATURETYPESBindingSource.DataMember = "FEATURE_TYPES";
            this.fEATURETYPESBindingSource.DataSource = this.comboData;
            // 
            // fEATURE_TYPESTableAdapter
            // 
            this.fEATURE_TYPESTableAdapter.ClearBeforeFill = true;
            // 
            // comboDataBindingSource
            // 
            this.comboDataBindingSource.DataSource = this.comboData;
            this.comboDataBindingSource.Position = 0;
            // 
            // nAMEPLACESBindingSource
            // 
            this.nAMEPLACESBindingSource.DataMember = "NAME_PLACES";
            this.nAMEPLACESBindingSource.DataSource = this.comboDataBindingSource;
            // 
            // nAME_PLACESTableAdapter
            // 
            this.nAME_PLACESTableAdapter.ClearBeforeFill = true;
            // 
            // fEATURETYPESBindingSource1
            // 
            this.fEATURETYPESBindingSource1.DataMember = "FEATURE_TYPES";
            this.fEATURETYPESBindingSource1.DataSource = this.comboDataBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(666, 497);
            this.Controls.Add(this.grpNameList);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "Form1";
            this.Text = "Indigenous Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.gpCoordinates.ResumeLayout(false);
            this.gpCoordinates.PerformLayout();
            this.grpNameList.ResumeLayout(false);
            this.grpGroupName.ResumeLayout(false);
            this.grpGroupName.PerformLayout();
            this.grpSearchBottom.ResumeLayout(false);
            this.grpSearchBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEATURETYPESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMEPLACESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEATURETYPESBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNewPlace;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.RadioButton radStatus;
        private System.Windows.Forms.RadioButton radFID;
        private System.Windows.Forms.RadioButton radLocation;
        private System.Windows.Forms.RadioButton radMS250;
        private System.Windows.Forms.RadioButton radFeature;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.GroupBox grpNameList;
        private System.Windows.Forms.GroupBox grpGroupName;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl250;
        private System.Windows.Forms.Label lblLongitudeSecond;
        private System.Windows.Forms.Label lblLongitudeMinute;
        private System.Windows.Forms.Label lblLongitudeDegree;
        private System.Windows.Forms.Label lblLatitudeSecond;
        private System.Windows.Forms.Label lblLatitudeMinute;
        private System.Windows.Forms.Label lblLatitudeDegree;
        private System.Windows.Forms.Button btnCasualtyHistory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSearchBottom;
        private System.Windows.Forms.Label lblFID;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCasualty;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.DataGridView dgvSearch;
        private dbIndigenousPlaceNamesDataSetTableAdapters.Manitoba_MapperTableAdapter manitoba_MapperTableAdapter;
        private System.Windows.Forms.RadioButton radMS50;
        private System.Windows.Forms.RadioButton radMaps;
        private System.Windows.Forms.GroupBox gpCoordinates;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLongSec;
        private System.Windows.Forms.TextBox txtLongMin;
        private System.Windows.Forms.TextBox txtLongDeg;
        private System.Windows.Forms.TextBox txtLatSec;
        private System.Windows.Forms.TextBox txtLatMin;
        private System.Windows.Forms.TextBox txtLatDeg;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboFeature;
        private LoginDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private ComboData comboData;
        private System.Windows.Forms.BindingSource fEATURETYPESBindingSource;
        private ComboDataTableAdapters.FEATURE_TYPESTableAdapter fEATURE_TYPESTableAdapter;
        private System.Windows.Forms.BindingSource comboDataBindingSource;
        private System.Windows.Forms.BindingSource nAMEPLACESBindingSource;
        private ComboDataTableAdapters.NAME_PLACESTableAdapter nAME_PLACESTableAdapter;
        private System.Windows.Forms.BindingSource fEATURETYPESBindingSource1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkInactive;
    }
}

