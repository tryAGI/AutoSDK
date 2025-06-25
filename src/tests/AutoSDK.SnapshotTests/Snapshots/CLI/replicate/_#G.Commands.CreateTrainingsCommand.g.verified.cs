//HintName: G.Commands.CreateTrainingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateTrainingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelOwner,
            string modelName,
            string versionId,
            string destination,
            object input,
            string? webhook,
            global::System.Collections.Generic.IList<global::G.TrainingRequestWebhookEventsFilterItem>? webhookEventsFilter,
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

        private global::System.CommandLine.Argument<string> Destination { get; } = new(
            name: "destination")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<object> Input { get; } = new(
            name: "input")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Webhook { get; } = new(
            name: "webhook")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.TrainingRequestWebhookEventsFilterItem>?> WebhookEventsFilter { get; } = new(
            name: "webhookEventsFilter")
        {
            Description = @"",
        };
        public CreateTrainingsCommand(G.IApi client) : base(
            name: "create",
            description: @"Start a new training of the model version you specify.

Example request body:

```json
{
  ""destination"": ""{new_owner}/{new_name}"",
  ""input"": {
    ""train_data"": ""https://example.com/my-input-images.zip"",
  },
  ""webhook"": ""https://example.com/my-webhook"",
}
```

Example cURL request:

```console
curl -s -X POST \
  -d '{""destination"": ""{new_owner}/{new_name}"", ""input"": {""input_images"": ""https://example.com/my-input-images.zip""}}' \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  -H 'Content-Type: application/json' \
  https://api.replicate.com/v1/models/stability-ai/sdxl/versions/da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf/trainings
```

The response will be the training object:

```json
{
  ""id"": ""zz4ibbonubfz7carwiefibzgga"",
  ""model"": ""stability-ai/sdxl"",
  ""version"": ""da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf"",
  ""input"": {
    ""input_images"": ""https://example.com/my-input-images.zip""
  },
  ""logs"": """",
  ""error"": null,
  ""status"": ""starting"",
  ""created_at"": ""2023-09-08T16:32:56.990893084Z"",
  ""urls"": {
    ""cancel"": ""https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga/cancel"",
    ""get"": ""https://api.replicate.com/v1/predictions/zz4ibbonubfz7carwiefibzgga""
  }
}
```

As models can take several minutes or more to train, the result will not be available immediately. To get the final result of the training you should either provide a `webhook` HTTPS URL for us to call when the results are ready, or poll the [get a training](#trainings.get) endpoint until it has finished.

When a training completes, it creates a new [version](https://replicate.com/docs/how-does-replicate-work#terminology) of the model at the specified destination.

To find some models to train on, check out the [trainable language models collection](https://replicate.com/collections/trainable-language-models).")
        {
            _client = client;

            Arguments.Add(ModelOwner);
            Arguments.Add(ModelName);
            Arguments.Add(VersionId);
            Arguments.Add(Destination);
            Arguments.Add(Input);
            Options.Add(Webhook);
            Options.Add(WebhookEventsFilter);

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
            var destination = parseResult.GetRequiredValue(Destination);
            var input = parseResult.GetRequiredValue(Input);
            var webhook = parseResult.GetRequiredValue(Webhook);
            var webhookEventsFilter = parseResult.GetRequiredValue(WebhookEventsFilter);

            Validate(
                parseResult: parseResult,
                modelOwner: modelOwner,
                modelName: modelName,
                versionId: versionId,
                destination: destination,
                input: input,
                webhook: webhook,
                webhookEventsFilter: webhookEventsFilter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CreateTrainingsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                versionId: versionId,
                destination: destination,
                input: input,
                webhook: webhook,
                webhookEventsFilter: webhookEventsFilter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}