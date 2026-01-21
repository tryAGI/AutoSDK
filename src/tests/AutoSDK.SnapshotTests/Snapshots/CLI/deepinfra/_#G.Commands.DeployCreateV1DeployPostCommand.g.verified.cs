//HintName: G.Commands.DeployCreateV1DeployPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeployCreateV1DeployPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::G.ModelProvider? provider,
            string modelName,
            string? version,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeployResult response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = @"model name in specified provider",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ModelProvider?> Provider { get; } = new(
            name: "provider")
        {
            Description = @"namespace for the model name",
        };

        private global::System.CommandLine.Option<string?> Version { get; } = new(
            name: "version")
        {
            Description = @"A specific revision, if left empty uses the last one",
        };
        public DeployCreateV1DeployPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deploy",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelName);
            Options.Add(XiApiKey);
            Options.Add(Provider);
            Options.Add(Version);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var provider = parseResult.GetRequiredValue(Provider);
            var modelName = parseResult.GetRequiredValue(ModelName);
            var version = parseResult.GetRequiredValue(Version);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                provider: provider,
                modelName: modelName,
                version: version,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeployCreateV1DeployPostAsync(
                xiApiKey: xiApiKey,
                provider: provider,
                modelName: modelName,
                version: version,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}