namespace TheRects
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboAge = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupMain = new DevExpress.XtraEditors.GroupControl();
            this.cboHeight = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboWeight = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboHandednessFlanders = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboHandednessCoren = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboFootednessCoren = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboEyednessCoren = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cboEarednessCoren = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cboBds = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtComments = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupMain)).BeginInit();
            this.groupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHandednessFlanders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHandednessCoren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFootednessCoren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEyednessCoren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEarednessCoren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComments.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(18, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Όνομα χρήστη:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(505, 272);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(413, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Άκυρο";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(18, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Φύλο:";
            // 
            // cboGender
            // 
            this.cboGender.EditValue = "Άνδρας";
            this.cboGender.Location = new System.Drawing.Point(114, 73);
            this.cboGender.Name = "cboGender";
            this.cboGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGender.Properties.Items.AddRange(new object[] {
            "Άνδρας",
            "Γυναίκα"});
            this.cboGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboGender.Size = new System.Drawing.Size(72, 20);
            this.cboGender.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(18, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ηλικία:";
            // 
            // cboAge
            // 
            this.cboAge.EditValue = "Άνδρας";
            this.cboAge.Location = new System.Drawing.Point(114, 108);
            this.cboAge.Name = "cboAge";
            this.cboAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAge.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboAge.Size = new System.Drawing.Size(72, 20);
            this.cboAge.TabIndex = 4;
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.labelControl12);
            this.groupMain.Controls.Add(this.labelControl1);
            this.groupMain.Controls.Add(this.cboHeight);
            this.groupMain.Controls.Add(this.cboWeight);
            this.groupMain.Controls.Add(this.txtComments);
            this.groupMain.Controls.Add(this.cboAge);
            this.groupMain.Controls.Add(this.txtName);
            this.groupMain.Controls.Add(this.labelControl5);
            this.groupMain.Controls.Add(this.cboGender);
            this.groupMain.Controls.Add(this.labelControl4);
            this.groupMain.Controls.Add(this.labelControl2);
            this.groupMain.Controls.Add(this.labelControl3);
            this.groupMain.Location = new System.Drawing.Point(12, 12);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(337, 254);
            this.groupMain.TabIndex = 5;
            this.groupMain.Text = "Πληροφορίες χρήστη";
            this.groupMain.Paint += new System.Windows.Forms.PaintEventHandler(this.groupMain_Paint);
            // 
            // cboHeight
            // 
            this.cboHeight.EditValue = "Άνδρας";
            this.cboHeight.Location = new System.Drawing.Point(114, 181);
            this.cboHeight.Name = "cboHeight";
            this.cboHeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHeight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboHeight.Size = new System.Drawing.Size(72, 20);
            this.cboHeight.TabIndex = 4;
            // 
            // cboWeight
            // 
            this.cboWeight.EditValue = "Άνδρας";
            this.cboWeight.Location = new System.Drawing.Point(114, 144);
            this.cboWeight.Name = "cboWeight";
            this.cboWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboWeight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboWeight.Size = new System.Drawing.Size(72, 20);
            this.cboWeight.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(18, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Ύψος (μέτρα):";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(18, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Βάρος (κιλά):";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.cboBds);
            this.groupControl1.Controls.Add(this.cboEarednessCoren);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.cboEyednessCoren);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.cboFootednessCoren);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.cboHandednessCoren);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cboHandednessFlanders);
            this.groupControl1.Location = new System.Drawing.Point(355, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(225, 254);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Παράμετροι πειράματος";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(14, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(121, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Handedness FLANDERS:";
            // 
            // cboHandednessFlanders
            // 
            this.cboHandednessFlanders.EditValue = "";
            this.cboHandednessFlanders.Location = new System.Drawing.Point(150, 38);
            this.cboHandednessFlanders.Name = "cboHandednessFlanders";
            this.cboHandednessFlanders.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHandednessFlanders.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboHandednessFlanders.Size = new System.Drawing.Size(55, 20);
            this.cboHandednessFlanders.TabIndex = 4;
            // 
            // cboHandednessCoren
            // 
            this.cboHandednessCoren.EditValue = "";
            this.cboHandednessCoren.Location = new System.Drawing.Point(150, 73);
            this.cboHandednessCoren.Name = "cboHandednessCoren";
            this.cboHandednessCoren.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHandednessCoren.Properties.Items.AddRange(new object[] {
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10"});
            this.cboHandednessCoren.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboHandednessCoren.Size = new System.Drawing.Size(55, 20);
            this.cboHandednessCoren.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(14, 76);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(121, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Handedness COREN:";
            // 
            // cboFootednessCoren
            // 
            this.cboFootednessCoren.EditValue = "";
            this.cboFootednessCoren.Location = new System.Drawing.Point(150, 108);
            this.cboFootednessCoren.Name = "cboFootednessCoren";
            this.cboFootednessCoren.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFootednessCoren.Properties.Items.AddRange(new object[] {
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10"});
            this.cboFootednessCoren.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboFootednessCoren.Size = new System.Drawing.Size(55, 20);
            this.cboFootednessCoren.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(14, 111);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(121, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Footedness COREN:";
            // 
            // cboEyednessCoren
            // 
            this.cboEyednessCoren.EditValue = "";
            this.cboEyednessCoren.Location = new System.Drawing.Point(150, 144);
            this.cboEyednessCoren.Name = "cboEyednessCoren";
            this.cboEyednessCoren.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEyednessCoren.Properties.Items.AddRange(new object[] {
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10"});
            this.cboEyednessCoren.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboEyednessCoren.Size = new System.Drawing.Size(55, 20);
            this.cboEyednessCoren.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(14, 147);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(121, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Eyedness COREN:";
            // 
            // cboEarednessCoren
            // 
            this.cboEarednessCoren.EditValue = "";
            this.cboEarednessCoren.Location = new System.Drawing.Point(150, 181);
            this.cboEarednessCoren.Name = "cboEarednessCoren";
            this.cboEarednessCoren.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEarednessCoren.Properties.Items.AddRange(new object[] {
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10"});
            this.cboEarednessCoren.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboEarednessCoren.Size = new System.Drawing.Size(55, 20);
            this.cboEarednessCoren.TabIndex = 4;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.Location = new System.Drawing.Point(14, 184);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(121, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Earedness COREN:";
            // 
            // cboBds
            // 
            this.cboBds.EditValue = "";
            this.cboBds.Location = new System.Drawing.Point(150, 218);
            this.cboBds.Name = "cboBds";
            this.cboBds.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBds.Properties.Items.AddRange(new object[] {
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10"});
            this.cboBds.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboBds.Size = new System.Drawing.Size(55, 20);
            this.cboBds.TabIndex = 4;
            this.cboBds.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit5_SelectedIndexChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(14, 221);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(121, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "BDS:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(114, 218);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(205, 20);
            this.txtComments.TabIndex = 1;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Location = new System.Drawing.Point(18, 221);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(75, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "Σχόλια:";
            // 
            // frmUser
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(592, 307);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Νέος Χρήστης";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupMain)).EndInit();
            this.groupMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboHeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboHandednessFlanders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHandednessCoren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFootednessCoren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEyednessCoren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEarednessCoren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComments.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboGender;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboAge;
        private DevExpress.XtraEditors.GroupControl groupMain;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.ComboBoxEdit cboHeight;
        private DevExpress.XtraEditors.ComboBoxEdit cboWeight;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cboHandednessFlanders;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit cboEarednessCoren;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cboEyednessCoren;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cboFootednessCoren;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cboHandednessCoren;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cboBds;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtComments;
    }
}