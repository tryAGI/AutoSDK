//HintName: G.Commands.DeployCreateLlmDeployLlmPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeployCreateLlmDeployLlmPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string modelName,
            global::G.DeployGPUs gpu,
            int? numGpus,
            int? maxBatchSize,
            global::G.HFWeights? hf,
            global::G.ScaleSettings? settings,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.DeployGPUs> Gpu { get; } = new(
            name: "gpu")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> NumGpus { get; } = new(
            name: "numGpus")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxBatchSize { get; } = new(
            name: "maxBatchSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.HFWeights?> Hf { get; } = new(
            name: "hf")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ScaleSettings?> Settings { get; } = new(
            name: "settings")
        {
            Description = "",
        };
        public DeployCreateLlmDeployLlmPostCommand(G.IApi client) : base(
            name: "deploy",
            description: @"")
        {
            _client = client;

            Arguments.Add(ModelName);
            Arguments.Add(Gpu);
            Options.Add(XiApiKey);
            Options.Add(NumGpus);
            Options.Add(MaxBatchSize);
            Options.Add(Hf);
            Options.Add(Settings);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var modelName = parseResult.GetRequiredValue(ModelName);
            var gpu = parseResult.GetRequiredValue(Gpu);
            var numGpus = parseResult.GetRequiredValue(NumGpus);
            var maxBatchSize = parseResult.GetRequiredValue(MaxBatchSize);
            var hf = parseResult.GetRequiredValue(Hf);
            var settings = parseResult.GetRequiredValue(Settings);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                modelName: modelName,
                gpu: gpu,
                numGpus: numGpus,
                maxBatchSize: maxBatchSize,
                hf: hf,
                settings: settings,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeployCreateLlmDeployLlmPostAsync(
                xiApiKey: xiApiKey,
                modelName: modelName,
                gpu: gpu,
                numGpus: numGpus,
                maxBatchSize: maxBatchSize,
                hf: hf,
                settings: settings,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}