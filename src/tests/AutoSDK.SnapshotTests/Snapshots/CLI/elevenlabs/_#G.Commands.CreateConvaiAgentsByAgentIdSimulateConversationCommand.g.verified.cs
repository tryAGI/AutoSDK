//HintName: G.Commands.CreateConvaiAgentsByAgentIdSimulateConversationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiAgentsByAgentIdSimulateConversationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string agentId,
            string? xiApiKey,
            global::G.ConversationSimulationSpecification simulationSpecification,
            global::System.Collections.Generic.IList<global::G.PromptEvaluationCriteria>? extraEvaluationCriteria,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AgentSimulatedChatTestResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ConversationSimulationSpecification> SimulationSpecification { get; } = new(
            name: "simulationSpecification")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.PromptEvaluationCriteria>?> ExtraEvaluationCriteria { get; } = new(
            name: "extraEvaluationCriteria")
        {
            Description = "",
        };
        public CreateConvaiAgentsByAgentIdSimulateConversationCommand(G.IApi client) : base(
            name: "create",
            description: @"Run a conversation between the agent and a simulated user.")
        {
            _client = client;

            Arguments.Add(AgentId);
            Arguments.Add(SimulationSpecification);
            Options.Add(XiApiKey);
            Options.Add(ExtraEvaluationCriteria);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var simulationSpecification = parseResult.GetRequiredValue(SimulationSpecification);
            var extraEvaluationCriteria = parseResult.GetRequiredValue(ExtraEvaluationCriteria);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                xiApiKey: xiApiKey,
                simulationSpecification: simulationSpecification,
                extraEvaluationCriteria: extraEvaluationCriteria,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiAgentsByAgentIdSimulateConversationAsync(
                agentId: agentId,
                xiApiKey: xiApiKey,
                simulationSpecification: simulationSpecification,
                extraEvaluationCriteria: extraEvaluationCriteria,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}