//HintName: G.Commands.CollectionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionGroupCommand : global::System.CommandLine.Command
    {
        public CollectionGroupCommand(
            CollectionCountCollectionsCommand command0,
            CollectionCreateCollectionCommand command1,
            CollectionDeleteCollectionCommand command2,
            CollectionForkCollectionCommand command3,
            CollectionGetCollectionCommand command4,
            CollectionListCollectionsCommand command5,
            CollectionUpdateCollectionCommand command6)
            : base(
                name: "collection")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
        }
    }
}