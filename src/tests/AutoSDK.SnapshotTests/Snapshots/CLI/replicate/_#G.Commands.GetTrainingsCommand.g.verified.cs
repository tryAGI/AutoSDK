//HintName: G.Commands.GetTrainingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetTrainingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string trainingId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TrainingId { get; } = new(
            name: "trainingId")
        {
            Description = @"The ID of the training to get.",
        };

        public GetTrainingsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get the current state of a training.

Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga
```

The response will be the training object:

```json
{
  ""completed_at"": ""2023-09-08T16:41:19.826523Z"",
  ""created_at"": ""2023-09-08T16:32:57.018467Z"",
  ""error"": null,
  ""id"": ""zz4ibbonubfz7carwiefibzgga"",
  ""input"": {
    ""input_images"": ""https://example.com/my-input-images.zip""
  },
  ""logs"": ""..."",
  ""metrics"": {
    ""predict_time"": 502.713876
  },
  ""output"": {
    ""version"": ""..."",
    ""weights"": ""...""
  },
  ""started_at"": ""2023-09-08T16:32:57.112647Z"",
  ""status"": ""succeeded"",
  ""urls"": {
    ""get"": ""https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga"",
    ""cancel"": ""https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel""
  },
  ""model"": ""stability-ai/sdxl"",
  ""version"": ""da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf"",
}
```

`status` will be one of:

- `starting`: the training is starting up. If this status lasts longer than a few seconds, then it's typically because a new worker is being started to run the training.
- `processing`: the `train()` method of the model is currently running.
- `succeeded`: the training completed successfully.
- `failed`: the training encountered an error during processing.
- `canceled`: the training was canceled by its creator.

In the case of success, `output` will be an object containing the output of the model. Any files will be represented as HTTPS URLs. You'll need to pass the `Authorization` header to request them.

In the case of failure, `error` will contain the error encountered during the training.

Terminated trainings (with a status of `succeeded`, `failed`, or `canceled`) will include a `metrics` object with a `predict_time` property showing the amount of CPU or GPU time, in seconds, that the training used while running. It won't include time waiting for the training to start.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TrainingId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var trainingId = parseResult.GetRequiredValue(TrainingId);

            Validate(
                parseResult: parseResult,
                trainingId: trainingId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.GetTrainingsAsync(
                trainingId: trainingId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}