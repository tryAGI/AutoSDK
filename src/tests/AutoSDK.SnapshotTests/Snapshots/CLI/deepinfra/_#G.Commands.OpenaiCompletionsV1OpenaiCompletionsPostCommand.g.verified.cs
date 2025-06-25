//HintName: G.Commands.OpenaiCompletionsV1OpenaiCompletionsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiCompletionsV1OpenaiCompletionsPostCommand : global::System.CommandLine.Command
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
            string prompt,
            int? maxTokens,
            double? temperature,
            double? topP,
            double? minP,
            int? topK,
            int? n,
            bool? stream,
            int? logprobs,
            bool? echo,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop,
            double? presencePenalty,
            double? frequencyPenalty,
            global::G.ResponseFormat? responseFormat,
            double? repetitionPenalty,
            string? user,
            int? seed,
            global::G.StreamOptions? streamOptions,
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

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"input prompt - a single string is currently supported",
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

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"The maximum number of tokens to generate in the completion.

The total length of input tokens and generated tokens is limited by the model's context length.If explicitly set to None it will be the model's max context length minus input length or 16384, whichever is smaller.",
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

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"number of sequences to return",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"whether to stream the output via SSE or return the full response",
        };

        private global::System.CommandLine.Option<int?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = @"return top tokens and their log-probabilities",
        };

        private global::System.CommandLine.Option<bool?> Echo { get; } = new(
            name: "echo")
        {
            Description = @"return prompt as part of the respons",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"up to 16 sequences where the API will stop generating further tokens",
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

        private global::System.CommandLine.Option<global::G.ResponseFormat?> ResponseFormat { get; } = new(
            name: "responseFormat")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<double?> RepetitionPenalty { get; } = new(
            name: "repetitionPenalty")
        {
            Description = @"Alternative penalty for repetition, but multiplicative instead of additive (> 1 penalize, < 1 encourage)",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = @"A unique identifier representing your end-user, which can help  monitor and detect abuse. Avoid sending us any identifying information. We recommend hashing user identifiers.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"Seed for random number generator. If not provided, a random seed is used. Determinism is not guaranteed.",
        };

        private global::System.CommandLine.Option<global::G.StreamOptions?> StreamOptions { get; } = new(
            name: "streamOptions")
        {
            Description = @"",
        };
        public OpenaiCompletionsV1OpenaiCompletionsPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "openai",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Prompt);
            Options.Add(XDeepinfraSource);
            Options.Add(UserAgent);
            Options.Add(XiApiKey);
            Options.Add(MaxTokens);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(MinP);
            Options.Add(TopK);
            Options.Add(N);
            Options.Add(Stream);
            Options.Add(Logprobs);
            Options.Add(Echo);
            Options.Add(Stop);
            Options.Add(PresencePenalty);
            Options.Add(FrequencyPenalty);
            Options.Add(ResponseFormat);
            Options.Add(RepetitionPenalty);
            Options.Add(User);
            Options.Add(Seed);
            Options.Add(StreamOptions);

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
            var prompt = parseResult.GetRequiredValue(Prompt);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var minP = parseResult.GetRequiredValue(MinP);
            var topK = parseResult.GetRequiredValue(TopK);
            var n = parseResult.GetRequiredValue(N);
            var stream = parseResult.GetRequiredValue(Stream);
            var logprobs = parseResult.GetRequiredValue(Logprobs);
            var echo = parseResult.GetRequiredValue(Echo);
            var stop = parseResult.GetRequiredValue(Stop);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var responseFormat = parseResult.GetRequiredValue(ResponseFormat);
            var repetitionPenalty = parseResult.GetRequiredValue(RepetitionPenalty);
            var user = parseResult.GetRequiredValue(User);
            var seed = parseResult.GetRequiredValue(Seed);
            var streamOptions = parseResult.GetRequiredValue(StreamOptions);

            Validate(
                parseResult: parseResult,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                model: model,
                prompt: prompt,
                maxTokens: maxTokens,
                temperature: temperature,
                topP: topP,
                minP: minP,
                topK: topK,
                n: n,
                stream: stream,
                logprobs: logprobs,
                echo: echo,
                stop: stop,
                presencePenalty: presencePenalty,
                frequencyPenalty: frequencyPenalty,
                responseFormat: responseFormat,
                repetitionPenalty: repetitionPenalty,
                user: user,
                seed: seed,
                streamOptions: streamOptions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OpenaiCompletionsV1OpenaiCompletionsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                model: model,
                prompt: prompt,
                maxTokens: maxTokens,
                temperature: temperature,
                topP: topP,
                minP: minP,
                topK: topK,
                n: n,
                stream: stream,
                logprobs: logprobs,
                echo: echo,
                stop: stop,
                presencePenalty: presencePenalty,
                frequencyPenalty: frequencyPenalty,
                responseFormat: responseFormat,
                repetitionPenalty: repetitionPenalty,
                user: user,
                seed: seed,
                streamOptions: streamOptions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}