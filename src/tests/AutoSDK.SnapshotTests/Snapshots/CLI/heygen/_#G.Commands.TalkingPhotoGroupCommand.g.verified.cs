//HintName: G.Commands.TalkingPhotoGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TalkingPhotoGroupCommand : global::System.CommandLine.Command
    {
        public TalkingPhotoGroupCommand(
            V1TalkingPhotoListCommand command0,
            V1TalkingPhotoUploadCommand command1,
            V2TalkingPhotoIdDeleteCommand command2)
            : base(
                name: "talkingphoto")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}