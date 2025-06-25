//HintName: G.Commands.DeleteModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteModelsCommand : global::System.CommandLine.Command
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

        public DeleteModelsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete a model

Model deletion has some restrictions:

- You can only delete models you own.
- You can only delete private models.
- You can only delete models that have no versions associated with them. Currently you'll need to [delete the model's versions](#models.versions.delete) before you can delete the model itself.

Example cURL request:

```command
curl -s -X DELETE \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/models/replicate/hello-world
```

The response will be an empty 204, indicating the model has been deleted.")
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
            await _client.DeleteModelsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}