//HintName: G.Commands.DeploymentLogsQueryV1DeploymentLogsQueryGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeploymentLogsQueryV1DeploymentLogsQueryGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deployId,
            string? podName,
            string? from,
            string? to,
            int? limit,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentLogQueryOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DeployId { get; } = new(
            name: "deployId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> PodName { get; } = new(
            name: "podName")
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
        public DeploymentLogsQueryV1DeploymentLogsQueryGetCommand(G.IApi client) : base(
            name: "deployment",
            description: @"Query deployment logs.
* Without timestamps (from/to) returns last `limit` messages (in last month).
* With `from` only, returns first `limit` messages after `from` (inclusive).
* With `to` only, returns last `limit` messages before `to` (inclusive).
* With both `from` and `to`, return the first `limit` messages after `from`, but not later than `to`.
* `from` and `to` should be no more than a month apart.")
        {
            _client = client;

            Arguments.Add(DeployId);
            Options.Add(PodName);
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
            var podName = parseResult.GetRequiredValue(PodName);
            var from = parseResult.GetRequiredValue(From);
            var to = parseResult.GetRequiredValue(To);
            var limit = parseResult.GetRequiredValue(Limit);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                deployId: deployId,
                podName: podName,
                from: from,
                to: to,
                limit: limit,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeploymentLogsQueryV1DeploymentLogsQueryGetAsync(
                deployId: deployId,
                podName: podName,
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