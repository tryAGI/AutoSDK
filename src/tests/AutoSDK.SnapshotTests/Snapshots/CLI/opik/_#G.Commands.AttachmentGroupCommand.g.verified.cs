//HintName: G.Commands.AttachmentGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AttachmentGroupCommand : global::System.CommandLine.Command
    {
        public AttachmentGroupCommand(
            AttachmentsAttachmentListCommand command0,
            AttachmentsCompleteMultiPartUploadCommand command1,
            AttachmentsDeleteAttachmentsCommand command2,
            AttachmentsDownloadAttachmentCommand command3,
            AttachmentsStartMultiPartUploadCommand command4,
            AttachmentsUploadAttachmentCommand command5)
            : base(
                name: "attachment")
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