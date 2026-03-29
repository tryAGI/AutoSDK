//HintName: G.Commands.SpansGetSpanCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansGetSpanCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid commentId,
            global::System.Guid spanId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Comment response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CommentId { get; } = new(
            name: "commentId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> SpanId { get; } = new(
            name: "spanId")
        {
            Description = @"",
        };



        public SpansGetSpanCommentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get span comment")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CommentId);
            Arguments.Add(SpanId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var commentId = parseResult.GetRequiredValue(CommentId);
            var spanId = parseResult.GetRequiredValue(SpanId);

            Validate(
                parseResult: parseResult,
                commentId: commentId,
                spanId: spanId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Spans.GetSpanCommentAsync(
                commentId: commentId,
                spanId: spanId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}