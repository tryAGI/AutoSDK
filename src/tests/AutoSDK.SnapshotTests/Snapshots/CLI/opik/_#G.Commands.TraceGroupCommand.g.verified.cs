//HintName: G.Commands.TraceGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TraceGroupCommand : global::System.CommandLine.Command
    {
        public TraceGroupCommand(
            TracesAddThreadCommentCommand command0,
            TracesAddTraceCommentCommand command1,
            TracesAddTraceFeedbackScoreCommand command2,
            TracesBatchUpdateThreadsCommand command3,
            TracesBatchUpdateTracesCommand command4,
            TracesCloseTraceThreadCommand command5,
            TracesCreateTraceCommand command6,
            TracesCreateTracesCommand command7,
            TracesDeleteThreadCommentsCommand command8,
            TracesDeleteThreadFeedbackScoresCommand command9,
            TracesDeleteTraceByIdCommand command10,
            TracesDeleteTraceCommentsCommand command11,
            TracesDeleteTraceFeedbackScoreCommand command12,
            TracesDeleteTraceThreadsCommand command13,
            TracesDeleteTracesCommand command14,
            TracesFindFeedbackScoreNames2Command command15,
            TracesFindTraceThreadsFeedbackScoreNamesCommand command16,
            TracesGetThreadCommentCommand command17,
            TracesGetTraceByIdCommand command18,
            TracesGetTraceCommentCommand command19,
            TracesGetTraceStatsCommand command20,
            TracesGetTraceThreadCommand command21,
            TracesGetTraceThreadStatsCommand command22,
            TracesGetTraceThreadsCommand command23,
            TracesGetTracesByProjectCommand command24,
            TracesOpenTraceThreadCommand command25,
            TracesScoreBatchOfThreadsCommand command26,
            TracesScoreBatchOfTracesCommand command27,
            TracesSearchTraceThreadsCommand command28,
            TracesSearchTracesCommand command29,
            TracesUpdateThreadCommand command30,
            TracesUpdateThreadCommentCommand command31,
            TracesUpdateTraceCommand command32,
            TracesUpdateTraceCommentCommand command33)
            : base(
                name: "trace")
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
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
            Subcommands.Add(command22);
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
            Subcommands.Add(command27);
            Subcommands.Add(command28);
            Subcommands.Add(command29);
            Subcommands.Add(command30);
            Subcommands.Add(command31);
            Subcommands.Add(command32);
            Subcommands.Add(command33);
        }
    }
}