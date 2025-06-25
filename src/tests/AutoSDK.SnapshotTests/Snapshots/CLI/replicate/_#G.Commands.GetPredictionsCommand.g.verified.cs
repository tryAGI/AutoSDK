//HintName: G.Commands.GetPredictionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetPredictionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PredictionId { get; } = new(
            name: "predictionId")
        {
            Description = @"The ID of the prediction to get.",
        };

        public GetPredictionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get the current state of a prediction.

Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu
```

The response will be the prediction object:

```json
{
  ""id"": ""gm3qorzdhgbfurvjtvhg6dckhu"",
  ""model"": ""replicate/hello-world"",
  ""version"": ""5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa"",
  ""input"": {
    ""text"": ""Alice""
  },
  ""logs"": """",
  ""output"": ""hello Alice"",
  ""error"": null,
  ""status"": ""succeeded"",
  ""created_at"": ""2023-09-08T16:19:34.765994Z"",
  ""data_removed"": false,
  ""started_at"": ""2023-09-08T16:19:34.779176Z"",
  ""completed_at"": ""2023-09-08T16:19:34.791859Z"",
  ""metrics"": {
    ""predict_time"": 0.012683
  },
  ""urls"": {
    ""cancel"": ""https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel"",
    ""get"": ""https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu""
  }
}
```

`status` will be one of:

- `starting`: the prediction is starting up. If this status lasts longer than a few seconds, then it's typically because a new worker is being started to run the prediction.
- `processing`: the `predict()` method of the model is currently running.
- `succeeded`: the prediction completed successfully.
- `failed`: the prediction encountered an error during processing.
- `canceled`: the prediction was canceled by its creator.

In the case of success, `output` will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You'll need to pass the `Authorization` header to request them.

In the case of failure, `error` will contain the error encountered during the prediction.

Terminated predictions (with a status of `succeeded`, `failed`, or `canceled`) will include a `metrics` object with a `predict_time` property showing the amount of CPU or GPU time, in seconds, that the prediction used while running. It won't include time waiting for the prediction to start.

All input parameters, output values, and logs are automatically removed after an hour, by default, for predictions created through the API.

You must save a copy of any data or files in the output if you'd like to continue using them. The `output` key will still be present, but it's value will be `null` after the output has been removed.

Output files are served by `replicate.delivery` and its subdomains. If you use an allow list of external domains for your assets, add `replicate.delivery` and `*.replicate.delivery` to it.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(PredictionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var predictionId = parseResult.GetRequiredValue(PredictionId);

            Validate(
                parseResult: parseResult,
                predictionId: predictionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GetPredictionsAsync(
                predictionId: predictionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}