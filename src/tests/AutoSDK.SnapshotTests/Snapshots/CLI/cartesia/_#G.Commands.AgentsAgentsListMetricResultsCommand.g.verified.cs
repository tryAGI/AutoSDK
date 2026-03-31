//HintName: G.Commands.AgentsAgentsListMetricResultsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsListMetricResultsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsListMetricResultsCartesiaVersion cartesiaVersion,
            string? agentId,
            string? deploymentId,
            string? metricId,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            string? callId,
            string? startingAfter,
            string? endingBefore,
            int? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ListMetricResultsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsListMetricResultsCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Option<string?> AgentId { get; } = new(
            name: "agentId")
        {
            Description = @"The ID of the agent.",
        };

        private global::System.CommandLine.Option<string?> DeploymentId { get; } = new(
            name: "deploymentId")
        {
            Description = @"The ID of the deployment.",
        };

        private global::System.CommandLine.Option<string?> MetricId { get; } = new(
            name: "metricId")
        {
            Description = @"The ID of the metric.",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> StartDate { get; } = new(
            name: "startDate")
        {
            Description = @"Filter metric results created at or after this ISO 8601 date/time (e.g. 2024-04-01T00:00:00Z).",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> EndDate { get; } = new(
            name: "endDate")
        {
            Description = @"Filter metric results created before or at this ISO 8601 date/time (e.g. 2024-04-30T23:59:59Z).",
        };

        private global::System.CommandLine.Option<string?> CallId { get; } = new(
            name: "callId")
        {
            Description = @"The ID of the call.",
        };

        private global::System.CommandLine.Option<string?> StartingAfter { get; } = new(
            name: "startingAfter")
        {
            Description = @"A cursor to use in pagination. `starting_after` is a metric result ID that defines your place in the list. For example, if you make a /metrics/results request and receive 100 objects, ending with `metric_result_abc123`, your subsequent call can include `starting_after=metric_result_abc123` to fetch the next page of the list.",
        };

        private global::System.CommandLine.Option<string?> EndingBefore { get; } = new(
            name: "endingBefore")
        {
            Description = @"A cursor to use in pagination. `ending_before` is a metric result ID that defines your place in the list. For example, if you make a /metrics/results request and receive 100 objects, starting with `metric_result_abc123`, your subsequent call can include `ending_before=metric_result_abc123` to fetch the previous page of the list.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"The number of metric results to return per page, ranging between 1 and 100.",
        };


        public AgentsAgentsListMetricResultsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"Paginated list of metric results. Filter results using the query parameters,")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(AgentId);
            Options.Add(DeploymentId);
            Options.Add(MetricId);
            Options.Add(StartDate);
            Options.Add(EndDate);
            Options.Add(CallId);
            Options.Add(StartingAfter);
            Options.Add(EndingBefore);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var agentId = parseResult.GetRequiredValue(AgentId);
            var deploymentId = parseResult.GetRequiredValue(DeploymentId);
            var metricId = parseResult.GetRequiredValue(MetricId);
            var startDate = parseResult.GetRequiredValue(StartDate);
            var endDate = parseResult.GetRequiredValue(EndDate);
            var callId = parseResult.GetRequiredValue(CallId);
            var startingAfter = parseResult.GetRequiredValue(StartingAfter);
            var endingBefore = parseResult.GetRequiredValue(EndingBefore);
            var limit = parseResult.GetRequiredValue(Limit);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                deploymentId: deploymentId,
                metricId: metricId,
                startDate: startDate,
                endDate: endDate,
                callId: callId,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                limit: limit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsListMetricResultsAsync(
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                deploymentId: deploymentId,
                metricId: metricId,
                startDate: startDate,
                endDate: endDate,
                callId: callId,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                limit: limit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}