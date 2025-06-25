//HintName: G.Commands.GetChatCompletionMessagesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetChatCompletionMessagesCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string completionId,
            string? after,
            int? limit,
            global::G.GetChatCompletionMessagesOrder? order,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ChatCompletionMessageList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> CompletionId { get; } = new(
            name: "completionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.GetChatCompletionMessagesOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };
        public GetChatCompletionMessagesCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(CompletionId);
            Options.Add(After);
            Options.Add(Limit);
            Options.Add(Order);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var completionId = parseResult.GetRequiredValue(CompletionId);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);

            Validate(
                parseResult: parseResult,
                completionId: completionId,
                after: after,
                limit: limit,
                order: order,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.GetChatCompletionMessagesAsync(
                completionId: completionId,
                after: after,
                limit: limit,
                order: order,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}