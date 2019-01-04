namespace TheRects
{
    partial class frmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tmrQuiz = new System.Windows.Forms.Timer(this.components);
            this.btnRepeat = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.lblCountdown = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPause = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.Location = new System.Drawing.Point(816, 685);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 42);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Επόμενο";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(12, 14);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(925, 595);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblId.Appearance.Options.UseFont = true;
            this.lblId.Location = new System.Drawing.Point(104, 642);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 19);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "1/100";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // tmrQuiz
            // 
            this.tmrQuiz.Interval = 1000;
            this.tmrQuiz.Tick += new System.EventHandler(this.tmrQuiz_Tick);
            // 
            // btnRepeat
            // 
            this.btnRepeat.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnRepeat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeat.ImageOptions.Image")));
            this.btnRepeat.Location = new System.Drawing.Point(689, 685);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(121, 42);
            this.btnRepeat.TabIndex = 0;
            this.btnRepeat.Text = "Επανάληψη";
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AllowHtmlString = true;
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblStatus.Appearance.Options.UseFont = true;
            this.lblStatus.Appearance.Options.UseTextOptions = true;
            this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Location = new System.Drawing.Point(537, 642);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Πατήστε στο";
            // 
            // lblCountdown
            // 
            this.lblCountdown.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCountdown.Appearance.Options.UseFont = true;
            this.lblCountdown.Location = new System.Drawing.Point(104, 694);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(18, 19);
            this.lblCountdown.TabIndex = 2;
            this.lblCountdown.Text = "60";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 694);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Χρόνος:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 642);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Πρόοδος:";
            // 
            // btnPause
            // 
            this.btnPause.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnPause.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.ImageOptions.Image")));
            this.btnPause.Location = new System.Drawing.Point(164, 685);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(121, 42);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Παύση";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 748);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmQuiz";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNext;
        private System.Windows.Forms.PictureBox picCanvas;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Timer tmrQuiz;
        private DevExpress.XtraEditors.SimpleButton btnRepeat;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.LabelControl lblCountdown;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPause;
    }
}