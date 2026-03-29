//HintName: G.Commands.CollectionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionGroupCommand : global::System.CommandLine.Command
    {
        public CollectionGroupCommand(
            CollectionsCollectionExistsCommand command0,
            CollectionsCreateCollectionCommand command1,
            CollectionsDeleteCollectionCommand command2,
            CollectionsGetCollectionCommand command3,
            CollectionsGetCollectionsCommand command4,
            CollectionsGetOptimizationsCommand command5,
            CollectionsUpdateCollectionCommand command6)
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