//HintName: G.Commands.AdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdCommand : global::System.CommandLine.Command
    {
        public AdCommand(
            StartCommercialCommand command0,
            GetAdScheduleCommand command1,
            SnoozeNextAdCommand command2)
            : base(
                name: "ad")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}