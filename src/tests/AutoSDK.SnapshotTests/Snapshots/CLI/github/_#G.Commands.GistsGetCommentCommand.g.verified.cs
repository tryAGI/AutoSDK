//HintName: G.Commands.GistsGetCommentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GistsGetCommentCommand : global::System.CommandLine.Command
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
            global::G.GistComment response,
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

        public GistsGetCommentCommand(G.IApi client) : base(
            name: "gists",
            description: @"Gets a comment on a gist.

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github.raw+json`**: Returns the raw markdown. This is the default if you do not pass any specific media type.
- **`application/vnd.github.base64+json`**: Returns the base64-encoded contents. This can be useful if your gist contains any invalid UTF-8 sequences.")
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
            var response = await _client.Gists.GistsGetCommentAsync(
                gistId: gistId,
                commentId: commentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}