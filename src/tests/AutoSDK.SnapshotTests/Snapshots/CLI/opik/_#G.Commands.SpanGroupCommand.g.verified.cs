//HintName: G.Commands.SpanGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpanGroupCommand : global::System.CommandLine.Command
    {
        public SpanGroupCommand(
            SpansAddSpanCommentCommand command0,
            SpansAddSpanFeedbackScoreCommand command1,
            SpansBatchUpdateSpansCommand command2,
            SpansCreateSpanCommand command3,
            SpansCreateSpansCommand command4,
            SpansDeleteSpanByIdCommand command5,
            SpansDeleteSpanCommentsCommand command6,
            SpansDeleteSpanFeedbackScoreCommand command7,
            SpansFindFeedbackScoreNames1Command command8,
            SpansGetSpanByIdCommand command9,
            SpansGetSpanCommentCommand command10,
            SpansGetSpanStatsCommand command11,
            SpansGetSpansByProjectCommand command12,
            SpansScoreBatchOfSpansCommand command13,
            SpansSearchSpansCommand command14,
            SpansUpdateSpanCommand command15,
            SpansUpdateSpanCommentCommand command16)
            : base(
                name: "span")
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
        }
    }
}