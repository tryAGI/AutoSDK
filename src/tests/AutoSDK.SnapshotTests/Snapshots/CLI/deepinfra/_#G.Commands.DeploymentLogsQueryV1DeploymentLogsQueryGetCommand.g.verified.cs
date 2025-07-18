﻿//HintName: G.Commands.DeploymentLogsQueryV1DeploymentLogsQueryGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeploymentLogsQueryV1DeploymentLogsQueryGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"the deploy id to get the logs from",
        };

        private global::System.CommandLine.Option<string?> PodName { get; } = new(
            name: "podName")
        {
            Description = @"the pod name to get the logs from",
        };

        private global::System.CommandLine.Option<string?> From { get; } = new(
            name: "from")
        {
            Description = @"start of period, in fractional seconds since unix epoch (inclusive)",
        };

        private global::System.CommandLine.Option<string?> To { get; } = new(
            name: "to")
        {
            Description = @"end of period, in fractional seconds since unix epoch (exclusive)",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"how many items to return at most (default 100, in [1, 1000])",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public DeploymentLogsQueryV1DeploymentLogsQueryGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deployment",
            description: @"Query deployment logs.
* Without timestamps (from/to) returns last `limit` messages (in last month).
* With `from` only, returns first `limit` messages after `from` (inclusive).
* With `to` only, returns last `limit` messages before `to` (inclusive).
* With both `from` and `to`, return the first `limit` messages after `from`, but not later than `to`.
* `from` and `to` should be no more than a month apart.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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