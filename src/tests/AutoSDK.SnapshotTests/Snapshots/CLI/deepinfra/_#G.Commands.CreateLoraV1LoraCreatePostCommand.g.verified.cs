//HintName: G.Commands.CreateLoraV1LoraCreatePostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateLoraV1LoraCreatePostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string baseModel,
            string loraName,
            global::G.SourceModel source,
            bool @private,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BaseModel { get; } = new(
            name: "baseModel")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> LoraName { get; } = new(
            name: "loraName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.SourceModel> Source { get; } = new(
            name: "source")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<bool> Private { get; } = new(
            name: "@private")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };
        public CreateLoraV1LoraCreatePostCommand(G.IApi client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(BaseModel);
            Arguments.Add(LoraName);
            Arguments.Add(Source);
            Arguments.Add(Private);
            Options.Add(XiApiKey);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var baseModel = parseResult.GetRequiredValue(BaseModel);
            var loraName = parseResult.GetRequiredValue(LoraName);
            var source = parseResult.GetRequiredValue(Source);
            var @private = parseResult.GetRequiredValue(Private);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                baseModel: baseModel,
                loraName: loraName,
                source: source,
                @private: @private,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateLoraV1LoraCreatePostAsync(
                xiApiKey: xiApiKey,
                baseModel: baseModel,
                loraName: loraName,
                source: source,
                @private: @private,
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}