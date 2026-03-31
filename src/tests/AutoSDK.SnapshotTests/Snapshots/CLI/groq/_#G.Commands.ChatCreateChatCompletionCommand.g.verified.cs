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
            global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> messages,
            global::G.AnyOf<string, global::G.CreateChatCompletionRequestModel?> model,
            bool? disableToolValidation,
            double? frequencyPenalty,
            bool? includeReasoning,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias,
            bool? logprobs,
            int? topLogprobs,
            int? maxCompletionTokens,
            int? n,
            double? presencePenalty,
            global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>? responseFormat,
            int? seed,
            global::G.CreateChatCompletionRequestServiceTier? serviceTier,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            global::G.CreateChatCompletionRequestReasoningEffort? reasoningEffort,
            global::G.CreateChatCompletionRequestReasoningFormat? reasoningFormat,
            bool? stream,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools,
            global::G.ChatCompletionToolChoiceOption? toolChoice,
            bool? parallelToolCalls,
            string? user,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            bool? store,
            global::G.CreateChatCompletionRequestSearchSettings? searchSettings,
            global::G.CreateChatCompletionRequestCompoundCustom? compoundCustom,
            global::System.Collections.Generic.IList<global::G.ChatCompletionDocument>? documents,
            global::G.CreateChatCompletionRequestCitationOptions? citationOptions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreateChatCompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"A list of messages comprising the conversation so far.",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateChatCompletionRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = @"ID of the model to use. For details on which models are compatible with the Chat API, see available [models](https://console.groq.com/docs/models)",
        };

        private global::System.CommandLine.Option<bool?> DisableToolValidation { get; } = new(
            name: "disableToolValidation")
        {
            Description = @"If set to true, groq will return called tools without validating that the tool is present in request.tools. tool_choice=required/none will still be enforced, but the request cannot require a specific tool be used.",
        };

        private global::System.CommandLine.Option<double?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"This is not yet supported by any of our models. Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model's likelihood to repeat the same line verbatim.",
        };

        private global::System.CommandLine.Option<bool?> IncludeReasoning { get; } = new(
            name: "includeReasoning")
        {
            Description = @"Whether to include reasoning in the response.  If true, the response will include a `reasoning` field. If false, the model's reasoning will not be included in the response.
This field is mutually exclusive with `reasoning_format`.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, int>?> LogitBias { get; } = new(
            name: "logitBias")
        {
            Description = @"This is not yet supported by any of our models.
Modify the likelihood of specified tokens appearing in the completion.",
        };

        private global::System.CommandLine.Option<bool?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = @"This is not yet supported by any of our models.
Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`.",
        };

        private global::System.CommandLine.Option<int?> TopLogprobs { get; } = new(
            name: "topLogprobs")
        {
            Description = @"This is not yet supported by any of our models.
An integer between 0 and 20 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used.",
        };

        private global::System.CommandLine.Option<int?> MaxCompletionTokens { get; } = new(
            name: "maxCompletionTokens")
        {
            Description = @"The maximum number of tokens that can be generated in the chat completion. The total length of input tokens and generated tokens is limited by the model's context length.",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"How many chat completion choices to generate for each input message. Note that the current moment, only n=1 is supported. Other values will result in a 400 response.",
        };

        private global::System.CommandLine.Option<double?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"This is not yet supported by any of our models. Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.",
        };

        private global::System.CommandLine.Option<global::G.OneOf<global::G.ResponseFormatText, global::G.ResponseFormatJsonSchema, global::G.ResponseFormatJsonObject>?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"An object specifying the format that the model must output. Setting to `{ ""type"": ""json_schema"", ""json_schema"": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. `json_schema` response format is only available on [supported models](https://console.groq.com/docs/structured-outputs#supported-models). Setting to `{ ""type"": ""json_object"" }` enables the older JSON mode, which ensures the message the model generates is valid JSON. Using `json_schema` is preferred for models that support it.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.
Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.",
        };

        private global::System.CommandLine.Option<global::G.CreateChatCompletionRequestServiceTier?> ServiceTier { get; } = new(
            name: "serviceTier")
        {
            Description = @"The service tier to use for the request. Defaults to `on_demand`.
- `auto` will automatically select the highest tier available within the rate limits of your organization.
- `flex` uses the flex tier, which will succeed or fail quickly.",
        };

        private global::System.CommandLine.Option<global::G.OneOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.",
        };

        private global::System.CommandLine.Option<global::G.CreateChatCompletionRequestReasoningEffort?> ReasoningEffort { get; } = new(
            name: "reasoningEffort")
        {
            Description = @"qwen3 models support the following values
Set to 'none' to disable reasoning.
Set to 'default' or null to let Qwen reason.

openai/gpt-oss-20b and openai/gpt-oss-120b support 'low', 'medium', or 'high'.
'medium' is the default value.",
        };

        private global::System.CommandLine.Option<global::G.CreateChatCompletionRequestReasoningFormat?> ReasoningFormat { get; } = new(
            name: "reasoningFormat")
        {
            Description = @"Specifies how to output reasoning tokens
This field is mutually exclusive with `include_reasoning`.",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"If set, partial message deltas will be sent. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example code](/docs/text-chat#streaming-a-chat-completion).",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or top_p but not both.",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or temperature but not both.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatCompletionTool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported.",
        };

        private global::System.CommandLine.Option<global::G.ChatCompletionToolChoiceOption?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"Controls which (if any) tool is called by the model.
`none` means the model will not call any tool and instead generates a message.
`auto` means the model can pick between generating a message or calling one or more tools.
`required` means the model must call one or more tools.
Specifying a particular tool via `{""type"": ""function"", ""function"": {""name"": ""my_function""}}` forces the model to call that tool.

`none` is the default when no tools are present. `auto` is the default if tools are present.",
        };

        private global::System.CommandLine.Option<bool?> ParallelToolCalls { get; } = new(
            name: "parallelToolCalls")
        {
            Description = @"Whether to enable parallel function calling during tool use.",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = @"A unique identifier representing your end-user, which can help us monitor and detect abuse.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = @"This parameter is not currently supported.",
        };

        private global::System.CommandLine.Option<bool?> Store { get; } = new(
            name: "store")
        {
            Description = @"This parameter is not currently supported.",
        };

        private global::System.CommandLine.Option<global::G.CreateChatCompletionRequestSearchSettings?> SearchSettings { get; } = new(
            name: "searchSettings")
        {
            Description = @"Settings for web search functionality when the model uses a web search tool.",
        };

        private global::System.CommandLine.Option<global::G.CreateChatCompletionRequestCompoundCustom?> CompoundCustom { get; } = new(
            name: "compoundCustom")
        {
            Description = @"Custom configuration of models and tools for Compound.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatCompletionDocument>?> Documents { get; } = new(
            name: "documents")
        {
            Description = @"A list of documents to provide context for the conversation. Each document contains text that can be referenced by the model.",
        };

        private global::System.CommandLine.Option<global::G.CreateChatCompletionRequestCitationOptions?> CitationOptions { get; } = new(
            name: "citationOptions")
        {
            Description = @"Whether to enable citations in the response. When enabled, the model will include citations for information retrieved from provided documents or web searches.",
        };


        public ChatCreateChatCompletionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Messages);
            Arguments.Add(Model);
            Options.Add(DisableToolValidation);
            Options.Add(FrequencyPenalty);
            Options.Add(IncludeReasoning);
            Options.Add(LogitBias);
            Options.Add(Logprobs);
            Options.Add(TopLogprobs);
            Options.Add(MaxCompletionTokens);
            Options.Add(N);
            Options.Add(PresencePenalty);
            Options.Add(ResponseFormat);
            Options.Add(Seed);
            Options.Add(ServiceTier);
            Options.Add(Stop);
            Options.Add(ReasoningEffort);
            Options.Add(ReasoningFormat);
            Options.Add(Stream);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(Tools);
            Options.Add(ToolChoice);
            Options.Add(ParallelToolCalls);
            Options.Add(User);
            Options.Add(Metadata);
            Options.Add(Store);
            Options.Add(SearchSettings);
            Options.Add(CompoundCustom);
            Options.Add(Documents);
            Options.Add(CitationOptions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var messages = parseResult.GetRequiredValue(Messages);
            var model = parseResult.GetRequiredValue(Model);
            var disableToolValidation = parseResult.GetRequiredValue(DisableToolValidation);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var includeReasoning = parseResult.GetRequiredValue(IncludeReasoning);
            var logitBias = parseResult.GetRequiredValue(LogitBias);
            var logprobs = parseResult.GetRequiredValue(Logprobs);
            var topLogprobs = parseResult.GetRequiredValue(TopLogprobs);
            var maxCompletionTokens = parseResult.GetRequiredValue(MaxCompletionTokens);
            var n = parseResult.GetRequiredValue(N);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var seed = parseResult.GetRequiredValue(Seed);
            var serviceTier = parseResult.GetRequiredValue(ServiceTier);
            var stop = parseResult.GetRequiredValue(Stop);
            var reasoningEffort = parseResult.GetRequiredValue(ReasoningEffort);
            var reasoningFormat = parseResult.GetRequiredValue(ReasoningFormat);
            var stream = parseResult.GetRequiredValue(Stream);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var parallelToolCalls = parseResult.GetRequiredValue(ParallelToolCalls);
            var user = parseResult.GetRequiredValue(User);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var store = parseResult.GetRequiredValue(Store);
            var searchSettings = parseResult.GetRequiredValue(SearchSettings);
            var compoundCustom = parseResult.GetRequiredValue(CompoundCustom);
            var documents = parseResult.GetRequiredValue(Documents);
            var citationOptions = parseResult.GetRequiredValue(CitationOptions);

            Validate(
                parseResult: parseResult,
                messages: messages,
                model: model,
                disableToolValidation: disableToolValidation,
                frequencyPenalty: frequencyPenalty,
                includeReasoning: includeReasoning,
                logitBias: logitBias,
                logprobs: logprobs,
                topLogprobs: topLogprobs,
                maxCompletionTokens: maxCompletionTokens,
                n: n,
                presencePenalty: presencePenalty,
                responseFormat: responseFormat,
                seed: seed,
                serviceTier: serviceTier,
                stop: stop,
                reasoningEffort: reasoningEffort,
                reasoningFormat: reasoningFormat,
                stream: stream,
                temperature: temperature,
                topP: topP,
                tools: tools,
                toolChoice: toolChoice,
                parallelToolCalls: parallelToolCalls,
                user: user,
                metadata: metadata,
                store: store,
                searchSettings: searchSettings,
                compoundCustom: compoundCustom,
                documents: documents,
                citationOptions: citationOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.CreateChatCompletionAsync(
                messages: messages,
                model: model,
                disableToolValidation: disableToolValidation,
                frequencyPenalty: frequencyPenalty,
                includeReasoning: includeReasoning,
                logitBias: logitBias,
                logprobs: logprobs,
                topLogprobs: topLogprobs,
                maxCompletionTokens: maxCompletionTokens,
                n: n,
                presencePenalty: presencePenalty,
                responseFormat: responseFormat,
                seed: seed,
                serviceTier: serviceTier,
                stop: stop,
                reasoningEffort: reasoningEffort,
                reasoningFormat: reasoningFormat,
                stream: stream,
                temperature: temperature,
                topP: topP,
                tools: tools,
                toolChoice: toolChoice,
                parallelToolCalls: parallelToolCalls,
                user: user,
                metadata: metadata,
                store: store,
                searchSettings: searchSettings,
                compoundCustom: compoundCustom,
                documents: documents,
                citationOptions: citationOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}