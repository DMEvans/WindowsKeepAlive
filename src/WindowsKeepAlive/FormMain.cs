namespace WindowsKeepAlive
{
    using System;
    using System.Windows.Forms;

    public partial class FormMain : Form
    {
        private bool _isActive;
        private System.Timers.Timer _deactivateTimer;
        private string _balloonTitle = "Windows KeepAlive";

        public FormMain()
        {
            InitializeComponent();

            _deactivateTimer = new System.Timers.Timer();
            _deactivateTimer.AutoReset = false;
            _deactivateTimer.Elapsed += _deactivateTimer_Elapsed;
        }

        private void _deactivateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(ProcessKeepAlive));
        }

        private void btnAction_Click(object sender, System.EventArgs e)
        {
            ProcessKeepAlive();
        }

        private void ProcessKeepAlive()
        {
            if (_isActive)
            {
                DeactivateKeepAlive();
            }
            else
            {
                ActivateKeepAlive();
            }

            _isActive = !_isActive;
            EnableDisableControls();
            SetActionButtonText();
        }

        private void DeactivateKeepAlive()
        {
            _deactivateTimer.Stop();
            notifyIcon.ShowBalloonTip(10000, _balloonTitle, "KeepAlive deactivated", ToolTipIcon.Info);
            KeepAliveController.Deactivate();
        }

        private void ActivateKeepAlive()
        {
            
            var message = string.Empty;

            if (chkDeactivateTimer.Checked)
            {
                var minutes = numDeactivateTimer.Value;
                var interval = (double)minutes * 60 * 1000;

                _deactivateTimer.Interval = interval;
                _deactivateTimer.Start();

                var aliveUntil = DateTime.Now.AddMilliseconds(interval);
                message = string.Format("KeepAlive active until {0}", aliveUntil.ToString("HH:mm:ss"));
            }
            else
            {
                message = "KeepAlive active indefinitely";
            }

            notifyIcon.ShowBalloonTip(10000, _balloonTitle, message, ToolTipIcon.Info);
            SetFormVisibility(false);
            KeepAliveController.Activate();
        }

        private void SetFormVisibility(bool visible)
        {
            this.Visible = visible;
            this.ShowInTaskbar = visible;
        }

        private void EnableDisableControls()
        {
            chkDeactivateTimer.Enabled = !_isActive;
            numDeactivateTimer.Enabled = !_isActive && chkDeactivateTimer.Checked;
        }

        private void SetActionButtonText()
        {
            var actionText = _isActive ? "Deactivate" : "Activate";
            btnAction.Text = actionText;
            ctxItemActivate.Text = actionText;
        }

        private void chkDeactivateTimer_CheckedChanged(object sender, System.EventArgs e)
        {
            numDeactivateTimer.Enabled = chkDeactivateTimer.Checked;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetFormVisibility(true);
        }

        private void ctxItemActivate_Click(object sender, EventArgs e)
        {
            ProcessKeepAlive();
        }

        private void ctxItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}