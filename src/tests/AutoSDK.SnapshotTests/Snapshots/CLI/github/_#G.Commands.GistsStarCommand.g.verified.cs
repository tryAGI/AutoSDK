//HintName: G.Commands.GistsStarCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GistsStarCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string gistId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GistId { get; } = new(
            name: "gistId")
        {
            Description = "",
        };

        public GistsStarCommand(G.IApi client) : base(
            name: "gists",
            description: @"Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see ""[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method).""")
        {
            _client = client;

            Arguments.Add(GistId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var gistId = parseResult.GetRequiredValue(GistId);

            Validate(
                parseResult: parseResult,
                gistId: gistId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Gists.GistsStarAsync(
                gistId: gistId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}