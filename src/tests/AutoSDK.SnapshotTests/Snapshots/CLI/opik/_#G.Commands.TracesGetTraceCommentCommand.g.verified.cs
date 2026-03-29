//HintName: G.Commands.TracesGetTraceCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesGetTraceCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid commentId,
            global::System.Guid traceId,
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

        private global::System.CommandLine.Argument<global::System.Guid> TraceId { get; } = new(
            name: "traceId")
        {
            Description = @"",
        };



        public TracesGetTraceCommentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get trace comment")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CommentId);
            Arguments.Add(TraceId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var commentId = parseResult.GetRequiredValue(CommentId);
            var traceId = parseResult.GetRequiredValue(TraceId);

            Validate(
                parseResult: parseResult,
                commentId: commentId,
                traceId: traceId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Traces.GetTraceCommentAsync(
                commentId: commentId,
                traceId: traceId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}