//HintName: G.Commands.RaidGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RaidGroupCommand : global::System.CommandLine.Command
    {
        public RaidGroupCommand(
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