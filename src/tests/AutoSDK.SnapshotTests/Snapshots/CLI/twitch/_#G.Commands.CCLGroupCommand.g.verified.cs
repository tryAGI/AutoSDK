//HintName: G.Commands.CCLGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CCLGroupCommand : global::System.CommandLine.Command
    {
        public CCLGroupCommand(
            GetContentClassificationLabelsCommand command0)
            : base(
                name: "ccl")
        {
            Subcommands.Add(command0);
        }
    }
}