//HintName: G.Commands.TracesUpdateThreadCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesUpdateThreadCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid commentId,
            string text,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CommentId { get; } = new(
            name: "commentId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"",
        };



        public TracesUpdateThreadCommentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update thread comment by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CommentId);
            Arguments.Add(Text);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var commentId = parseResult.GetRequiredValue(CommentId);
            var text = parseResult.GetRequiredValue(Text);

            Validate(
                parseResult: parseResult,
                commentId: commentId,
                text: text,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.UpdateThreadCommentAsync(
                commentId: commentId,
                text: text,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}