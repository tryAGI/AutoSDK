//HintName: G.Commands.ModelPublicityModelsModelNamePublicityPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicityModelsModelNamePublicityPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelName,
            string? xiApiKey,
            bool @public,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<bool> Public { get; } = new(
            name: "@public")
        {
            Description = @"whether to make the model public of private",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public ModelPublicityModelsModelNamePublicityPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "model",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ModelName);
            Arguments.Add(Public);
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
            var @public = parseResult.GetRequiredValue(Public);

            Validate(
                parseResult: parseResult,
                modelName: modelName,
                xiApiKey: xiApiKey,
                @public: @public,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ModelPublicityModelsModelNamePublicityPostAsync(
                modelName: modelName,
                xiApiKey: xiApiKey,
                @public: @public,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}