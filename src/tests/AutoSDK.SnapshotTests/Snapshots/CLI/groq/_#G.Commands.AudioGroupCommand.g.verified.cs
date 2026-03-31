//HintName: G.Commands.AudioGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AudioGroupCommand : global::System.CommandLine.Command
    {
        public AudioGroupCommand(
            AudioCreateSpeechCommand command0,
            AudioCreateTranscriptionCommand command1,
            AudioCreateTranslationCommand command2)
            : base(
                name: "audio")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}