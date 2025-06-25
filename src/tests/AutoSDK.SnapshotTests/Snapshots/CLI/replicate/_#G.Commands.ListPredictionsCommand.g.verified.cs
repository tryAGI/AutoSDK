//HintName: G.Commands.ListPredictionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListPredictionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        public ListPredictionsCommand(G.IApi client) : base(
            name: "list",
            description: @"Get a paginated list of predictions that you've created. This will include predictions created from the API and the website. It will return 100 records per page.

Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/predictions
```

The response will be a paginated JSON array of prediction objects, sorted with the most recent prediction first:

```json
{
  ""next"": null,
  ""previous"": null,
  ""results"": [
    {
      ""completed_at"": ""2023-09-08T16:19:34.791859Z"",
      ""created_at"": ""2023-09-08T16:19:34.907244Z"",
      ""data_removed"": false,
      ""error"": null,
      ""id"": ""gm3qorzdhgbfurvjtvhg6dckhu"",
      ""input"": {
        ""text"": ""Alice""
      },
      ""metrics"": {
        ""predict_time"": 0.012683
      },
      ""output"": ""hello Alice"",
      ""started_at"": ""2023-09-08T16:19:34.779176Z"",
      ""source"": ""api"",
      ""status"": ""succeeded"",
      ""urls"": {
        ""get"": ""https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu"",
        ""cancel"": ""https://api.replicate.com/v1/predictions/gm3qorzdhgbfurvjtvhg6dckhu/cancel""
      },
      ""model"": ""replicate/hello-world"",
      ""version"": ""5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa"",
    }
  ]
}
```

`id` will be the unique ID of the prediction.

`source` will indicate how the prediction was created. Possible values are `web` or `api`.

`status` will be the status of the prediction. Refer to [get a single prediction](#predictions.get) for possible values.

`urls` will be a convenience object that can be used to construct new API requests for the given prediction. If the requested model version supports streaming, this will have a `stream` entry with an HTTPS URL that you can use to construct an [`EventSource`](https://developer.mozilla.org/en-US/docs/Web/API/EventSource).

`model` will be the model identifier string in the format of `{model_owner}/{model_name}`.

`version` will be the unique ID of model version used to create the prediction.

`data_removed` will be `true` if the input and output data has been deleted.")
        {
            _client = client;


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
            await _client.ListPredictionsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}