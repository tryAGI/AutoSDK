//HintName: G.Commands.LogsQueryV1LogsQueryGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LogsQueryV1LogsQueryGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deployId,
            string? from,
            string? to,
            int? limit,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LogQueryOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DeployId { get; } = new(
            name: "deployId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> From { get; } = new(
            name: "from")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> To { get; } = new(
            name: "to")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public LogsQueryV1LogsQueryGetCommand(G.IApi client) : base(
            name: "logs",
            description: @"Query inference logs.
* Without timestamps (from/to) returns last `limit` messages (in last month).
* With `from` only, returns first `limit` messages after `from` (inclusive).
* With `to` only, returns last `limit` messages before `to` (inclusive).
* With both `from` and `to`, return the first `limit` messages after `from`, but not later than `to`.
* `from` and `to` should be no more than a month apart.")
        {
            _client = client;

            Arguments.Add(DeployId);
            Options.Add(From);
            Options.Add(To);
            Options.Add(Limit);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var deployId = parseResult.GetRequiredValue(DeployId);
            var from = parseResult.GetRequiredValue(From);
            var to = parseResult.GetRequiredValue(To);
            var limit = parseResult.GetRequiredValue(Limit);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                deployId: deployId,
                from: from,
                to: to,
                limit: limit,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.LogsQueryV1LogsQueryGetAsync(
                deployId: deployId,
                from: from,
                to: to,
                limit: limit,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}