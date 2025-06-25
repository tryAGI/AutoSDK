//HintName: G.Commands.DeployUpdateDeployDeployIdPutCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeployUpdateDeployDeployIdPutCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deployId,
            string? xiApiKey,
            global::G.ScaleSettings settings,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeployStatusOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DeployId { get; } = new(
            name: "deployId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.ScaleSettings> Settings { get; } = new(
            name: "settings")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public DeployUpdateDeployDeployIdPutCommand(G.IApi client) : base(
            name: "deploy",
            description: @"")
        {
            _client = client;

            Arguments.Add(DeployId);
            Arguments.Add(Settings);
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
            var settings = parseResult.GetRequiredValue(Settings);

            Validate(
                parseResult: parseResult,
                deployId: deployId,
                xiApiKey: xiApiKey,
                settings: settings,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeployUpdateDeployDeployIdPutAsync(
                deployId: deployId,
                xiApiKey: xiApiKey,
                settings: settings,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}