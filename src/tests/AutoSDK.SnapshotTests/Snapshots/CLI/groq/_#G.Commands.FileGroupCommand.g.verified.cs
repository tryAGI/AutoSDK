//HintName: G.Commands.FileGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FileGroupCommand : global::System.CommandLine.Command
    {
        public FileGroupCommand(
            FilesDeleteFileCommand command0,
            FilesDownloadFileCommand command1,
            FilesListFilesCommand command2,
            FilesRetrieveFileCommand command3,
            FilesUploadFileCommand command4)
            : base(
                name: "file")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
        }
    }
}