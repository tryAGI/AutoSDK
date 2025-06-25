//HintName: G.Commands.DeployCreateHfDeployHfPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeployCreateHfDeployHfPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string modelName,
            string? task,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeployResult response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = @"Model Id from huggingface",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Task { get; } = new(
            name: "task")
        {
            Description = @"Task",
        };
        public DeployCreateHfDeployHfPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deploy",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelName);
            Options.Add(XiApiKey);
            Options.Add(Task);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var modelName = parseResult.GetRequiredValue(ModelName);
            var task = parseResult.GetRequiredValue(Task);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                modelName: modelName,
                task: task,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeployCreateHfDeployHfPostAsync(
                xiApiKey: xiApiKey,
                modelName: modelName,
                task: task,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}