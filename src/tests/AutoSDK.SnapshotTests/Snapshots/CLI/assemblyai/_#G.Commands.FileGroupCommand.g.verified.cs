//HintName: G.Commands.FileGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FileGroupCommand : global::System.CommandLine.Command
    {
        public FileGroupCommand(
            FilesUploadCommand command0)
            : base(
                name: "file")
        {
            Subcommands.Add(command0);
        }
    }
}