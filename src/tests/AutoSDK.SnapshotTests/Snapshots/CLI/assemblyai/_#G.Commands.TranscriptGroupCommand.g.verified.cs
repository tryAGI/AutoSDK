//HintName: G.Commands.TranscriptGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranscriptGroupCommand : global::System.CommandLine.Command
    {
        public TranscriptGroupCommand(
            TranscriptsDeleteCommand command0,
            TranscriptsGetCommand command1,
            TranscriptsGetParagraphsCommand command2,
            TranscriptsGetRedactedAudioCommand command3,
            TranscriptsGetSentencesCommand command4,
            TranscriptsGetSubtitlesCommand command5,
            TranscriptsListCommand command6,
            TranscriptsSubmitCommand command7,
            TranscriptsWordSearchCommand command8)
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
        }
    }
}