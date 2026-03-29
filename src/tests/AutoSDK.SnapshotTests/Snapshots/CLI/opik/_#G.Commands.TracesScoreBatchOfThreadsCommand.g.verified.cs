//HintName: G.Commands.TracesScoreBatchOfThreadsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesScoreBatchOfThreadsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreBatchItemThread> scores,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.FeedbackScoreBatchItemThread>> Scores { get; } = new(
            name: "scores")
        {
            Description = @"",
        };



        public TracesScoreBatchOfThreadsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "score",
            description: @"Batch feedback scoring for threads")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Scores);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var scores = parseResult.GetRequiredValue(Scores);

            Validate(
                parseResult: parseResult,
                scores: scores,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.ScoreBatchOfThreadsAsync(
                scores: scores,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}