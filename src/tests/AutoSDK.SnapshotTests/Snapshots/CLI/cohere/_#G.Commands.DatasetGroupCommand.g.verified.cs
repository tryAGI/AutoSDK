//HintName: G.Commands.DatasetGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetGroupCommand : global::System.CommandLine.Command
    {
        public DatasetGroupCommand(
            CreateDatasetCommand command0,
            ListDatasetsCommand command1,
            GetDatasetUsageCommand command2,
            GetDatasetCommand command3,
            DeleteDatasetCommand command4)
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