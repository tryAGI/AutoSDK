//HintName: G.Commands.FileGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FileGroupCommand : global::System.CommandLine.Command
    {
        public FileGroupCommand(
            FilesAbortMultipartUploadCommand command0,
            FilesCompleteMultipartUploadCommand command1,
            FilesCreateFileCommand command2,
            FilesCreateMultipartUploadCommand command3,
            FilesDeleteFileCommand command4,
            FilesDownloadFileCommand command5,
            FilesGetMultipartUploadCommand command6,
            FilesListFilesCommand command7,
            FilesListMultipartUploadsCommand command8,
            FilesRetrieveFileCommand command9,
            FilesUpdateFileCommand command10)
            : base(
                name: "file")
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
        }
    }
}