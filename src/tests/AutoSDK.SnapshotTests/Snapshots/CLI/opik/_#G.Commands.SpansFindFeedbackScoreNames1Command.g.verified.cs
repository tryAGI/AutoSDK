//HintName: G.Commands.SpansFindFeedbackScoreNames1Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansFindFeedbackScoreNames1Command : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid? projectId,
            global::G.FindFeedbackScoreNames1Type? type,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FeedbackScoreNamesPublic response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.FindFeedbackScoreNames1Type?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };


        public SpansFindFeedbackScoreNames1Command(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find Feedback Score names")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ProjectId);
            Options.Add(Type);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var type = parseResult.GetRequiredValue(Type);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                type: type,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Spans.FindFeedbackScoreNames1Async(
                projectId: projectId,
                type: type,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}