//HintName: G.Commands.DeleteVersionsModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteVersionsModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> VersionId { get; } = new(
            name: "versionId")
        {
            Description = @"",
        };

        public DeleteVersionsModelsCommand(G.IApi client) : base(
            name: "delete",
            description: @"Delete a model version and all associated predictions, including all output files.

Model version deletion has some restrictions:

- You can only delete versions from models you own.
- You can only delete versions from private models.
- You cannot delete a version if someone other than you has run predictions with it.
- You cannot delete a version if it is being used as the base model for a fine tune/training.
- You cannot delete a version if it has an associated deployment.
- You cannot delete a version if another model version is overridden to use it.

Example cURL request:

```command
curl -s -X DELETE \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa
```

The response will be an empty 202, indicating the deletion request has been accepted. It might take a few minutes to be processed.")
        {
            _client = client;

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
            await _client.DeleteVersionsModelsAsync(
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