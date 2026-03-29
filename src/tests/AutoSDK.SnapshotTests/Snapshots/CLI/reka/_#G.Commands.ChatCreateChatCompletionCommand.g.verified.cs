//HintName: G.Commands.ChatCreateChatCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ChatCreateChatCompletionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.ChatMessageInput> messages,
            string model,
            double? temperature,
            int? maxTokens,
            double? topP,
            int? topK,
            double? frequencyPenalty,
            double? presencePenalty,
            bool? stream,
            int? seed,
            global::System.Collections.Generic.IList<string>? stop,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::G.CreateChatCompletionRequestToolChoice? toolChoice,
            global::G.ResearchConfig? research,
            global::G.ResponseFormat? responseFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateChatCompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ChatMessageInput>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"A list of messages comprising the conversation so far.",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the model to use.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Controls randomness. 0.0 is deterministic.",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"The maximum number of tokens to generate.",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"Nucleus sampling threshold. Only tokens with cumulative probability up to top_p are considered.",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"Consider only top-k most probable tokens at each step.",
        };

        private global::System.CommandLine.Option<double?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"Penalizes repeated tokens. Positive values reduce repetition.",
        };

        private global::System.CommandLine.Option<double?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"Penalizes tokens that have appeared in the output. Positive values encourage new topics.",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"If true, partial message deltas will be sent as server-sent events.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Random seed for reproducibility.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"Up to 4 sequences where the API will stop generating further tokens.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Tool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"A list of tools the model may call.",
        };

        private global::System.CommandLine.Option<global::G.CreateChatCompletionRequestToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"Controls which tool is called by the model.",
        };

        private global::System.CommandLine.Option<global::G.ResearchConfig?> Research { get; } = new(
            name: "research")
        {
            Description = @"Configuration for the Reka Research model (reka-flash-research). Controls web search and parallel thinking.",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"Structured output configuration. Forces the model to return valid JSON matching a schema.",
        };


        public ChatCreateChatCompletionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a chat completion for the provided messages and model.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Messages);
            Arguments.Add(Model);
            Options.Add(Temperature);
            Options.Add(MaxTokens);
            Options.Add(TopP);
            Options.Add(TopK);
            Options.Add(FrequencyPenalty);
            Options.Add(PresencePenalty);
            Options.Add(Stream);
            Options.Add(Seed);
            Options.Add(Stop);
            Options.Add(Tools);
            Options.Add(ToolChoice);
            Options.Add(Research);
            Options.Add(ResponseFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var messages = parseResult.GetRequiredValue(Messages);
            var model = parseResult.GetRequiredValue(Model);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var topP = parseResult.GetRequiredValue(TopP);
            var topK = parseResult.GetRequiredValue(TopK);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var stream = parseResult.GetRequiredValue(Stream);
            var seed = parseResult.GetRequiredValue(Seed);
            var stop = parseResult.GetRequiredValue(Stop);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var research = parseResult.GetRequiredValue(Research);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);

            Validate(
                parseResult: parseResult,
                messages: messages,
                model: model,
                temperature: temperature,
                maxTokens: maxTokens,
                topP: topP,
                topK: topK,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                stream: stream,
                seed: seed,
                stop: stop,
                tools: tools,
                toolChoice: toolChoice,
                research: research,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.CreateChatCompletionAsync(
                messages: messages,
                model: model,
                temperature: temperature,
                maxTokens: maxTokens,
                topP: topP,
                topK: topK,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                stream: stream,
                seed: seed,
                stop: stop,
                tools: tools,
                toolChoice: toolChoice,
                research: research,
                responseFormat: responseFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}