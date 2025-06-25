//HintName: G.Commands.TranscriptCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranscriptCommand : global::System.CommandLine.Command
    {
        public TranscriptCommand(
            UploadFileCommand command0,
            CreateTranscriptCommand command1,
            ListTranscriptsCommand command2,
            GetTranscriptCommand command3,
            DeleteTranscriptCommand command4,
            GetSubtitlesCommand command5,
            GetTranscriptSentencesCommand command6,
            GetTranscriptParagraphsCommand command7,
            WordSearchCommand command8,
            GetRedactedAudioCommand command9)
            : base(
                name: "transcript")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
        }
    }
}