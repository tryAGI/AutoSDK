//HintName: G.Commands.OpenaiChatCompletionsV1OpenaiChatCompletionsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiChatCompletionsV1OpenaiChatCompletionsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xDeepinfraSource,
            string? userAgent,
            string? xiApiKey,
            string model,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionToolMessage, global::G.ChatCompletionAssistantMessage, global::G.ChatCompletionUserMessage, global::G.ChatCompletionSystemMessage>> messages,
            bool? stream,
            double? temperature,
            double? topP,
            double? minP,
            int? topK,
            int? maxTokens,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop,
            int? n,
            double? presencePenalty,
            double? frequencyPenalty,
            global::System.Collections.Generic.IList<global::G.ChatTools>? tools,
            string? toolChoice,
            global::G.ResponseFormat? responseFormat,
            double? repetitionPenalty,
            string? user,
            int? seed,
            bool? logprobs,
            global::G.StreamOptions? streamOptions,
            global::G.OpenAIChatCompletionsInReasoningEffort2? reasoningEffort,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"model name",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionToolMessage, global::G.ChatCompletionAssistantMessage, global::G.ChatCompletionUserMessage, global::G.ChatCompletionSystemMessage>>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"conversation messages: (user,assistant,tool)*,user including one system message anywhere",
        };

        private global::System.CommandLine.Option<string?> XDeepinfraSource { get; } = new(
            name: "xDeepinfraSource")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> UserAgent { get; } = new(
            name: "userAgent")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"whether to stream the output via SSE or return the full response",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.",
        };

        private global::System.CommandLine.Option<double?> MinP { get; } = new(
            name: "minP")
        {
            Description = @"Float that represents the minimum probability for a token to be considered, relative to the probability of the most likely token. Must be in [0, 1]. Set to 0 to disable this.",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"Sample from the best k (number of) tokens. 0 means off",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"The maximum number of tokens to generate in the chat completion.

The total length of input tokens and generated tokens is limited by the model's context length. If explicitly set to None it will be the model's max context length minus input length or 16384, whichever is smaller.",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"up to 16 sequences where the API will stop generating further tokens",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"number of sequences to return",
        };

        private global::System.CommandLine.Option<double?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"Positive values penalize new tokens based on whether they appear in the text so far, increasing the model's likelihood to talk about new topics.",
        };

        private global::System.CommandLine.Option<double?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"Positive values penalize new tokens based on how many times they appear in the text so far, increasing the model's likelihood to talk about new topics.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatTools>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"A list of tools the model may call. Currently, only functions are supported as a tool.",
        };

        private global::System.CommandLine.Option<string?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"Controls which (if any) function is called by the model. none means the model will not call a function and instead generates a message. auto means the model can pick between generating a message or calling a function. specifying a particular function choice is not supported currently.none is the default when no functions are present. auto is the default if functions are present.",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"The format of the response. Currently, only json is supported.",
        };

        private global::System.CommandLine.Option<double?> RepetitionPenalty { get; } = new(
            name: "repetitionPenalty")
        {
            Description = @"Alternative penalty for repetition, but multiplicative instead of additive (> 1 penalize, < 1 encourage)",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = @"A unique identifier representing your end-user, which can help monitor and detect abuse. Avoid sending us any identifying information. We recommend hashing user identifiers.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Seed for random number generator. If not provided, a random seed is used. Determinism is not guaranteed.",
        };

        private global::System.CommandLine.Option<bool?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = @"Whether to return log probabilities of the output tokens or not.If true, returns the log probabilities of each output token returned in the `content` of `message`.",
        };

        private global::System.CommandLine.Option<global::G.StreamOptions?> StreamOptions { get; } = new(
            name: "streamOptions")
        {
            Description = @"streaming options",
        };

        private global::System.CommandLine.Option<global::G.OpenAIChatCompletionsInReasoningEffort2?> ReasoningEffort { get; } = new(
            name: "reasoningEffort")
        {
            Description = @"Constrains effort on reasoning for reasoning models. Currently supported values are none, low, medium, and high. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Setting to none disables reasoning entirely if the model supports.",
        };
        public OpenaiChatCompletionsV1OpenaiChatCompletionsPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "openai",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Options.Add(XDeepinfraSource);
            Options.Add(UserAgent);
            Options.Add(XiApiKey);
            Options.Add(Stream);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(MinP);
            Options.Add(TopK);
            Options.Add(MaxTokens);
            Options.Add(Stop);
            Options.Add(N);
            Options.Add(PresencePenalty);
            Options.Add(FrequencyPenalty);
            Options.Add(Tools);
            Options.Add(ToolChoice);
            Options.Add(ResponseFormat);
            Options.Add(RepetitionPenalty);
            Options.Add(User);
            Options.Add(Seed);
            Options.Add(Logprobs);
            Options.Add(StreamOptions);
            Options.Add(ReasoningEffort);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xDeepinfraSource = parseResult.GetRequiredValue(XDeepinfraSource);
            var userAgent = parseResult.GetRequiredValue(UserAgent);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var model = parseResult.GetRequiredValue(Model);
            var messages = parseResult.GetRequiredValue(Messages);
            var stream = parseResult.GetRequiredValue(Stream);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var minP = parseResult.GetRequiredValue(MinP);
            var topK = parseResult.GetRequiredValue(TopK);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var stop = parseResult.GetRequiredValue(Stop);
            var n = parseResult.GetRequiredValue(N);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var tools = parseResult.GetRequiredValue(Tools);
            var toolChoice = parseResult.GetRequiredValue(ToolChoice);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var repetitionPenalty = parseResult.GetRequiredValue(RepetitionPenalty);
            var user = parseResult.GetRequiredValue(User);
            var seed = parseResult.GetRequiredValue(Seed);
            var logprobs = parseResult.GetRequiredValue(Logprobs);
            var streamOptions = parseResult.GetRequiredValue(StreamOptions);
            var reasoningEffort = parseResult.GetRequiredValue(ReasoningEffort);

            Validate(
                parseResult: parseResult,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                model: model,
                messages: messages,
                stream: stream,
                temperature: temperature,
                topP: topP,
                minP: minP,
                topK: topK,
                maxTokens: maxTokens,
                stop: stop,
                n: n,
                presencePenalty: presencePenalty,
                frequencyPenalty: frequencyPenalty,
                tools: tools,
                toolChoice: toolChoice,
                responseFormat: responseFormat,
                repetitionPenalty: repetitionPenalty,
                user: user,
                seed: seed,
                logprobs: logprobs,
                streamOptions: streamOptions,
                reasoningEffort: reasoningEffort,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OpenaiChatCompletionsV1OpenaiChatCompletionsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                model: model,
                messages: messages,
                stream: stream,
                temperature: temperature,
                topP: topP,
                minP: minP,
                topK: topK,
                maxTokens: maxTokens,
                stop: stop,
                n: n,
                presencePenalty: presencePenalty,
                frequencyPenalty: frequencyPenalty,
                tools: tools,
                toolChoice: toolChoice,
                responseFormat: responseFormat,
                repetitionPenalty: repetitionPenalty,
                user: user,
                seed: seed,
                logprobs: logprobs,
                streamOptions: streamOptions,
                reasoningEffort: reasoningEffort,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}