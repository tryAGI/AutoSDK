//HintName: G.Commands.AudioCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AudioCommand : global::System.CommandLine.Command
    {
        public AudioCommand(
            CreateSpeechCommand command0,
            CreateTranscriptionCommand command1,
            CreateTranslationCommand command2)
            : base(
                name: "audio")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}