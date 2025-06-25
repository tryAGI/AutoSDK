//HintName: G.Commands.SpeechToSpeechCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpeechToSpeechCommand : global::System.CommandLine.Command
    {
        public SpeechToSpeechCommand(
            CreateSpeechToSpeechByVoiceIdCommand command0,
            CreateSpeechToSpeechByVoiceIdStreamCommand command1)
            : base(
                name: "speechtospeech")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}