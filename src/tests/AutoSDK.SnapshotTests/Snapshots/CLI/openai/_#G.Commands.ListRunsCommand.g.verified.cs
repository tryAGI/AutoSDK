//HintName: G.Commands.ListRunsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListRunsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string threadId,
            int? limit,
            global::G.ListRunsOrder? order,
            string? after,
            string? before,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListRunsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ListRunsOrder?> Order { get; } = new(
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
        public ListRunsCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Arguments.Add(ThreadId);
            Options.Add(Limit);
            Options.Add(Order);
            Options.Add(After);
            Options.Add(Before);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);
            var after = parseResult.GetRequiredValue(After);
            var before = parseResult.GetRequiredValue(Before);

            Validate(
                parseResult: parseResult,
                threadId: threadId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.ListRunsAsync(
                threadId: threadId,
                limit: limit,
                order: order,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}