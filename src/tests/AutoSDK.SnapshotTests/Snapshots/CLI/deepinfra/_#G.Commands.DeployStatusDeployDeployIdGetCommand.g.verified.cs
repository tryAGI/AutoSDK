//HintName: G.Commands.DeployStatusDeployDeployIdGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeployStatusDeployDeployIdGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deployId,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DeployId { get; } = new(
            name: "deployId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public DeployStatusDeployDeployIdGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deploy",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DeployId);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var deployId = parseResult.GetRequiredValue(DeployId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                deployId: deployId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeployStatusDeployDeployIdGetAsync(
                deployId: deployId,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}