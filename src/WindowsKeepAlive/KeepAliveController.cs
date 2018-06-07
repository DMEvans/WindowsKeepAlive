namespace WindowsKeepAlive
{
    using System;
    using System.Runtime.InteropServices;

    public static class KeepAliveController
    {
        [Flags]
        public enum ExecutionStates : uint
        {
            AwayModeRequired = 0x00000040,
            Continuous = 0x80000000,
            DisplayRequired = 0x00000002,
            SystemRequired = 0x00000001
        }
        
        public static void Activate()
        {
            SetThreadExecutionState(ExecutionStates.DisplayRequired | ExecutionStates.Continuous);
        }

        public static void Deactivate()
        {
            SetThreadExecutionState(ExecutionStates.Continuous);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern ExecutionStates SetThreadExecutionState(ExecutionStates executionStateFlags);
    }
}