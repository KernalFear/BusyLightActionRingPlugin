namespace Loupedeck.BusyLightActionRingPlugin
{
    using System;
    using Busylight;   // From the SDK NuGet package

    /// <summary>
    /// Wrapper around the Busylight SDK.
    /// This is your original working controller, moved into the new plugin namespace.
    /// </summary>
    public class BusyLightController : IDisposable
    {
        private readonly SDK _sdk;

        public BusyLightController()
        {
            // Create SDK instance and scan/check devices.
            this._sdk = new SDK();
            this._sdk.CheckUSB();
        }

        /// <summary>
        /// Set the Busylight to solid red.
        /// </summary>
        public void SetRed() =>
            this._sdk.Light(BusylightColor.Red);

        /// <summary>
        /// Set the Busylight to solid green.
        /// </summary>
        public void SetGreen() =>
            this._sdk.Light(BusylightColor.Green);

        /// <summary>
        /// Set the Busylight to solid blue.
        /// </summary>
        public void SetBlue() =>
            this._sdk.Light(BusylightColor.Blue);

        /// <summary>
        /// Set the Busylight to solid yellow.
        /// </summary>
        public void SetYellow() =>
            this._sdk.Light(BusylightColor.Yellow);

        /// <summary>
        /// Turn the Busylight to solid cyan.
        /// </summary>
        public void SetCyan() =>
            this._sdk.Light(0, 100, 100);
        
        /// <summary>
        /// Turn the Busylight to solid orange.
        /// </summary>
        public void SetOrange() =>
            this._sdk.Light(100, 0, 65);

        /// <summary>
        /// Turn the Busylight to solid magenta.
        /// </summary>
        public void SetMagenta() =>
            this._sdk.Light(100, 100, 0);

        /// <summary>
        /// Turn the Busylight to Pulse Red.
        /// </summary>
        public void SetPulseRed() =>
            this._sdk.Pulse(BusylightColor.Red);

        /// <summary>
        /// Turn the Busylight to Flash Red & Green.
        /// </summary>
        public void SetFlashRedGreen() =>
            this._sdk.ColorWithFlash(BusylightColor.Red, BusylightColor.Green);

        /// <summary>
        /// Turn the Busylight to Green & play Alert.
        /// </summary>
        public void SetGreenPlayAlert() =>
            this._sdk.Alert(BusylightColor.Green, BusylightSoundClip.Funky, BusylightVolume.Max);

        /// <summary>
        /// Turn the Busylight off.
        /// </summary>
        public void TurnOff() =>
            this._sdk.Light(BusylightColor.Off);

        /// <summary>
        /// Clean up the SDK when we're done.
        /// </summary>
        public void Dispose()
        {

        }

    }
}