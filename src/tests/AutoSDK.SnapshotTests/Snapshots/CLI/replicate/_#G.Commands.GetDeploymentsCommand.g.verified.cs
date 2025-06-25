//HintName: G.Commands.GetDeploymentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetDeploymentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deploymentOwner,
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentsGetResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DeploymentOwner { get; } = new(
            name: "deploymentOwner")
        {
            Description = @"The name of the user or organization that owns the deployment.",
        };

        private global::System.CommandLine.Argument<string> DeploymentName { get; } = new(
            name: "deploymentName")
        {
            Description = @"The name of the deployment.",
        };

        public GetDeploymentsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get information about a deployment by name including the current release.

Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/deployments/replicate/my-app-image-generator
```

The response will be a JSON object describing the deployment:

```json
{
  ""owner"": ""acme"",
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
```")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DeploymentOwner);
            Arguments.Add(DeploymentName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var deploymentOwner = parseResult.GetRequiredValue(DeploymentOwner);
            var deploymentName = parseResult.GetRequiredValue(DeploymentName);

            Validate(
                parseResult: parseResult,
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GetDeploymentsAsync(
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}