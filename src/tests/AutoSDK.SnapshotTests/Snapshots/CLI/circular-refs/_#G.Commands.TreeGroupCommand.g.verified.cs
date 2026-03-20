//HintName: G.Commands.TreeGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TreeGroupCommand : global::System.CommandLine.Command
    {
        public TreeGroupCommand(
            TreesGetTreesCommand command0,
            TreesCreateTreeCommand command1)
            : base(
                name: "tree")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}