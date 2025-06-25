//HintName: G.Commands.UploadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UploadCommand : global::System.CommandLine.Command
    {
        public UploadCommand(
            CreateUploadCommand command0,
            CancelUploadCommand command1,
            CompleteUploadCommand command2,
            AddUploadPartCommand command3)
            : base(
                name: "upload")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}