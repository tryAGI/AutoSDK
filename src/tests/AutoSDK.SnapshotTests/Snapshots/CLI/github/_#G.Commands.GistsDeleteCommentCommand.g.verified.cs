//HintName: G.Commands.GistsDeleteCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GistsDeleteCommentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string gistId,
            long commentId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GistId { get; } = new(
            name: "gistId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<long> CommentId { get; } = new(
            name: "commentId")
        {
            Description = "",
        };

        public GistsDeleteCommentCommand(G.IApi client) : base(
            name: "gists",
            description: @"")
        {
            _client = client;

            Arguments.Add(GistId);
            Arguments.Add(CommentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var gistId = parseResult.GetRequiredValue(GistId);
            var commentId = parseResult.GetRequiredValue(CommentId);

            Validate(
                parseResult: parseResult,
                gistId: gistId,
                commentId: commentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Gists.GistsDeleteCommentAsync(
                gistId: gistId,
                commentId: commentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}