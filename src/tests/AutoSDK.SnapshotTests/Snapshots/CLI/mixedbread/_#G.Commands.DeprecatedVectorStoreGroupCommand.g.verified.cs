//HintName: G.Commands.DeprecatedVectorStoreGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeprecatedVectorStoreGroupCommand : global::System.CommandLine.Command
    {
        public DeprecatedVectorStoreGroupCommand(
            DeprecatedVectorStoresCreateVectorStoreCommand command0,
            DeprecatedVectorStoresCreateVectorStoreFileCommand command1,
            DeprecatedVectorStoresDeleteVectorStoreCommand command2,
            DeprecatedVectorStoresDeleteVectorStoreFileCommand command3,
            DeprecatedVectorStoresDeprecatedCreateQuestionAnsweringCommand command4,
            DeprecatedVectorStoresDeprecatedCreateSearchRuleCommand command5,
            DeprecatedVectorStoresDeprecatedDeleteSearchRuleCommand command6,
            DeprecatedVectorStoresDeprecatedDeleteSpecificSearchRuleCommand command7,
            DeprecatedVectorStoresDeprecatedRetrieveSearchRuleCommand command8,
            DeprecatedVectorStoresDeprecatedUpdateSearchRuleCommand command9,
            DeprecatedVectorStoresListVectorStoreFilesCommand command10,
            DeprecatedVectorStoresListVectorStoreFilesWithMetadataFilterCommand command11,
            DeprecatedVectorStoresListVectorStoresCommand command12,
            DeprecatedVectorStoresRetrieveVectorStoreCommand command13,
            DeprecatedVectorStoresRetrieveVectorStoreFileCommand command14,
            DeprecatedVectorStoresSearchVectorStoreChunksCommand command15,
            DeprecatedVectorStoresSearchVectorStoreFilesCommand command16,
            DeprecatedVectorStoresUpdateVectorStoreCommand command17)
            : base(
                name: "deprecatedvectorstore")
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
        }
    }
}