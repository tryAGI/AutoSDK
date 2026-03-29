//HintName: G.Commands.TracesGetThreadCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesGetThreadCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid commentId,
            global::System.Guid threadId,
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

        private global::System.CommandLine.Argument<global::System.Guid> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = @"",
        };



        public TracesGetThreadCommentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get thread comment")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CommentId);
            Arguments.Add(ThreadId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var commentId = parseResult.GetRequiredValue(CommentId);
            var threadId = parseResult.GetRequiredValue(ThreadId);

            Validate(
                parseResult: parseResult,
                commentId: commentId,
                threadId: threadId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Traces.GetThreadCommentAsync(
                commentId: commentId,
                threadId: threadId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}