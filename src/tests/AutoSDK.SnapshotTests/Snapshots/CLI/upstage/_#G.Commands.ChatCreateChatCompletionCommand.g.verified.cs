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
            string model,
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            double? temperature,
            double? topP,
            int? maxTokens,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            bool? stream,
            int? n,
            int? seed,
            double? frequencyPenalty,
            double? presencePenalty,
            global::G.ResponseFormat? responseFormat,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools,
            global::G.OneOf<global::G.ChatCompletionRequestToolChoice?, global::G.ChatCompletionNamedToolChoice>? toolChoice,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ChatCompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for chat completion.
Available models: solar-pro, solar-mini, solar-mini-ja",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ChatMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"A list of messages comprising the conversation so far.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Sampling temperature between 0 and 2. Higher values make output more random.",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"Nucleus sampling parameter. Only tokens with top_p probability mass are considered.",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"Maximum number of tokens to generate in the response.",
        };

        private global::System.CommandLine.Option<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"Up to 4 sequences where the API will stop generating further tokens.",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"If true, partial message deltas will be sent as server-sent events.",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"How many chat completion choices to generate for each input message.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"If specified, the system will make a best effort to sample deterministically.",
        };

        private global::System.CommandLine.Option<double?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"Penalizes new tokens based on their existing frequency in the text so far.",
        };

        private global::System.CommandLine.Option<double?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"Penalizes new tokens based on whether they appear in the text so far.",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatCompletionTool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"A list of tools the model may call.",
        };

        private global::System.CommandLine.Option<global::G.OneOf<global::G.ChatCompletionRequestToolChoice?, global::G.ChatCompletionNamedToolChoice>?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"Controls which (if any) tool is called by the model.",
        };


        public ChatCreateChatCompletionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a model response for the given chat conversation.
Supports Solar Pro, Solar Mini, and Solar Mini JA models.
Compatible with OpenAI chat completions API format.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(MaxTokens);
            Options.Add(Stop);
            Options.Add(Stream);
            Options.Add(N);
            Options.Add(Seed);
            Options.Add(FrequencyPenalty);
            Options.Add(PresencePenalty);
            Options.Add(ResponseFormat);
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
            var stop = parseResult.GetRequiredValue(Stop);
            var stream = parseResult.GetRequiredValue(Stream);
            var n = parseResult.GetRequiredValue(N);
            var seed = parseResult.GetRequiredValue(Seed);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);

            Validate(
                parseResult: parseResult,
                model: model,
                messages: messages,
                temperature: temperature,
                topP: topP,
                maxTokens: maxTokens,
                stop: stop,
                stream: stream,
                n: n,
                seed: seed,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                responseFormat: responseFormat,
                tools: tools,
                toolChoice: toolChoice,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.CreateChatCompletionAsync(
                model: model,
                messages: messages,
                temperature: temperature,
                topP: topP,
                maxTokens: maxTokens,
                stop: stop,
                stream: stream,
                n: n,
                seed: seed,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                responseFormat: responseFormat,
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