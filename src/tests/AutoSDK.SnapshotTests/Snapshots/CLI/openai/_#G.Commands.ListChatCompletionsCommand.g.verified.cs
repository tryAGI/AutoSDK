//HintName: G.Commands.ListChatCompletionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListChatCompletionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? model,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? after,
            int? limit,
            global::G.ListChatCompletionsOrder? order,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ChatCompletionList response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
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

        private global::System.CommandLine.Option<global::G.ListChatCompletionsOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };
        public ListChatCompletionsCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Options.Add(Model);
            Options.Add(Metadata);
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
            var model = parseResult.GetRequiredValue(Model);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);

            Validate(
                parseResult: parseResult,
                model: model,
                metadata: metadata,
                after: after,
                limit: limit,
                order: order,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.ListChatCompletionsAsync(
                model: model,
                metadata: metadata,
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