//HintName: G.Commands.CreateCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateCompletionCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::G.CreateCompletionRequestModel?> model,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? prompt,
            int? bestOf,
            bool? echo,
            double? frequencyPenalty,
            global::System.Collections.Generic.Dictionary<string, int>? logitBias,
            int? logprobs,
            int? maxTokens,
            int? n,
            double? presencePenalty,
            long? seed,
            global::G.StopConfiguration? stop,
            bool? stream,
            global::G.ChatCompletionStreamOptions? streamOptions,
            string? suffix,
            double? temperature,
            double? topP,
            string? user,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateCompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateCompletionRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> BestOf { get; } = new(
            name: "bestOf")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Echo { get; } = new(
            name: "echo")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, int>?> LogitBias { get; } = new(
            name: "logitBias")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Logprobs { get; } = new(
            name: "logprobs")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> N { get; } = new(
            name: "n")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> Seed { get; } = new(
            name: "seed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.StopConfiguration?> Stop { get; } = new(
            name: "stop")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ChatCompletionStreamOptions?> StreamOptions { get; } = new(
            name: "streamOptions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Suffix { get; } = new(
            name: "suffix")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> User { get; } = new(
            name: "user")
        {
            Description = "",
        };
        public CreateCompletionCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Prompt);
            Options.Add(BestOf);
            Options.Add(Echo);
            Options.Add(FrequencyPenalty);
            Options.Add(LogitBias);
            Options.Add(Logprobs);
            Options.Add(MaxTokens);
            Options.Add(N);
            Options.Add(PresencePenalty);
            Options.Add(Seed);
            Options.Add(Stop);
            Options.Add(Stream);
            Options.Add(StreamOptions);
            Options.Add(Suffix);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(User);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var bestOf = parseResult.GetRequiredValue(BestOf);
            var echo = parseResult.GetRequiredValue(Echo);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var logitBias = parseResult.GetRequiredValue(LogitBias);
            var logprobs = parseResult.GetRequiredValue(Logprobs);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var n = parseResult.GetRequiredValue(N);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var seed = parseResult.GetRequiredValue(Seed);
            var stop = parseResult.GetRequiredValue(Stop);
            var stream = parseResult.GetRequiredValue(Stream);
            var streamOptions = parseResult.GetRequiredValue(StreamOptions);
            var suffix = parseResult.GetRequiredValue(Suffix);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var user = parseResult.GetRequiredValue(User);

            Validate(
                parseResult: parseResult,
                model: model,
                prompt: prompt,
                bestOf: bestOf,
                echo: echo,
                frequencyPenalty: frequencyPenalty,
                logitBias: logitBias,
                logprobs: logprobs,
                maxTokens: maxTokens,
                n: n,
                presencePenalty: presencePenalty,
                seed: seed,
                stop: stop,
                stream: stream,
                streamOptions: streamOptions,
                suffix: suffix,
                temperature: temperature,
                topP: topP,
                user: user,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Completions.CreateCompletionAsync(
                model: model,
                prompt: prompt,
                bestOf: bestOf,
                echo: echo,
                frequencyPenalty: frequencyPenalty,
                logitBias: logitBias,
                logprobs: logprobs,
                maxTokens: maxTokens,
                n: n,
                presencePenalty: presencePenalty,
                seed: seed,
                stop: stop,
                stream: stream,
                streamOptions: streamOptions,
                suffix: suffix,
                temperature: temperature,
                topP: topP,
                user: user,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}