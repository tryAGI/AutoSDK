//HintName: G.Commands.SystemGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SystemGroupCommand : global::System.CommandLine.Command
    {
        public SystemGroupCommand(
            SystemHealthcheckCommand command0,
            SystemHeartbeatCommand command1,
            SystemPreFlightChecksCommand command2,
            SystemVersionCommand command3)
            : base(
                name: "system")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}