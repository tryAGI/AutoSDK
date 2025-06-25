//HintName: G.Commands.CreateConvaiLlmUsageCalculateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiLlmUsageCalculateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int promptLength,
            int numberOfPages,
            bool ragEnabled,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LLMUsageCalculatorResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> PromptLength { get; } = new(
            name: "promptLength")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> NumberOfPages { get; } = new(
            name: "numberOfPages")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<bool> RagEnabled { get; } = new(
            name: "ragEnabled")
        {
            Description = "",
        };

        public CreateConvaiLlmUsageCalculateCommand(G.IApi client) : base(
            name: "create",
            description: @"Returns a list of LLM models and the expected cost for using them based on the provided values.")
        {
            _client = client;

            Arguments.Add(PromptLength);
            Arguments.Add(NumberOfPages);
            Arguments.Add(RagEnabled);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var promptLength = parseResult.GetRequiredValue(PromptLength);
            var numberOfPages = parseResult.GetRequiredValue(NumberOfPages);
            var ragEnabled = parseResult.GetRequiredValue(RagEnabled);

            Validate(
                parseResult: parseResult,
                promptLength: promptLength,
                numberOfPages: numberOfPages,
                ragEnabled: ragEnabled,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiLlmUsageCalculateAsync(
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