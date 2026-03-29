//HintName: G.Commands.FileApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FileApiGroupCommand : global::System.CommandLine.Command
    {
        public FileApiGroupCommand(
            FileApiGatewayDeleteFileCommand command0,
            FileApiGatewayDownloadFileCommand command1,
            FileApiGatewayGetFileCommand command2,
            FileApiGatewayGetFilesCommand command3,
            FileApiGatewayRetryFailedFilesCommand command4,
            FileApiGatewayUploadFileCommand command5)
            : base(
                name: "fileapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}