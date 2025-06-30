//HintName: G.Commands.DatasetGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetGroupCommand : global::System.CommandLine.Command
    {
        public DatasetGroupCommand(
            ListDatasetsCommand command0,
            CreateDatasetCommand command1,
            GetDatasetUsageCommand command2,
            DeleteDatasetCommand command3,
            GetDatasetCommand command4)
            : base(
                name: "dataset")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}