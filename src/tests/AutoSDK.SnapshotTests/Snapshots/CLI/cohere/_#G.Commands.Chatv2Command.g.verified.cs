//HintName: G.Commands.Chatv2Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Chatv2Command : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            bool? stream,
            string model,
            global::System.Collections.Generic.IList<global::G.ChatMessageV2> messages,
            global::G.ReasoningEffort? reasoningEffort,
            global::System.Collections.Generic.IList<global::G.ToolV2>? tools,
            bool? strictTools,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.Document>>? documents,
            global::G.CitationOptions? citationOptions,
            global::G.ResponseFormatV2? responseFormat,
            global::G.Chatv2RequestSafetyMode? safetyMode,
            int? maxTokens,
            global::System.Collections.Generic.IList<string>? stopSequences,
            float? temperature,
            int? seed,
            float? frequencyPenalty,
            float? presencePenalty,
            int? k,
            float? p,
            bool? logprobs,
            global::G.Chatv2RequestToolChoice? toolChoice,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.ChatResponse, global::G.StreamedChatResponseV2?> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The name of a compatible [Cohere model](https://docs.cohere.com/v2/docs/models) or the ID of a [fine-tuned](https://docs.cohere.com/v2/docs/chat-fine-tuning) model.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ChatMessageV2>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"A list of chat messages in chronological order, representing a conversation between the user and the model.

Messages can be from `User`, `Assistant`, `Tool` and `System` roles. Learn more about messages and roles in [the Chat API guide](https://docs.cohere.com/v2/docs/chat-api).",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"Defaults to `false`.

When `true`, the response will be a SSE stream of events.

Streaming is beneficial for user interfaces that render the contents of the response piece by piece, as it gets generated.",
        };

        private global::System.CommandLine.Option<global::G.ReasoningEffort?> ReasoningEffort { get; } = new(
            name: "reasoningEffort")
        {
            Description = @"The reasoning effort level of the model. This affects the model's performance and the time it takes to generate a response.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ToolV2>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"A list of tools (functions) available to the model. The model response may contain 'tool_calls' to the specified tools.

Learn more in the [Tool Use guide](https://docs.cohere.com/docs/tools).",
        };

        private global::System.CommandLine.Option<bool?> StrictTools { get; } = new(
            name: "strictTools")
        {
            Description = @"When set to `true`, tool calls in the Assistant message will be forced to follow the tool definition strictly. Learn more in the [Structured Outputs (Tools) guide](https://docs.cohere.com/docs/structured-outputs-json#structured-outputs-tools).

**Note**: The first few requests with a new set of tools will take longer to process.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.Document>>?> Documents { get; } = new(
            name: "documents")
        {
            Description = @"A list of relevant documents that the model can cite to generate a more accurate reply. Each document is either a string or document object with content and metadata.",
        };

        private global::System.CommandLine.Option<global::G.CitationOptions?> CitationOptions { get; } = new(
            name: "citationOptions")
        {
            Description = @"Options for controlling citation generation.",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormatV2?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/v2/docs/command-r), [Command R+](https://docs.cohere.com/v2/docs/command-r-plus) and newer models.

The model can be forced into outputting JSON objects by setting `{ ""type"": ""json_object"" }`.

A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.

**Note**: When using  `{ ""type"": ""json_object"" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _""Generate a JSON ...""_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.

**Note**: When `json_schema` is not specified, the generated object can have up to 5 layers of nesting.

**Limitation**: The parameter is not supported when used in combinations with the `documents` or `tools` parameters.",
        };

        private global::System.CommandLine.Option<global::G.Chatv2RequestSafetyMode?> SafetyMode { get; } = new(
            name: "safetyMode")
        {
            Description = @"Used to select the [safety instruction](https://docs.cohere.com/v2/docs/safety-modes) inserted into the prompt. Defaults to `CONTEXTUAL`.
When `OFF` is specified, the safety instruction will be omitted.

Safety modes are not yet configurable in combination with `tools` and `documents` parameters.

**Note**: This parameter is only compatible newer Cohere models, starting with [Command R 08-2024](https://docs.cohere.com/docs/command-r#august-2024-release) and [Command R+ 08-2024](https://docs.cohere.com/docs/command-r-plus#august-2024-release).

**Note**: `command-r7b-12-2024` and newer models only support `""CONTEXTUAL""` and `""STRICT""` modes.",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"The maximum number of tokens the model will generate as part of the response.

**Note**: Setting a low value may result in incomplete generations.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"A list of up to 5 strings that the model will use to stop generation. If the model generates a string that matches any of the strings in the list, it will stop generating tokens and return the generated text up to that point not including the stop sequence.",
        };

        private global::System.CommandLine.Option<float?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Defaults to `0.3`.

A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations, and higher temperatures mean more random generations.

Randomness can be further maximized by increasing the  value of the `p` parameter.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"If specified, the backend will make a best effort to sample tokens
deterministically, such that repeated requests with the same
seed and parameters should return the same result. However,
determinism cannot be totally guaranteed.",
        };

        private global::System.CommandLine.Option<float?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"Defaults to `0.0`, min value of `0.0`, max value of `1.0`.
Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.",
        };

        private global::System.CommandLine.Option<float?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"Defaults to `0.0`, min value of `0.0`, max value of `1.0`.
Used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.",
        };

        private global::System.CommandLine.Option<int?> K { get; } = new(
            name: "k")
        {
            Description = @"Ensures that only the top `k` most likely tokens are considered for generation at each step. When `k` is set to `0`, k-sampling is disabled.
Defaults to `0`, min value of `0`, max value of `500`.",
        };

        private global::System.CommandLine.Option<float?> P { get; } = new(
            name: "p")
        {
            Description = @"Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.
Defaults to `0.75`. min value of `0.01`, max value of `0.99`.",
        };

        private global::System.CommandLine.Option<bool?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = @"Defaults to `false`. When set to `true`, the log probabilities of the generated tokens will be included in the response.",
        };

        private global::System.CommandLine.Option<global::G.Chatv2RequestToolChoice?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"Used to control whether or not the model will be forced to use a tool when answering. When `REQUIRED` is specified, the model will be forced to use at least one of the user-defined tools, and the `tools` parameter must be passed in the request.
When `NONE` is specified, the model will be forced **not** to use one of the specified tools, and give a direct response.
If tool_choice isn't specified, then the model is free to choose whether to use the specified tools or not.

**Note**: This parameter is only compatible with models [Command-r7b](https://docs.cohere.com/v2/docs/command-r7b) and newer.

**Note**: The same functionality can be achieved in `/v1/chat` using the `force_single_step` parameter. If `force_single_step=true`, this is equivalent to specifying `REQUIRED`. While if `force_single_step=true` and `tool_results` are passed, this is equivalent to specifying `NONE`.",
        };
        public Chatv2Command(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "chatv2",
            description: @"Generates a text response to a user message and streams it down, token by token. To learn how to use the Chat API with streaming follow our [Text Generation guides](https://docs.cohere.com/v2/docs/chat-api).

Follow the [Migration Guide](https://docs.cohere.com/v2/docs/migrating-v1-to-v2) for instructions on moving from API v1 to API v2.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Options.Add(XClientName);
            Options.Add(Stream);
            Options.Add(ReasoningEffort);
            Options.Add(Tools);
            Options.Add(StrictTools);
            Options.Add(Documents);
            Options.Add(CitationOptions);
            Options.Add(ResponseFormat);
            Options.Add(SafetyMode);
            Options.Add(MaxTokens);
            Options.Add(StopSequences);
            Options.Add(Temperature);
            Options.Add(Seed);
            Options.Add(FrequencyPenalty);
            Options.Add(PresencePenalty);
            Options.Add(K);
            Options.Add(P);
            Options.Add(Logprobs);
            Options.Add(ToolChoice);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var stream = parseResult.GetRequiredValue(Stream);
            var model = parseResult.GetRequiredValue(Model);
            var messages = parseResult.GetRequiredValue(Messages);
            var reasoningEffort = parseResult.GetRequiredValue(ReasoningEffort);
            var tools = parseResult.GetRequiredValue(Tools);
            var strictTools = parseResult.GetRequiredValue(StrictTools);
            var documents = parseResult.GetRequiredValue(Documents);
            var citationOptions = parseResult.GetRequiredValue(CitationOptions);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var safetyMode = parseResult.GetRequiredValue(SafetyMode);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var stopSequences = parseResult.GetRequiredValue(StopSequences);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var seed = parseResult.GetRequiredValue(Seed);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var k = parseResult.GetRequiredValue(K);
            var p = parseResult.GetRequiredValue(P);
            var logprobs = parseResult.GetRequiredValue(Logprobs);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                stream: stream,
                model: model,
                messages: messages,
                reasoningEffort: reasoningEffort,
                tools: tools,
                strictTools: strictTools,
                documents: documents,
                citationOptions: citationOptions,
                responseFormat: responseFormat,
                safetyMode: safetyMode,
                maxTokens: maxTokens,
                stopSequences: stopSequences,
                temperature: temperature,
                seed: seed,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                k: k,
                p: p,
                logprobs: logprobs,
                toolChoice: toolChoice,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chatv2Async(
                xClientName: xClientName,
                stream: stream,
                model: model,
                messages: messages,
                reasoningEffort: reasoningEffort,
                tools: tools,
                strictTools: strictTools,
                documents: documents,
                citationOptions: citationOptions,
                responseFormat: responseFormat,
                safetyMode: safetyMode,
                maxTokens: maxTokens,
                stopSequences: stopSequences,
                temperature: temperature,
                seed: seed,
                frequencyPenalty: frequencyPenalty,
                presencePenalty: presencePenalty,
                k: k,
                p: p,
                logprobs: logprobs,
                toolChoice: toolChoice,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}