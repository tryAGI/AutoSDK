//HintName: G.Commands.DeleteDeploymentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteDeploymentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deploymentOwner,
            string deploymentName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        public DeleteDeploymentsCommand(G.IApi client) : base(
            name: "delete",
            description: @"Delete a deployment

Deployment deletion has some restrictions:

- You can only delete deployments that have been offline and unused for at least 15 minutes.

Example cURL request:

```command
curl -s -X DELETE \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/deployments/acme/my-app-image-generator
```

The response will be an empty 204, indicating the deployment has been deleted.")
        {
            _client = client;

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
            await _client.DeleteDeploymentsAsync(
                deploymentOwner: deploymentOwner,
                deploymentName: deploymentName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}