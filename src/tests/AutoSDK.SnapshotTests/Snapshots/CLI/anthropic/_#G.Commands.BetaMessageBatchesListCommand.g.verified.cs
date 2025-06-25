//HintName: G.Commands.BetaMessageBatchesListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaMessageBatchesListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? beforeId,
            string? afterId,
            int? limit,
            string? anthropicBeta,
            string? anthropicVersion,
            string? xApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BetaListResponseMessageBatch response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> BeforeId { get; } = new(
            name: "beforeId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AfterId { get; } = new(
            name: "afterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AnthropicBeta { get; } = new(
            name: "anthropicBeta")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AnthropicVersion { get; } = new(
            name: "anthropicVersion")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XApiKey { get; } = new(
            name: "xApiKey")
        {
            Description = "",
        };
        public BetaMessageBatchesListCommand(G.IApi client) : base(
            name: "beta",
            description: @"List all Message Batches within a Workspace. Most recently created batches are returned first.

Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)")
        {
            _client = client;

            Options.Add(BeforeId);
            Options.Add(AfterId);
            Options.Add(Limit);
            Options.Add(AnthropicBeta);
            Options.Add(AnthropicVersion);
            Options.Add(XApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var beforeId = parseResult.GetRequiredValue(BeforeId);
            var afterId = parseResult.GetRequiredValue(AfterId);
            var limit = parseResult.GetRequiredValue(Limit);
            var anthropicBeta = parseResult.GetRequiredValue(AnthropicBeta);
            var anthropicVersion = parseResult.GetRequiredValue(AnthropicVersion);
            var xApiKey = parseResult.GetRequiredValue(XApiKey);

            Validate(
                parseResult: parseResult,
                beforeId: beforeId,
                afterId: afterId,
                limit: limit,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.MessageBatches.BetaMessageBatchesListAsync(
                beforeId: beforeId,
                afterId: afterId,
                limit: limit,
                anthropicBeta: anthropicBeta,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}