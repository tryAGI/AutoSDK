//HintName: G.Commands.GetConvaiBatchCallingWorkspaceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConvaiBatchCallingWorkspaceCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? limit,
            string? lastDoc,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.WorkspaceBatchCallsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> LastDoc { get; } = new(
            name: "lastDoc")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetConvaiBatchCallingWorkspaceCommand(G.IApi client) : base(
            name: "get",
            description: @"Get all batch calls for the current workspace.")
        {
            _client = client;

            Options.Add(Limit);
            Options.Add(LastDoc);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var limit = parseResult.GetRequiredValue(Limit);
            var lastDoc = parseResult.GetRequiredValue(LastDoc);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                limit: limit,
                lastDoc: lastDoc,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.GetConvaiBatchCallingWorkspaceAsync(
                limit: limit,
                lastDoc: lastDoc,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}