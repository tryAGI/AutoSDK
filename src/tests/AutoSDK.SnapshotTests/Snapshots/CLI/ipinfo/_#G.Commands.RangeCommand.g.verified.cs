//HintName: G.Commands.RangeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RangeCommand : global::System.CommandLine.Command
    {
        public RangeCommand(
            GetRangesCommand command0)
            : base(
                name: "range")
        {
            Subcommands.Add(command0);
        }
    }
}