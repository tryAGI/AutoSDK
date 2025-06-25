//HintName: G.Commands.GetVersionsModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetVersionsModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelOwner,
            string modelName,
            string versionId,
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

        private global::System.CommandLine.Argument<string> VersionId { get; } = new(
            name: "versionId")
        {
            Description = @"The ID of the version.",
        };

        public GetVersionsModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa
```

The response will be the version object:

```json
{
  ""id"": ""5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa"",
  ""created_at"": ""2022-04-26T19:29:04.418669Z"",
  ""cog_version"": ""0.3.0"",
  ""openapi_schema"": {...}
}
```

Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the `openapi_schema` property.

The `openapi_schema.components.schemas.Input` property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:

```json
{
  ""type"": ""object"",
  ""title"": ""Input"",
  ""required"": [
    ""text""
  ],
  ""properties"": {
    ""text"": {
      ""x-order"": 0,
      ""type"": ""string"",
      ""title"": ""Text"",
      ""description"": ""Text to prefix with 'hello '""
    }
  }
}
```

The `openapi_schema.components.schemas.Output` property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:

```json
{
  ""type"": ""string"",
  ""title"": ""Output""
}
```

For more details, see the docs on [Cog's supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types)")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelOwner);
            Arguments.Add(ModelName);
            Arguments.Add(VersionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelOwner = parseResult.GetRequiredValue(ModelOwner);
            var modelName = parseResult.GetRequiredValue(ModelName);
            var versionId = parseResult.GetRequiredValue(VersionId);

            Validate(
                parseResult: parseResult,
                modelOwner: modelOwner,
                modelName: modelName,
                versionId: versionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GetVersionsModelsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                versionId: versionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}