//HintName: G.Commands.ListModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        public ListModelsCommand(G.IApi client) : base(
            name: "list",
            description: @"Get a paginated list of public models.

Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/models
```

The response will be a paginated JSON array of model objects:

```json
{
  ""next"": null,
  ""previous"": null,
  ""results"": [
    {
      ""url"": ""https://replicate.com/acme/hello-world"",
      ""owner"": ""acme"",
      ""name"": ""hello-world"",
      ""description"": ""A tiny model that says hello"",
      ""visibility"": ""public"",
      ""github_url"": ""https://github.com/replicate/cog-examples"",
      ""paper_url"": null,
      ""license_url"": null,
      ""run_count"": 5681081,
      ""cover_image_url"": ""..."",
      ""default_example"": {...},
      ""latest_version"": {...}
    }
  ]
}
```

The `cover_image_url` string is an HTTPS URL for an image file. This can be:

- An image uploaded by the model author.
- The output file of the example prediction, if the model author has not set a cover image.
- The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file.
- A generic fallback image.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.ListModelsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}