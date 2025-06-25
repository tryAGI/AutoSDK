//HintName: G.Commands.TalkingPhotoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TalkingPhotoCommand : global::System.CommandLine.Command
    {
        public TalkingPhotoCommand(
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