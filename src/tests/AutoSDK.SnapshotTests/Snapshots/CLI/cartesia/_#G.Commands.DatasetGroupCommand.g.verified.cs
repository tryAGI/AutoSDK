//HintName: G.Commands.DatasetGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetGroupCommand : global::System.CommandLine.Command
    {
        public DatasetGroupCommand(
            DatasetsDatasetsCreateCommand command0,
            DatasetsDatasetsDeleteCommand command1,
            DatasetsDatasetsDeleteFileCommand command2,
            DatasetsDatasetsGetCommand command3,
            DatasetsDatasetsListCommand command4,
            DatasetsDatasetsListFilesCommand command5,
            DatasetsDatasetsUpdateCommand command6,
            DatasetsDatasetsUploadFileCommand command7)
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
        }
    }
}