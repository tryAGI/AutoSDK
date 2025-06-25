//HintName: G.Commands.TextToSpeechCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TextToSpeechCommand : global::System.CommandLine.Command
    {
        public TextToSpeechCommand(
            CreateTextToSpeechByVoiceIdCommand command0,
            CreateTextToSpeechByVoiceIdWithTimestampsCommand command1,
            CreateTextToSpeechByVoiceIdStreamCommand command2,
            CreateTextToSpeechByVoiceIdStreamWithTimestampsCommand command3)
            : base(
                name: "texttospeech")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
        }
    }
}