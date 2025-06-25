//HintName: G.Commands.ListCollectionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListCollectionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        public ListCollectionsCommand(G.IApi client) : base(
            name: "list",
            description: @"Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/collections
```

The response will be a paginated JSON list of collection objects:

```json
{
  ""next"": ""null"",
  ""previous"": null,
  ""results"": [
    {
      ""name"": ""Super resolution"",
      ""slug"": ""super-resolution"",
      ""description"": ""Upscaling models that create high-quality images from low-quality images.""
    }
  ]
}
```
")
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
            await _client.ListCollectionsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}