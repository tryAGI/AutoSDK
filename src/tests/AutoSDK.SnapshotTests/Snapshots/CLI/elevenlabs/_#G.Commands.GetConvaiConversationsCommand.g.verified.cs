//HintName: G.Commands.GetConvaiConversationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiConversationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? cursor,
            string? agentId,
            global::G.EvaluationSuccessResult? callSuccessful,
            global::System.DateTimeOffset? callStartBeforeUnix,
            global::System.DateTimeOffset? callStartAfterUnix,
            int? pageSize,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetConversationsPageResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Cursor { get; } = new(
            name: "cursor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.EvaluationSuccessResult?> CallSuccessful { get; } = new(
            name: "callSuccessful")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTimeOffset?> CallStartBeforeUnix { get; } = new(
            name: "callStartBeforeUnix")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTimeOffset?> CallStartAfterUnix { get; } = new(
            name: "callStartAfterUnix")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PageSize { get; } = new(
            name: "pageSize")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiConversationsCommand(G.IApi client) : base(
            name: "get",
            description: @"Get all conversations of agents that user owns. With option to restrict to a specific agent.")
        {
            _client = client;

            Options.Add(Cursor);
            Options.Add(AgentId);
            Options.Add(CallSuccessful);
            Options.Add(CallStartBeforeUnix);
            Options.Add(CallStartAfterUnix);
            Options.Add(PageSize);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cursor = parseResult.GetRequiredValue(Cursor);
            var agentId = parseResult.GetRequiredValue(AgentId);
            var callSuccessful = parseResult.GetRequiredValue(CallSuccessful);
            var callStartBeforeUnix = parseResult.GetRequiredValue(CallStartBeforeUnix);
            var callStartAfterUnix = parseResult.GetRequiredValue(CallStartAfterUnix);
            var pageSize = parseResult.GetRequiredValue(PageSize);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                cursor: cursor,
                agentId: agentId,
                callSuccessful: callSuccessful,
                callStartBeforeUnix: callStartBeforeUnix,
                callStartAfterUnix: callStartAfterUnix,
                pageSize: pageSize,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiConversationsAsync(
                cursor: cursor,
                agentId: agentId,
                callSuccessful: callSuccessful,
                callStartBeforeUnix: callStartBeforeUnix,
                callStartAfterUnix: callStartAfterUnix,
                pageSize: pageSize,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}