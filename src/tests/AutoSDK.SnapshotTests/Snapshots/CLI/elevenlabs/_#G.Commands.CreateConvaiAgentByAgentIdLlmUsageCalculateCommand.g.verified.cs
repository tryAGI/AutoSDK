//HintName: G.Commands.CreateConvaiAgentByAgentIdLlmUsageCalculateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiAgentByAgentIdLlmUsageCalculateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string agentId,
            string? xiApiKey,
            int? promptLength,
            int? numberOfPages,
            bool? ragEnabled,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LLMUsageCalculatorResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AgentId { get; } = new(
            name: "agentId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PromptLength { get; } = new(
            name: "promptLength")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> NumberOfPages { get; } = new(
            name: "numberOfPages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RagEnabled { get; } = new(
            name: "ragEnabled")
        {
            Description = "",
        };
        public CreateConvaiAgentByAgentIdLlmUsageCalculateCommand(G.IApi client) : base(
            name: "create",
            description: @"Calculates expected number of LLM tokens needed for the specified agent.")
        {
            _client = client;

            Arguments.Add(AgentId);
            Options.Add(XiApiKey);
            Options.Add(PromptLength);
            Options.Add(NumberOfPages);
            Options.Add(RagEnabled);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var agentId = parseResult.GetRequiredValue(AgentId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var promptLength = parseResult.GetRequiredValue(PromptLength);
            var numberOfPages = parseResult.GetRequiredValue(NumberOfPages);
            var ragEnabled = parseResult.GetRequiredValue(RagEnabled);

            Validate(
                parseResult: parseResult,
                agentId: agentId,
                xiApiKey: xiApiKey,
                promptLength: promptLength,
                numberOfPages: numberOfPages,
                ragEnabled: ragEnabled,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiAgentByAgentIdLlmUsageCalculateAsync(
                agentId: agentId,
                xiApiKey: xiApiKey,
                promptLength: promptLength,
                numberOfPages: numberOfPages,
                ragEnabled: ragEnabled,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}