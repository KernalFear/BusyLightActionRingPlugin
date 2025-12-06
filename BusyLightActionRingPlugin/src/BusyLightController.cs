namespace Loupedeck.BusyLightActionRingPlugin
{
    using System;
    using Busylight;   // From the SDK NuGet package
    using Loupedeck;   // For PluginLog

    /// <summary>
    /// Wrapper around the Busylight SDK with basic error handling.
    /// </summary>
    public class BusyLightController : IDisposable
    {
        // SDK instance is readonly: it is only assigned in the constructor.
        private readonly SDK _sdk;

        // Simple "am I usable?" flag, as a readonly auto property.
        private Boolean IsAvailable { get; }

        public BusyLightController()
        {
            try
            {
                // Try to create the SDK instance and scan/check devices.
                this._sdk = new SDK();
                this._sdk.CheckUSB();

                this.IsAvailable = true;
            }
            catch (Exception ex)
            {
                // If anything goes wrong during SDK init, mark as unavailable
                // so calls into the controller become safe no-ops instead of throwing.
                this._sdk = null;
                this.IsAvailable = false;

                // Log the failure so it shows up in the plugin log file.
                PluginLog.Error($"BusyLightController initialization failed: {ex.Message}");
            }
        }

        /// <summary>
        /// Returns true if the SDK is initialised and the controller can talk to the device.
        /// </summary>
        private Boolean IsReady =>
            this.IsAvailable && (this._sdk is not null);

        /// <summary>
        /// Set the Busylight to solid red.
        /// </summary>
        public void SetRed()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Light(BusylightColor.Red);
        }

        /// <summary>
        /// Set the Busylight to solid green.
        /// </summary>
        public void SetGreen()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Light(BusylightColor.Green);
        }

        /// <summary>
        /// Set the Busylight to solid blue.
        /// </summary>
        public void SetBlue()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Light(BusylightColor.Blue);
        }

        /// <summary>
        /// Set the Busylight to solid yellow.
        /// </summary>
        public void SetYellow()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Light(BusylightColor.Yellow);
        }

        /// <summary>
        /// Turn the Busylight to solid cyan.
        /// </summary>
        public void SetCyan()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Light(0, 100, 100);
        }

        /// <summary>
        /// Turn the Busylight to solid orange.
        /// </summary>
        public void SetOrange()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Light(100, 0, 65);
        }

        /// <summary>
        /// Turn the Busylight to solid magenta.
        /// </summary>
        public void SetMagenta()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Light(100, 100, 0);
        }

        /// <summary>
        /// Turn the Busylight to Pulse Red.
        /// </summary>
        public void SetPulseRed()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Pulse(BusylightColor.Red);
        }

        /// <summary>
        /// Turn the Busylight to Flash Red &amp; Green.
        /// </summary>
        public void SetFlashRedGreen()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.ColorWithFlash(BusylightColor.Red, BusylightColor.Green);
        }

        /// <summary>
        /// Turn the Busylight to Green &amp; play Alert.
        /// </summary>
        public void SetGreenPlayAlert()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Alert(BusylightColor.Green, BusylightSoundClip.Funky, BusylightVolume.Max);
        }

        /// <summary>
        /// Turn the Busylight off.
        /// </summary>
        public void TurnOff()
        {
            if (!this.IsReady)
            {
                return;
            }

            this._sdk.Light(BusylightColor.Off);
        }

        /// <summary>
        /// Clean up the SDK when we're done.
        /// </summary>
        public void Dispose()
        {
            // Intentionally left empty for now.
            // Calling _sdk.Terminate() here would immediately clear the light
            // when commands use "using (var controller = new BusyLightController()) { ... }".
            //
            // Once we manage SDK lifetime at plugin level instead of per-command, we can
            // revisit where Terminate() belongs.
        }
    }
}
