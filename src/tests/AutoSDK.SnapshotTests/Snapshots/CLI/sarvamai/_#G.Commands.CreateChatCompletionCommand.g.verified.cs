//HintName: G.Commands.CreateChatCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateChatCompletionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ChatCompletionRequestModel model,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessage> messages,
            double? temperature,
            double? topP,
            int? maxTokens,
            bool? stream,
            global::System.Collections.Generic.IList<string>? stop,
            int? n,
            int? seed,
            double? frequencyPenalty,
            double? presencePenalty,
            global::G.ChatCompletionRequestReasoningEffort? reasoningEffort,
            bool? wikiGrounding,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools,
            global::G.ChatCompletionRequestToolChoice? toolChoice,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ChatCompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.ChatCompletionRequestModel> Model { get; } = new(
            name: "model")
        {
            Description = @"Model ID to use for completion",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ChatCompletionMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"List of messages in the conversation",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Sampling temperature (0-2). Default: 0.2",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"Nucleus sampling parameter. Default: 1.0",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"Maximum number of tokens to generate",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"Whether to stream the response via SSE",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"Up to 4 stop sequences",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"Number of completion choices to generate",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Seed for deterministic sampling (beta)",
        };

        private global::System.CommandLine.Option<double?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"Frequency penalty (-2.0 to 2.0). Default: 0",
        };

        private global::System.CommandLine.Option<double?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"Presence penalty (-2.0 to 2.0). Default: 0",
        };

        private global::System.CommandLine.Option<global::G.ChatCompletionRequestReasoningEffort?> ReasoningEffort { get; } = new(
            name: "reasoningEffort")
        {
            Description = @"Level of reasoning effort",
        };

        private global::System.CommandLine.Option<bool?> WikiGrounding { get; } = new(
            name: "wikiGrounding")
        {
            Description = @"Enable Wikipedia-based grounding",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatCompletionTool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"List of tools the model may call",
        };

        private global::System.CommandLine.Option<global::G.ChatCompletionRequestToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"Controls tool invocation: none, auto, required",
        };


        public CreateChatCompletionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Generates a model response for the given conversation. Supports Sarvam's
Indian language LLMs including Sarvam-105B, Sarvam-30B, and Sarvam-M.
Supports tool calling, streaming, and reasoning effort control.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(MaxTokens);
            Options.Add(Stream);
            Options.Add(Stop);
            Options.Add(N);
            Options.Add(Seed);
            Options.Add(FrequencyPenalty);
            Options.Add(PresencePenalty);
            Options.Add(ReasoningEffort);
            Options.Add(WikiGrounding);
            Options.Add(Tools);
            Options.Add(ToolChoice);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var messages = parseResult.GetRequiredValue(Messages);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var stream = parseResult.GetRequiredValue(Stream);
            var stop = parseResult.GetRequiredValue(Stop);
            var n = parseResult.GetRequiredValue(N);
            var seed = parseResult.GetRequiredValue(Seed);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var reasoningEffort = parseResult.GetRequiredValue(ReasoningEffort);
            var wikiGrounding = parseResult.GetRequiredValue(WikiGrounding);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);

            Validate(
                parseResult: parseResult,
                model: model,
                messages: messages,
                temperature: temperature,
                topP: topP,
                maxTokens: maxTokens,
                stream: stream,
                stop: stop,
                n: n,
                seed: seed,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                reasoningEffort: reasoningEffort,
                wikiGrounding: wikiGrounding,
                tools: tools,
                toolChoice: toolChoice,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateChatCompletionAsync(
                model: model,
                messages: messages,
                temperature: temperature,
                topP: topP,
                maxTokens: maxTokens,
                stream: stream,
                stop: stop,
                n: n,
                seed: seed,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                reasoningEffort: reasoningEffort,
                wikiGrounding: wikiGrounding,
                tools: tools,
                toolChoice: toolChoice,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}