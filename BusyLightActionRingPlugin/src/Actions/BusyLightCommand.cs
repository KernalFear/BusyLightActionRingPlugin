namespace Loupedeck.BusyLightActionRingPlugin
{
    using System;

    // Command: set the BusyLight to solid red.
    public class BusyLightRedCommand : PluginDynamicCommand
    {
        // Initializes the command class.
        public BusyLightRedCommand()
            : base(displayName: "Busy", description: "Set BusyLight to solid red", groupName: "BusyLight")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            // For now, create a controller instance for this call only.
            using (var controller = new BusyLightController())
            {
                controller.SetRed();
            }
        }
    }

    public class BusyLightGreenCommand : PluginDynamicCommand
    {
        // Initializes the command class.
        public BusyLightGreenCommand()
            : base(displayName: "Available", description: "Set BusyLight to solid green", groupName: "BusyLight")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            using (var controller = new BusyLightController())
            {
                controller.SetGreen();
            }
        }
    }

    public class BusyLightTealCommand : PluginDynamicCommand
    {
        // Initializes the command class.
        public BusyLightTealCommand()
            : base(displayName: "Headphones", description: "Set BusyLight to solid magenta", groupName: "BusyLight")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            using (var controller = new BusyLightController())
            {
                controller.SetMagenta();
            }
        }
    }

    public class BusyLightMagentaCommand : PluginDynamicCommand
    {
        // Initializes the command class.
        public BusyLightMagentaCommand()
            : base(displayName: "Deep Focus", description: "Set BusyLight to solid blue", groupName: "BusyLight")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            using (var controller = new BusyLightController())
            {
                controller.SetBlue();
            }
        }
    }

    // Command: set the BusyLight to solid yellow.
    public class BusyLightYellowCommand : PluginDynamicCommand
    {
        // Initializes the command class.
        public BusyLightYellowCommand()
            : base(displayName: "Away", description: "Set BusyLight to solid Yellow", groupName: "BusyLight")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            // For now, create a controller instance for this call only.
            using (var controller = new BusyLightController())
            {
                controller.SetYellow();
            }
        }
    }
    // Command: set the BusyLight to off.
    public class BusyLightOffCommand : PluginDynamicCommand
    {
        // Initializes the command class.
        public BusyLightOffCommand()
            : base(displayName: "BusyLight Off", description: "Turn BusyLight off", groupName: "BusyLight")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            using (var controller = new BusyLightController())
            {
                controller.TurnOff();
            }
        }
    }
}