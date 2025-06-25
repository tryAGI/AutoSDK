//HintName: G.Commands.ListTrainingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListTrainingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        public ListTrainingsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"Get a paginated list of trainings that you've created. This will include trainings created from the API and the website. It will return 100 records per page.

Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/trainings
```

The response will be a paginated JSON array of training objects, sorted with the most recent training first:

```json
{
  ""next"": null,
  ""previous"": null,
  ""results"": [
    {
      ""completed_at"": ""2023-09-08T16:41:19.826523Z"",
      ""created_at"": ""2023-09-08T16:32:57.018467Z"",
      ""error"": null,
      ""id"": ""zz4ibbonubfz7carwiefibzgga"",
      ""input"": {
        ""input_images"": ""https://example.com/my-input-images.zip""
      },
      ""metrics"": {
        ""predict_time"": 502.713876
      },
      ""output"": {
        ""version"": ""..."",
        ""weights"": ""...""
      },
      ""started_at"": ""2023-09-08T16:32:57.112647Z"",
      ""source"": ""api"",
      ""status"": ""succeeded"",
      ""urls"": {
        ""get"": ""https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga"",
        ""cancel"": ""https://api.replicate.com/v1/trainings/zz4ibbonubfz7carwiefibzgga/cancel""
      },
      ""model"": ""stability-ai/sdxl"",
      ""version"": ""da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf"",
    }
  ]
}
```

`id` will be the unique ID of the training.

`source` will indicate how the training was created. Possible values are `web` or `api`.

`status` will be the status of the training. Refer to [get a single training](#trainings.get) for possible values.

`urls` will be a convenience object that can be used to construct new API requests for the given training.

`version` will be the unique ID of model version used to create the training.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.ListTrainingsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}