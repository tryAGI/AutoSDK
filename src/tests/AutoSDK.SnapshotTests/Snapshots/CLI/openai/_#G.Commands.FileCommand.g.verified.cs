//HintName: G.Commands.FileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FileCommand : global::System.CommandLine.Command
    {
        public FileCommand(
            ListFilesCommand command0,
            CreateFileCommand command1,
            DeleteFileCommand command2,
            RetrieveFileCommand command3,
            DownloadFileCommand command4)
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