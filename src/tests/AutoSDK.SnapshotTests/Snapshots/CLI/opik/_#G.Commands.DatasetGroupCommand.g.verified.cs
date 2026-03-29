//HintName: G.Commands.DatasetGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetGroupCommand : global::System.CommandLine.Command
    {
        public DatasetGroupCommand(
            DatasetsApplyDatasetItemChangesCommand command0,
            DatasetsBatchUpdateDatasetItemsCommand command1,
            DatasetsCompareDatasetVersionsCommand command2,
            DatasetsCreateDatasetCommand command3,
            DatasetsCreateDatasetItemsFromCsvCommand command4,
            DatasetsCreateDatasetItemsFromSpansCommand command5,
            DatasetsCreateDatasetItemsFromTracesCommand command6,
            DatasetsCreateOrUpdateDatasetItemsCommand command7,
            DatasetsCreateVersionTagCommand command8,
            DatasetsDeleteDatasetCommand command9,
            DatasetsDeleteDatasetByNameCommand command10,
            DatasetsDeleteDatasetItemsCommand command11,
            DatasetsDeleteDatasetsBatchCommand command12,
            DatasetsDeleteVersionTagCommand command13,
            DatasetsDownloadDatasetExportCommand command14,
            DatasetsExpandDatasetCommand command15,
            DatasetsFindDatasetItemsWithExperimentItemsCommand command16,
            DatasetsFindDatasetsCommand command17,
            DatasetsGetDatasetByIdCommand command18,
            DatasetsGetDatasetByIdentifierCommand command19,
            DatasetsGetDatasetExperimentItemsStatsCommand command20,
            DatasetsGetDatasetExportJobCommand command21,
            DatasetsGetDatasetExportJobsCommand command22,
            DatasetsGetDatasetItemByIdCommand command23,
            DatasetsGetDatasetItemsCommand command24,
            DatasetsGetDatasetItemsOutputColumnsCommand command25,
            DatasetsListDatasetVersionsCommand command26,
            DatasetsMarkDatasetExportJobViewedCommand command27,
            DatasetsPatchDatasetItemCommand command28,
            DatasetsRestoreDatasetVersionCommand command29,
            DatasetsRetrieveDatasetVersionCommand command30,
            DatasetsStartDatasetExportCommand command31,
            DatasetsStreamDatasetItemsCommand command32,
            DatasetsUpdateDatasetCommand command33,
            DatasetsUpdateDatasetVersionCommand command34)
            : base(
                name: "dataset")
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
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
            Subcommands.Add(command27);
            Subcommands.Add(command28);
            Subcommands.Add(command29);
            Subcommands.Add(command30);
            Subcommands.Add(command31);
            Subcommands.Add(command32);
            Subcommands.Add(command33);
            Subcommands.Add(command34);
        }
    }
}