namespace ASCOM.myDewController
{
    partial class SetupDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDialogForm));
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.RefreshComPortBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comportspeed = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mscthresholdLbl = new System.Windows.Forms.Label();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.ResetControllerChkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(289, 32);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(89, 38);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.Text = "Connect";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(289, 159);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(89, 39);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // RefreshComPortBtn
            // 
            this.RefreshComPortBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshComPortBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RefreshComPortBtn.Location = new System.Drawing.Point(289, 98);
            this.RefreshComPortBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshComPortBtn.Name = "RefreshComPortBtn";
            this.RefreshComPortBtn.Size = new System.Drawing.Size(90, 38);
            this.RefreshComPortBtn.TabIndex = 28;
            this.RefreshComPortBtn.Text = "Refresh";
            this.RefreshComPortBtn.UseVisualStyleBackColor = true;
            this.RefreshComPortBtn.Click += new System.EventHandler(this.RefreshComPortBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 86;
            this.label11.Text = "Port Speed";
            // 
            // comportspeed
            // 
            this.comportspeed.FormattingEnabled = true;
            this.comportspeed.ItemHeight = 20;
            this.comportspeed.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.comportspeed.Location = new System.Drawing.Point(18, 40);
            this.comportspeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comportspeed.Name = "comportspeed";
            this.comportspeed.Size = new System.Drawing.Size(87, 44);
            this.comportspeed.TabIndex = 85;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 28);
            this.comboBox1.TabIndex = 84;
            // 
            // mscthresholdLbl
            // 
            this.mscthresholdLbl.AutoSize = true;
            this.mscthresholdLbl.Location = new System.Drawing.Point(120, 14);
            this.mscthresholdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mscthresholdLbl.Name = "mscthresholdLbl";
            this.mscthresholdLbl.Size = new System.Drawing.Size(38, 20);
            this.mscthresholdLbl.TabIndex = 83;
            this.mscthresholdLbl.Text = "Port";
            // 
            // chkTrace
            // 
            this.chkTrace.AutoSize = true;
            this.chkTrace.Checked = global::ASCOM.myDewController.Properties.Settings.Default.TraceEnabled;
            this.chkTrace.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ASCOM.myDewController.Properties.Settings.Default, "TraceEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTrace.Location = new System.Drawing.Point(18, 109);
            this.chkTrace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(97, 24);
            this.chkTrace.TabIndex = 6;
            this.chkTrace.Text = "Trace on";
            this.chkTrace.UseVisualStyleBackColor = true;
            this.chkTrace.CheckedChanged += new System.EventHandler(this.chkTrace_CheckedChanged);
            // 
            // ResetControllerChkBox
            // 
            this.ResetControllerChkBox.AutoSize = true;
            this.ResetControllerChkBox.Checked = true;
            this.ResetControllerChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResetControllerChkBox.Location = new System.Drawing.Point(18, 144);
            this.ResetControllerChkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetControllerChkBox.Name = "ResetControllerChkBox";
            this.ResetControllerChkBox.Size = new System.Drawing.Size(239, 24);
            this.ResetControllerChkBox.TabIndex = 104;
            this.ResetControllerChkBox.Text = "Reset Controller On Connect";
            this.ResetControllerChkBox.UseVisualStyleBackColor = true;
            // 
            // SetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 229);
            this.Controls.Add(this.ResetControllerChkBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comportspeed);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mscthresholdLbl);
            this.Controls.Add(this.RefreshComPortBtn);
            this.Controls.Add(this.chkTrace);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myDewController ASCOM Setup 102";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupDialogForm_FormClosing);
            this.Load += new System.EventHandler(this.SetupDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.Button RefreshComPortBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox comportspeed;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label mscthresholdLbl;
        private System.Windows.Forms.CheckBox ResetControllerChkBox;
    }
}