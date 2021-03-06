﻿namespace WindowsKeepAlive
{
    using System;
    using System.Windows.Forms;

    public partial class FormMain : Form
    {
        private string _balloonTitle = "Windows KeepAlive";
        private System.Timers.Timer _deactivateTimer;
        private bool _isActive;
        private System.Timers.Timer _updateRefreshTimer;

        public FormMain()
        {
            InitializeComponent();
            lblVersion.Text = "Version: " + Application.ProductVersion;

            _deactivateTimer = new System.Timers.Timer();
            _deactivateTimer.AutoReset = false;
            _deactivateTimer.Elapsed += _deactivateTimer_Elapsed;

            _updateRefreshTimer = new System.Timers.Timer();
            _updateRefreshTimer.Interval = 30000;
            _updateRefreshTimer.AutoReset = true;
            _updateRefreshTimer.Elapsed += _updateRefreshTimer_Elapsed;


            timePicker.Value = DateTime.Today.AddHours(17);
        }

        private void _deactivateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(ProcessKeepAlive));
        }

        private void _updateRefreshTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            KeepAliveController.Activate();
        }

        private void ActivateKeepAlive()
        {
            var message = string.Empty;

            if (rdoDeactivateAfter.Checked)
            {
                var minutes = numDeactivateTimer.Value;
                var interval = (double)minutes * 60 * 1000;

                _deactivateTimer.Interval = interval;
                _deactivateTimer.Start();

                var aliveUntil = DateTime.Now.AddMilliseconds(interval);
                message = string.Format("KeepAlive active until {0}", aliveUntil.ToString("HH:mm:ss"));
            }
            else if (rdoDeactivateAt.Checked)
            {
                var time = timePicker.Value < DateTime.Now ? timePicker.Value.AddDays(1) : timePicker.Value;
                var timeSpan = time - DateTime.Now;

                _deactivateTimer.Interval = timeSpan.TotalMilliseconds;
                _deactivateTimer.Start();

                message = string.Format("KeepAlive active until {0}", time.ToString("HH:mm:ss"));
            }
            else
            {
                message = "KeepAlive active indefinitely";
            }

            notifyIcon.ShowBalloonTip(10000, _balloonTitle, message, ToolTipIcon.Info);
            SetFormVisibility(false);
            KeepAliveController.Activate();
            _updateRefreshTimer.Start();
        }

        private void btnAction_Click(object sender, System.EventArgs e)
        {
            ProcessKeepAlive();
        }
        
        private void rdoDeactivateAt_CheckedChanged(object sender, EventArgs e)
        {
            timePicker.Enabled = (sender as RadioButton).Checked;
        }

        private void rdoDeactivateAfter_CheckedChanged(object sender, EventArgs e)
        {
            numDeactivateTimer.Enabled = (sender as RadioButton).Checked;
        }

        private void ctxItemActivate_Click(object sender, EventArgs e)
        {
            ProcessKeepAlive();
        }

        private void ctxItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeactivateKeepAlive()
        {
            _updateRefreshTimer.Stop();
            _deactivateTimer.Stop();
            notifyIcon.ShowBalloonTip(10000, _balloonTitle, "KeepAlive deactivated", ToolTipIcon.Info);
            KeepAliveController.Deactivate();
        }

        private void EnableDisableControls()
        {
            rdoIndefinite.Enabled = !_isActive;
            rdoDeactivateAfter.Enabled = !_isActive;
            numDeactivateTimer.Enabled = !_isActive && rdoDeactivateAfter.Checked;
            rdoDeactivateAt.Enabled = !_isActive;
            timePicker.Enabled = !_isActive && rdoDeactivateAt.Checked;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetFormVisibility(true);
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

        private void SetActionButtonText()
        {
            var actionText = _isActive ? "Deactivate" : "Activate";
            btnAction.Text = actionText;
            ctxItemActivate.Text = actionText;
        }

        private void SetFormVisibility(bool visible)
        {
            this.Visible = visible;
            this.ShowInTaskbar = visible;
        }
       
    }
}