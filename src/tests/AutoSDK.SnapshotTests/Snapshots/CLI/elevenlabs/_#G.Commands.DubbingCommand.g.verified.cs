//HintName: G.Commands.DubbingCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DubbingCommand : global::System.CommandLine.Command
    {
        public DubbingCommand(
            GetDubbingResourceByDubbingIdCommand command0,
            CreateDubbingResourceByDubbingIdLanguageCommand command1,
            CreateDubbingResourceByDubbingIdSpeakerBySpeakerIdSegmentCommand command2,
            EditDubbingResourceByDubbingIdSegmentBySegmentIdByLanguageCommand command3,
            DeleteDubbingResourceByDubbingIdSegmentBySegmentIdCommand command4,
            CreateDubbingResourceByDubbingIdTranscribeCommand command5,
            CreateDubbingResourceByDubbingIdTranslateCommand command6,
            CreateDubbingResourceByDubbingIdDubCommand command7,
            EditDubbingResourceByDubbingIdSpeakerBySpeakerIdCommand command8,
            GetDubbingResourceByDubbingIdSpeakerBySpeakerIdSimilarVoicesCommand command9,
            CreateDubbingResourceByDubbingIdRenderByLanguageCommand command10,
            CreateDubbingCommand command11,
            GetDubbingByDubbingIdCommand command12,
            DeleteDubbingByDubbingIdCommand command13,
            GetDubbingByDubbingIdAudioByLanguageCodeCommand command14,
            GetDubbingByDubbingIdTranscriptByLanguageCodeCommand command15)
            : base(
                name: "dubbing")
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
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
        }
    }
}