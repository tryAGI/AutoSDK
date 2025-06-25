//HintName: G.Commands.GetModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelOwner,
            string modelName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelOwner { get; } = new(
            name: "modelOwner")
        {
            Description = @"The name of the user or organization that owns the model.",
        };

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = @"The name of the model.",
        };

        public GetModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/models/replicate/hello-world
```

The response will be a model object in the following format:

```json
{
  ""url"": ""https://replicate.com/replicate/hello-world"",
  ""owner"": ""replicate"",
  ""name"": ""hello-world"",
  ""description"": ""A tiny model that says hello"",
  ""visibility"": ""public"",
  ""github_url"": ""https://github.com/replicate/cog-examples"",
  ""paper_url"": null,
  ""license_url"": null,
  ""run_count"": 5681081,
  ""cover_image_url"": ""..."",
  ""default_example"": {...},
  ""latest_version"": {...},
}
```

The `cover_image_url` string is an HTTPS URL for an image file. This can be:

- An image uploaded by the model author.
- The output file of the example prediction, if the model author has not set a cover image.
- The input file of the example prediction, if the model author has not set a cover image and the example prediction has no output file.
- A generic fallback image.

The `default_example` object is a [prediction](#predictions.get) created with this model.

The `latest_version` object is the model's most recently pushed [version](#models.versions.get).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelOwner);
            Arguments.Add(ModelName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelOwner = parseResult.GetRequiredValue(ModelOwner);
            var modelName = parseResult.GetRequiredValue(ModelName);

            Validate(
                parseResult: parseResult,
                modelOwner: modelOwner,
                modelName: modelName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GetModelsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}