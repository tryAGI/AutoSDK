//HintName: G.Commands.IndexeGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IndexeGroupCommand : global::System.CommandLine.Command
    {
        public IndexeGroupCommand(
            IndexesCreateFieldIndexCommand command0,
            IndexesDeleteFieldIndexCommand command1)
            : base(
                name: "indexe")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}