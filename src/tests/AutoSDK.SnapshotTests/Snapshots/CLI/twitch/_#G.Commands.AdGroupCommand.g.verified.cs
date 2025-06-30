//HintName: G.Commands.AdGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdGroupCommand : global::System.CommandLine.Command
    {
        public AdGroupCommand(
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