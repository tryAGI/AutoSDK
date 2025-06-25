//HintName: G.Commands.DeleteLoraV1LoraLoraNameDeleteCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteLoraV1LoraLoraNameDeleteCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string loraName,
            string? xiApiKey,
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
        public DeleteLoraV1LoraLoraNameDeleteCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(LoraName);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var loraName = parseResult.GetRequiredValue(LoraName);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                loraName: loraName,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeleteLoraV1LoraLoraNameDeleteAsync(
                loraName: loraName,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}