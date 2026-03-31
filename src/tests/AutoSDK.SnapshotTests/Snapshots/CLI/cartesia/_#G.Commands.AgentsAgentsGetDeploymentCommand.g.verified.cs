//HintName: G.Commands.AgentsAgentsGetDeploymentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsGetDeploymentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsGetDeploymentCartesiaVersion cartesiaVersion,
            string deploymentId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Deployment response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsGetDeploymentCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> DeploymentId { get; } = new(
            name: "deploymentId")
        {
            Description = @"The ID of the deployment.",
        };



        public AgentsAgentsGetDeploymentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"Get a deployment by its ID.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(DeploymentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var deploymentId = parseResult.GetRequiredValue(DeploymentId);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                deploymentId: deploymentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsGetDeploymentAsync(
                cartesiaVersion: cartesiaVersion,
                deploymentId: deploymentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}