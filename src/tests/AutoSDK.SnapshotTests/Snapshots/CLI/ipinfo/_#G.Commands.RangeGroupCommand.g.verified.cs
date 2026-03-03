//HintName: G.Commands.RangeGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RangeGroupCommand : global::System.CommandLine.Command
    {
        public RangeGroupCommand(
            GetRangesCommand command0)
            : base(
                name: "range")
        {
            Subcommands.Add(command0);
        }
    }
}