namespace Loupedeck.BusyLightActionRingPlugin
{
    using System;

    // Command: set the BusyLight to solid red.
    public class BusyLightRedCommand : PluginDynamicCommand
    {
        // Initializes the command class.
        public BusyLightRedCommand()
            : base(displayName: "Busy (Red)", description: "Set BusyLight to solid red", groupName: "BusyLight")
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
            : base(displayName: "Available (Green)", description: "Set BusyLight to solid green", groupName: "BusyLight")
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
            : base(displayName: "BusyLight Teal", description: "Set BusyLight to solid teal", groupName: "BusyLight")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            using (var controller = new BusyLightController())
            {
                controller.SetTeal();
            }
        }
    }

    public class BusyLightMagentaCommand : PluginDynamicCommand
    {
        // Initializes the command class.
        public BusyLightMagentaCommand()
            : base(displayName: "BusyLight Magenta", description: "Set BusyLight to solid Magenta", groupName: "BusyLight")
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