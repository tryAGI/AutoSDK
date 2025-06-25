//HintName: G.Commands.RootCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RootCommand : global::System.CommandLine.Command
    {
        public RootCommand(
            WeaviateRootCommand command0)
            : base(
                name: "root")
        {
            Subcommands.Add(command0);
        }
    }
}