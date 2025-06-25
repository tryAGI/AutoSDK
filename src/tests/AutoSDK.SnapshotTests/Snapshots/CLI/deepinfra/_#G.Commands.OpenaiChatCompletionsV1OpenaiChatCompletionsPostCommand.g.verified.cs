//HintName: G.Commands.OpenaiChatCompletionsV1OpenaiChatCompletionsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiChatCompletionsV1OpenaiChatCompletionsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop,
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
            global::G.OpenAIChatCompletionsInReasoningEffort? reasoningEffort,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionToolMessage, global::G.ChatCompletionAssistantMessage, global::G.ChatCompletionUserMessage, global::G.ChatCompletionSystemMessage>>> Messages { get; } = new(
            name: "messages")
        {
            Description = @"",
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
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> MinP { get; } = new(
            name: "minP")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ChatTools>?> Tools { get; } = new(
            name: "tools")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ToolChoice { get; } = new(
            name: "toolChoice")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> RepetitionPenalty { get; } = new(
            name: "repetitionPenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.StreamOptions?> StreamOptions { get; } = new(
            name: "streamOptions")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OpenAIChatCompletionsInReasoningEffort?> ReasoningEffort { get; } = new(
            name: "reasoningEffort")
        {
            Description = @"",
        };
        public OpenaiChatCompletionsV1OpenaiChatCompletionsPostCommand(G.IApi client) : base(
            name: "openai",
            description: @"")
        {
            _client = client;

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