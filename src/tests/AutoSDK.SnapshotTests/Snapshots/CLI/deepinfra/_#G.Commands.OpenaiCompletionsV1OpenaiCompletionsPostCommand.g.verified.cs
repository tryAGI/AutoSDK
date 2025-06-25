//HintName: G.Commands.OpenaiCompletionsV1OpenaiCompletionsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiCompletionsV1OpenaiCompletionsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
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

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
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

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Echo { get; } = new(
            name: "echo")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
            name: "stop")
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

        private global::System.CommandLine.Option<global::G.StreamOptions?> StreamOptions { get; } = new(
            name: "streamOptions")
        {
            Description = @"",
        };
        public OpenaiCompletionsV1OpenaiCompletionsPostCommand(G.IApi client) : base(
            name: "openai",
            description: @"")
        {
            _client = client;

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