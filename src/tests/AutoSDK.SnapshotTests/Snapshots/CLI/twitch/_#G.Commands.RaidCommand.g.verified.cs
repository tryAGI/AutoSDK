//HintName: G.Commands.RaidCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RaidCommand : global::System.CommandLine.Command
    {
        public RaidCommand(
            StartARaidCommand command0,
            CancelARaidCommand command1)
            : base(
                name: "raid")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}