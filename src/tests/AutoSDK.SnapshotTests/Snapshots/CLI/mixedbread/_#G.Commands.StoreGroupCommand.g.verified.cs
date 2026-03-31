//HintName: G.Commands.StoreGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StoreGroupCommand : global::System.CommandLine.Command
    {
        public StoreGroupCommand(
            StoresCreateQuestionAnsweringCommand command0,
            StoresCreateSearchRuleCommand command1,
            StoresCreateStoreCommand command2,
            StoresCreateStoreFileCommand command3,
            StoresDeleteSearchRuleCommand command4,
            StoresDeleteSpecificSearchRuleCommand command5,
            StoresDeleteStoreCommand command6,
            StoresDeleteStoreFileCommand command7,
            StoresGetMetadataFacetsCommand command8,
            StoresGetStoreEventHistogramCommand command9,
            StoresListStoreEventsCommand command10,
            StoresListStoreFilesCommand command11,
            StoresListStoreFilesWithMetadataFilterCommand command12,
            StoresListStoresCommand command13,
            StoresRetrieveSearchRuleCommand command14,
            StoresRetrieveStoreCommand command15,
            StoresRetrieveStoreFileCommand command16,
            StoresSearchStoreChunksCommand command17,
            StoresSearchStoreFilesCommand command18,
            StoresUpdateSearchRuleCommand command19,
            StoresUpdateStoreCommand command20,
            StoresUpdateStoreFileCommand command21,
            StoresUploadStoreFileCommand command22)
            : base(
                name: "store")
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
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
            Subcommands.Add(command22);
        }
    }
}