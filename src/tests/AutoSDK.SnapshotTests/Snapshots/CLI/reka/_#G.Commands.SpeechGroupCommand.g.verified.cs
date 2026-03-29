//HintName: G.Commands.SpeechGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpeechGroupCommand : global::System.CommandLine.Command
    {
        public SpeechGroupCommand(
            SpeechTranscribeOrTranslateCommand command0)
            : base(
                name: "speech")
        {
            Subcommands.Add(command0);
        }
    }
}