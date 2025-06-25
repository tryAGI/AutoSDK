//HintName: G.Commands.ListInputItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListInputItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string responseId,
            int? limit,
            global::G.ListInputItemsOrder? order,
            string? after,
            string? before,
            global::System.Collections.Generic.IList<global::G.Includable>? include,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ResponseItemList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ResponseId { get; } = new(
            name: "responseId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ListInputItemsOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Includable>?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };
        public ListInputItemsCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Arguments.Add(ResponseId);
            Options.Add(Limit);
            Options.Add(Order);
            Options.Add(After);
            Options.Add(Before);
            Options.Add(Include);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var responseId = parseResult.GetRequiredValue(ResponseId);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);
            var after = parseResult.GetRequiredValue(After);
            var before = parseResult.GetRequiredValue(Before);
            var include = parseResult.GetRequiredValue(Include);

            Validate(
                parseResult: parseResult,
                responseId: responseId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                include: include,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Responses.ListInputItemsAsync(
                responseId: responseId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                include: include,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}