//HintName: G.Commands.DeployGpuAvailabilityDeployLlmGpuAvailabilityGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeployGpuAvailabilityDeployLlmGpuAvailabilityGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? source,
            string? baseModel,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeployGPUAvailability response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Source { get; } = new(
            name: "source")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> BaseModel { get; } = new(
            name: "baseModel")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public DeployGpuAvailabilityDeployLlmGpuAvailabilityGetCommand(G.IApi client) : base(
            name: "deploy",
            description: @"")
        {
            _client = client;

            Options.Add(Source);
            Options.Add(BaseModel);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var source = parseResult.GetRequiredValue(Source);
            var baseModel = parseResult.GetRequiredValue(BaseModel);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                source: source,
                baseModel: baseModel,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeployGpuAvailabilityDeployLlmGpuAvailabilityGetAsync(
                source: source,
                baseModel: baseModel,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}