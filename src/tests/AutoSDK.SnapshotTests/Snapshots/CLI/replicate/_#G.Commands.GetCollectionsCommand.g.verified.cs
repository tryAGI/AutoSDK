//HintName: G.Commands.GetCollectionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetCollectionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string collectionSlug,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CollectionSlug { get; } = new(
            name: "collectionSlug")
        {
            Description = @"",
        };

        public GetCollectionsCommand(G.IApi client) : base(
            name: "get",
            description: @"Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/collections/super-resolution
```

The response will be a collection object with a nested list of the models in that collection:

```json
{
  ""name"": ""Super resolution"",
  ""slug"": ""super-resolution"",
  ""description"": ""Upscaling models that create high-quality images from low-quality images."",
  ""models"": [...]
}
```")
        {
            _client = client;

            Arguments.Add(CollectionSlug);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var collectionSlug = parseResult.GetRequiredValue(CollectionSlug);

            Validate(
                parseResult: parseResult,
                collectionSlug: collectionSlug,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GetCollectionsAsync(
                collectionSlug: collectionSlug,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}