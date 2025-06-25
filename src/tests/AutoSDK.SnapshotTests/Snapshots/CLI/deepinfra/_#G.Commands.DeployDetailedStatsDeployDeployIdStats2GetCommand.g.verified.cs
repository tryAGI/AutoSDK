//HintName: G.Commands.DeployDetailedStatsDeployDeployIdStats2GetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeployDetailedStatsDeployDeployIdStats2GetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deployId,
            string from,
            string? to,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DetailedDeploymentStatsOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DeployId { get; } = new(
            name: "deployId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> From { get; } = new(
            name: "from")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> To { get; } = new(
            name: "to")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public DeployDetailedStatsDeployDeployIdStats2GetCommand(G.IApi client) : base(
            name: "deploy",
            description: @"")
        {
            _client = client;

            Arguments.Add(DeployId);
            Arguments.Add(From);
            Options.Add(To);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var deployId = parseResult.GetRequiredValue(DeployId);
            var from = parseResult.GetRequiredValue(From);
            var to = parseResult.GetRequiredValue(To);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                deployId: deployId,
                from: from,
                to: to,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeployDetailedStatsDeployDeployIdStats2GetAsync(
                deployId: deployId,
                from: from,
                to: to,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}