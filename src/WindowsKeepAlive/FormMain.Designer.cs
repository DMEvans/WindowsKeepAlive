namespace WindowsKeepAlive
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxItemActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ctxItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDeactivateTimer = new System.Windows.Forms.CheckBox();
            this.numDeactivateTimer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeactivateTimer)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.ctxMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Windows Keep Alive";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxItemActivate,
            this.ctxSeparator,
            this.ctxItemClose});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(118, 54);
            // 
            // ctxItemActivate
            // 
            this.ctxItemActivate.Name = "ctxItemActivate";
            this.ctxItemActivate.Size = new System.Drawing.Size(117, 22);
            this.ctxItemActivate.Text = "Activate";
            this.ctxItemActivate.Click += new System.EventHandler(this.ctxItemActivate_Click);
            // 
            // ctxSeparator
            // 
            this.ctxSeparator.Name = "ctxSeparator";
            this.ctxSeparator.Size = new System.Drawing.Size(114, 6);
            // 
            // ctxItemClose
            // 
            this.ctxItemClose.Name = "ctxItemClose";
            this.ctxItemClose.Size = new System.Drawing.Size(117, 22);
            this.ctxItemClose.Text = "Close";
            this.ctxItemClose.Click += new System.EventHandler(this.ctxItemClose_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(12, 71);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(344, 40);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Activate";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This tool will prevent Windows from locking or entering sleep mode ";
            // 
            // chkDeactivateTimer
            // 
            this.chkDeactivateTimer.AutoSize = true;
            this.chkDeactivateTimer.Location = new System.Drawing.Point(16, 40);
            this.chkDeactivateTimer.Name = "chkDeactivateTimer";
            this.chkDeactivateTimer.Size = new System.Drawing.Size(102, 17);
            this.chkDeactivateTimer.TabIndex = 3;
            this.chkDeactivateTimer.Text = "Deactivate after";
            this.chkDeactivateTimer.UseVisualStyleBackColor = true;
            this.chkDeactivateTimer.CheckedChanged += new System.EventHandler(this.chkDeactivateTimer_CheckedChanged);
            // 
            // numDeactivateTimer
            // 
            this.numDeactivateTimer.Enabled = false;
            this.numDeactivateTimer.Location = new System.Drawing.Point(117, 38);
            this.numDeactivateTimer.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numDeactivateTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDeactivateTimer.Name = "numDeactivateTimer";
            this.numDeactivateTimer.Size = new System.Drawing.Size(60, 20);
            this.numDeactivateTimer.TabIndex = 4;
            this.numDeactivateTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDeactivateTimer.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "minutes";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 120);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(369, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip";
            // 
            // lblVersion
            // 
            this.lblVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(85, 17);
            this.lblVersion.Text = "Version: 0.0.0.0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 142);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDeactivateTimer);
            this.Controls.Add(this.chkDeactivateTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 180);
            this.MinimumSize = new System.Drawing.Size(385, 180);
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Windows Keep Alive";
            this.TopMost = true;
            this.ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDeactivateTimer)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDeactivateTimer;
        private System.Windows.Forms.NumericUpDown numDeactivateTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxItemActivate;
        private System.Windows.Forms.ToolStripSeparator ctxSeparator;
        private System.Windows.Forms.ToolStripMenuItem ctxItemClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    }
}

