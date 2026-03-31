//HintName: G.Commands.AgentsAgentsAddMetricToAgentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AgentsAgentsAddMetricToAgentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentsAddMetricToAgentCartesiaVersion cartesiaVersion,
            string agentId,
            string metricId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AgentsAddMetricToAgentCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = @"The ID of the agent.",
        };

        private global::System.CommandLine.Argument<string> MetricId { get; } = new(
            name: "metricId")
        {
            Description = @"The ID of the metric.",
        };



        public AgentsAgentsAddMetricToAgentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "agents",
            description: @"Add a metric to an agent. Once the metric is added, it will be run on all calls made to the agent automatically from that point onwards.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(AgentId);
            Arguments.Add(MetricId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var agentId = parseResult.GetRequiredValue(AgentId);
            var metricId = parseResult.GetRequiredValue(MetricId);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                metricId: metricId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Agents.AgentsAddMetricToAgentAsync(
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                metricId: metricId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}