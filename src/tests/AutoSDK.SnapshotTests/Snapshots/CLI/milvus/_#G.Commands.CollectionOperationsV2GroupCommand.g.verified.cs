//HintName: G.Commands.CollectionOperationsV2GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CollectionOperationsV2GroupCommand : global::System.CommandLine.Command
    {
        public CollectionOperationsV2GroupCommand(
            CollectionOperationsV2CreateVectordbCollectionsCreateCommand command0,
            CollectionOperationsV2CreateVectordbCollectionsDescribeCommand command1,
            CollectionOperationsV2CreateVectordbCollectionsDropCommand command2,
            CollectionOperationsV2CreateVectordbCollectionsGetLoadStateCommand command3,
            CollectionOperationsV2CreateVectordbCollectionsGetStatsCommand command4,
            CollectionOperationsV2CreateVectordbCollectionsHasCommand command5,
            CollectionOperationsV2CreateVectordbCollectionsListCommand command6,
            CollectionOperationsV2CreateVectordbCollectionsLoadCommand command7,
            CollectionOperationsV2CreateVectordbCollectionsReleaseCommand command8,
            CollectionOperationsV2CreateVectordbCollectionsRenameCommand command9)
            : base(
                name: "collectionoperationsv2")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
        }
    }
}