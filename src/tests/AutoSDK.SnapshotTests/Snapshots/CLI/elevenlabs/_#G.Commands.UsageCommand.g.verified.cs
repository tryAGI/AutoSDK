//HintName: G.Commands.UsageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UsageCommand : global::System.CommandLine.Command
    {
        public UsageCommand(
            GetUsageCharacterStatsCommand command0)
            : base(
                name: "usage")
        {
            Subcommands.Add(command0);
        }
    }
}