//HintName: G.Commands.ListDeploymentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListDeploymentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentsListResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public ListDeploymentsCommand(G.IApi client) : base(
            name: "list",
            description: @"Get a list of deployments associated with the current account, including the latest release configuration for each deployment.

Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/deployments
```

The response will be a paginated JSON array of deployment objects, sorted with the most recent deployment first:

```json
{
  ""next"": ""http://api.replicate.com/v1/deployments?cursor=cD0yMDIzLTA2LTA2KzIzJTNBNDAlM0EwOC45NjMwMDAlMkIwMCUzQTAw"",
  ""previous"": null,
  ""results"": [
    {
      ""owner"": ""replicate"",
      ""name"": ""my-app-image-generator"",
      ""current_release"": {
        ""number"": 1,
        ""model"": ""stability-ai/sdxl"",
        ""version"": ""da77bc59ee60423279fd632efb4795ab731d9e3ca9705ef3341091fb989b7eaf"",
        ""created_at"": ""2024-02-15T16:32:57.018467Z"",
        ""created_by"": {
          ""type"": ""organization"",
          ""username"": ""acme"",
          ""name"": ""Acme Corp, Inc."",
          ""github_url"": ""https://github.com/acme"",
        },
        ""configuration"": {
          ""hardware"": ""gpu-t4"",
          ""min_instances"": 1,
          ""max_instances"": 5
        }
      }
    }
  ]
}
```")
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
            var response = await _client.ListDeploymentsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}