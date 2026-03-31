//HintName: G.Commands.AgentsAgentsExportMetricResultsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsExportMetricResultsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsExportMetricResultsCartesiaVersion cartesiaVersion,
            string? agentId,
            string? deploymentId,
            string? metricId,
            string? callId,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsExportMetricResultsCartesiaVersion> CartesiaVersion { get; } = new(
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

        private global::System.CommandLine.Option<string?> CallId { get; } = new(
            name: "callId")
        {
            Description = @"The ID of the call.",
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


        public AgentsAgentsExportMetricResultsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"Export metric results to a CSV file. This endpoint streams at most 100k results as the CSV file directly to the client. Use the optional filters to narrow down the results to export.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Options.Add(AgentId);
            Options.Add(DeploymentId);
            Options.Add(MetricId);
            Options.Add(CallId);
            Options.Add(StartDate);
            Options.Add(EndDate);

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
            var callId = parseResult.GetRequiredValue(CallId);
            var startDate = parseResult.GetRequiredValue(StartDate);
            var endDate = parseResult.GetRequiredValue(EndDate);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                deploymentId: deploymentId,
                metricId: metricId,
                callId: callId,
                startDate: startDate,
                endDate: endDate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Agents.AgentsExportMetricResultsAsync(
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                deploymentId: deploymentId,
                metricId: metricId,
                callId: callId,
                startDate: startDate,
                endDate: endDate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}