//HintName: G.Commands.UploadGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UploadGroupCommand : global::System.CommandLine.Command
    {
        public UploadGroupCommand(
            UploadsCreateUploadsCommand command0)
            : base(
                name: "upload")
        {
            Subcommands.Add(command0);
        }
    }
}