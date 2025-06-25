//HintName: G.Commands.ListVersionsModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListVersionsModelsCommand : global::System.CommandLine.Command
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

        public ListVersionsModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/models/replicate/hello-world/versions
```

The response will be a JSON array of model version objects, sorted with the most recent version first:

```json
{
  ""next"": null,
  ""previous"": null,
  ""results"": [
    {
      ""id"": ""5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa"",
      ""created_at"": ""2022-04-26T19:29:04.418669Z"",
      ""cog_version"": ""0.3.0"",
      ""openapi_schema"": {...}
    }
  ]
}
```")
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
            await _client.ListVersionsModelsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}