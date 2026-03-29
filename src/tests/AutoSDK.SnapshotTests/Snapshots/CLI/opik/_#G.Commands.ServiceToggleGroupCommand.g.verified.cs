//HintName: G.Commands.ServiceToggleGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ServiceToggleGroupCommand : global::System.CommandLine.Command
    {
        public ServiceToggleGroupCommand(
            ServiceTogglesGetServiceTogglesCommand command0)
            : base(
                name: "servicetoggle")
        {
            Subcommands.Add(command0);
        }
    }
}