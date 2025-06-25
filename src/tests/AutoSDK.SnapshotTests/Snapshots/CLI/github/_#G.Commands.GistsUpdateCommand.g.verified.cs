//HintName: G.Commands.GistsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GistsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string gistId,
            string? description,
            global::System.Collections.Generic.Dictionary<string, global::G.GistsUpdateRequestFiles2?>? files,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GistSimple response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GistId { get; } = new(
            name: "gistId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, global::G.GistsUpdateRequestFiles2?>?> Files { get; } = new(
            name: "files")
        {
            Description = "",
        };
        public GistsUpdateCommand(G.IApi client) : base(
            name: "gists",
            description: @"Allows you to update a gist's description and to update, delete, or rename gist files. Files
from the previous version of the gist that aren't explicitly changed during an edit
are unchanged.

At least one of `description` or `files` is required.

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github.raw+json`**: Returns the raw markdown. This is the default if you do not pass any specific media type.
- **`application/vnd.github.base64+json`**: Returns the base64-encoded contents. This can be useful if your gist contains any invalid UTF-8 sequences.")
        {
            _client = client;

            Arguments.Add(GistId);
            Options.Add(Description);
            Options.Add(Files);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var gistId = parseResult.GetRequiredValue(GistId);
            var description = parseResult.GetRequiredValue(Description);
            var files = parseResult.GetRequiredValue(Files);

            Validate(
                parseResult: parseResult,
                gistId: gistId,
                description: description,
                files: files,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Gists.GistsUpdateAsync(
                gistId: gistId,
                description: description,
                files: files,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}