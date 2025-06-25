//HintName: G.Commands.UpdateLoraV1LoraLoraNamePatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateLoraV1LoraLoraNamePatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string loraName,
            string? xiApiKey,
            bool? @private,
            string? description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> LoraName { get; } = new(
            name: "loraName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Private { get; } = new(
            name: "@private")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };
        public UpdateLoraV1LoraLoraNamePatchCommand(G.IApi client) : base(
            name: "update",
            description: @"")
        {
            _client = client;

            Arguments.Add(LoraName);
            Options.Add(XiApiKey);
            Options.Add(Private);
            Options.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var loraName = parseResult.GetRequiredValue(LoraName);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var @private = parseResult.GetRequiredValue(Private);
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                loraName: loraName,
                xiApiKey: xiApiKey,
                @private: @private,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.UpdateLoraV1LoraLoraNamePatchAsync(
                loraName: loraName,
                xiApiKey: xiApiKey,
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