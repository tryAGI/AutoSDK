//HintName: G.Commands.TextToVoiceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TextToVoiceCommand : global::System.CommandLine.Command
    {
        public TextToVoiceCommand(
            CreateTextToVoiceCreatePreviewsCommand command0,
            CreateTextToVoiceCreateVoiceFromPreviewCommand command1)
            : base(
                name: "texttovoice")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}