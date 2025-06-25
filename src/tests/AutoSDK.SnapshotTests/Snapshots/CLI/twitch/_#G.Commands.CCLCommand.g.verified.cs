//HintName: G.Commands.CCLCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CCLCommand : global::System.CommandLine.Command
    {
        public CCLCommand(
            GetContentClassificationLabelsCommand command0)
            : base(
                name: "ccl")
        {
            Subcommands.Add(command0);
        }
    }
}