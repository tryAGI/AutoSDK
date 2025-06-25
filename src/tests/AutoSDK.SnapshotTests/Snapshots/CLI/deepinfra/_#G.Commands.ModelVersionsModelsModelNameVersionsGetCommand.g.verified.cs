//HintName: G.Commands.ModelVersionsModelsModelNameVersionsGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelVersionsModelsModelNameVersionsGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelName,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.ModelVersionOut> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public ModelVersionsModelsModelNameVersionsGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelName);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var modelName = parseResult.GetRequiredValue(ModelName);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                modelName: modelName,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ModelVersionsModelsModelNameVersionsGetAsync(
                modelName: modelName,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}