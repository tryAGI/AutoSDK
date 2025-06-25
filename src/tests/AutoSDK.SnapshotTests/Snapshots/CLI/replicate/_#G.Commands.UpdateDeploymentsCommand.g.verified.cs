//HintName: G.Commands.UpdateDeploymentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateDeploymentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deploymentOwner,
            string deploymentName,
            string? hardware,
            int? maxInstances,
            int? minInstances,
            string? version,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentsUpdateResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DeploymentOwner { get; } = new(
            name: "deploymentOwner")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> DeploymentName { get; } = new(
            name: "deploymentName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Hardware { get; } = new(
            name: "hardware")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MaxInstances { get; } = new(
            name: "maxInstances")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MinInstances { get; } = new(
            name: "minInstances")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Version { get; } = new(
            name: "version")
        {
            Description = @"",
        };
        public UpdateDeploymentsCommand(G.IApi client) : base(
            name: "update",
            description: @"Update properties of an existing deployment, including hardware, min/max instances, and the deployment's underlying model [version](https://replicate.com/docs/how-does-replicate-work#versions).

Example cURL request:

```console
curl -s \
  -X PATCH \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  -H ""Content-Type: application/json"" \
  -d '{""min_instances"": 3, ""max_instances"": 10}' \
  https://api.replicate.com/v1/deployments/acme/my-app-image-generator
```

The response will be a JSON object describing the deployment:

```json
{
  ""owner"": ""acme"",
  ""name"": ""my-app-image-generator"",
  ""current_release"": {
    ""number"": 2,
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
      ""min_instances"": 3,
      ""max_instances"": 10
    }
  }
}
```

Updating any deployment properties will increment the `number` field of the `current_release`.")
        {
            _client = client;

            Arguments.Add(DeploymentOwner);
            Arguments.Add(DeploymentName);
            Options.Add(Hardware);
            Options.Add(MaxInstances);
            Options.Add(MinInstances);
            Options.Add(Version);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var deploymentOwner = parseResult.GetRequiredValue(DeploymentOwner);
            var deploymentName = parseResult.GetRequiredValue(DeploymentName);
            var hardware = parseResult.GetRequiredValue(Hardware);
            var maxInstances = parseResult.GetRequiredValue(MaxInstances);
            var minInstances = parseResult.GetRequiredValue(MinInstances);
            var version = parseResult.GetRequiredValue(Version);

            Validate(
                parseResult: parseResult,
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName,
                hardware: hardware,
                maxInstances: maxInstances,
                minInstances: minInstances,
                version: version,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.UpdateDeploymentsAsync(
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName,
                hardware: hardware,
                maxInstances: maxInstances,
                minInstances: minInstances,
                version: version,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}