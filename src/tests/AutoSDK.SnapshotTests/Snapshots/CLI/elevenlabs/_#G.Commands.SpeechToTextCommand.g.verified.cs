//HintName: G.Commands.SpeechToTextCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpeechToTextCommand : global::System.CommandLine.Command
    {
        public SpeechToTextCommand(
            CreateSpeechToTextCommand command0)
            : base(
                name: "speechtotext")
        {
            Subcommands.Add(command0);
        }
    }
}