//HintName: G.Commands.CreatePredictionsModelsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePredictionsModelsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelOwner,
            string modelName,
            string? prefer,
            object input,
            bool? stream,
            string? webhook,
            global::System.Collections.Generic.IList<global::G.PredictionRequestWebhookEventsFilterItem>? webhookEventsFilter,
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

        private global::System.CommandLine.Argument<object> Input { get; } = new(
            name: "input")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Prefer { get; } = new(
            name: "prefer")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Webhook { get; } = new(
            name: "webhook")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.PredictionRequestWebhookEventsFilterItem>?> WebhookEventsFilter { get; } = new(
            name: "webhookEventsFilter")
        {
            Description = @"",
        };
        public CreatePredictionsModelsCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a prediction for the deployment and inputs you provide.

Example cURL request:

```console
curl -s -X POST -H 'Prefer: wait' \
  -d '{""input"": {""prompt"": ""Write a short poem about the weather.""}}' \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  -H 'Content-Type: application/json' \
  https://api.replicate.com/v1/models/meta/meta-llama-3-70b-instruct/predictions
```

The request will wait up to 60 seconds for the model to run. If this time is exceeded the prediction will be returned in a `""starting""` state and need to be retrieved using the `predictions.get` endpiont.

For a complete overview of the `deployments.predictions.create` API check out our documentation on [creating a prediction](https://replicate.com/docs/topics/predictions/create-a-prediction) which covers a variety of use cases.")
        {
            _client = client;

            Arguments.Add(ModelOwner);
            Arguments.Add(ModelName);
            Arguments.Add(Input);
            Options.Add(Prefer);
            Options.Add(Stream);
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
            var prefer = parseResult.GetRequiredValue(Prefer);
            var input = parseResult.GetRequiredValue(Input);
            var stream = parseResult.GetRequiredValue(Stream);
            var webhook = parseResult.GetRequiredValue(Webhook);
            var webhookEventsFilter = parseResult.GetRequiredValue(WebhookEventsFilter);

            Validate(
                parseResult: parseResult,
                modelOwner: modelOwner,
                modelName: modelName,
                prefer: prefer,
                input: input,
                stream: stream,
                webhook: webhook,
                webhookEventsFilter: webhookEventsFilter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CreatePredictionsModelsAsync(
                modelOwner: modelOwner,
                modelName: modelName,
                prefer: prefer,
                input: input,
                stream: stream,
                webhook: webhook,
                webhookEventsFilter: webhookEventsFilter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}