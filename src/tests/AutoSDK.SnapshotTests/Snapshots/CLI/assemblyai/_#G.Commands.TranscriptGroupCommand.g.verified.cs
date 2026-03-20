//HintName: G.Commands.TranscriptGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranscriptGroupCommand : global::System.CommandLine.Command
    {
        public TranscriptGroupCommand(
            TranscriptsSubmitCommand command0,
            TranscriptsListCommand command1,
            TranscriptsGetCommand command2,
            TranscriptsDeleteCommand command3,
            TranscriptsGetSubtitlesCommand command4,
            TranscriptsGetSentencesCommand command5,
            TranscriptsGetParagraphsCommand command6,
            TranscriptsWordSearchCommand command7,
            TranscriptsGetRedactedAudioCommand command8)
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