//HintName: G.Commands.GenerateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            global::System.Collections.Generic.IList<string> endSequences,
            double frequencyPenalty,
            int k,
            int maxTokens,
            string model,
            int numGenerations,
            double p,
            double presencePenalty,
            string preset,
            string prompt,
            bool? rawPrompting,
            global::G.GenerateRequestReturnLikelihoods? returnLikelihoods,
            int? seed,
            global::System.Collections.Generic.IList<string> stopSequences,
            bool? stream,
            double temperature,
            global::G.GenerateRequestTruncate truncate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Generation response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> EndSequences { get; } = new(
            name: "endSequences")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<double> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> K { get; } = new(
            name: "k")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> NumGenerations { get; } = new(
            name: "numGenerations")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<double> P { get; } = new(
            name: "p")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<double> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Preset { get; } = new(
            name: "preset")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<double> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.GenerateRequestTruncate> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> RawPrompting { get; } = new(
            name: "rawPrompting")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.GenerateRequestReturnLikelihoods?> ReturnLikelihoods { get; } = new(
            name: "returnLikelihoods")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"",
        };
        public GenerateCommand(G.IApi client) : base(
            name: "generate",
            description: @"<Warning>
This API is marked as ""Legacy"" and is no longer maintained. Follow the [migration guide](https://docs.cohere.com/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.
</Warning>
Generates realistic text conditioned on a given input.")
        {
            _client = client;

            Arguments.Add(EndSequences);
            Arguments.Add(FrequencyPenalty);
            Arguments.Add(K);
            Arguments.Add(MaxTokens);
            Arguments.Add(Model);
            Arguments.Add(NumGenerations);
            Arguments.Add(P);
            Arguments.Add(PresencePenalty);
            Arguments.Add(Preset);
            Arguments.Add(Prompt);
            Arguments.Add(StopSequences);
            Arguments.Add(Temperature);
            Arguments.Add(Truncate);
            Options.Add(XClientName);
            Options.Add(RawPrompting);
            Options.Add(ReturnLikelihoods);
            Options.Add(Seed);
            Options.Add(Stream);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var endSequences = parseResult.GetRequiredValue(EndSequences);
            var frequencyPenalty = parseResult.GetRequiredValue(FrequencyPenalty);
            var k = parseResult.GetRequiredValue(K);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var model = parseResult.GetRequiredValue(Model);
            var numGenerations = parseResult.GetRequiredValue(NumGenerations);
            var p = parseResult.GetRequiredValue(P);
            var presencePenalty = parseResult.GetRequiredValue(PresencePenalty);
            var preset = parseResult.GetRequiredValue(Preset);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var rawPrompting = parseResult.GetRequiredValue(RawPrompting);
            var returnLikelihoods = parseResult.GetRequiredValue(ReturnLikelihoods);
            var seed = parseResult.GetRequiredValue(Seed);
            var stopSequences = parseResult.GetRequiredValue(StopSequences);
            var stream = parseResult.GetRequiredValue(Stream);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var truncate = parseResult.GetRequiredValue(Truncate);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                endSequences: endSequences,
                frequencyPenalty: frequencyPenalty,
                k: k,
                maxTokens: maxTokens,
                model: model,
                numGenerations: numGenerations,
                p: p,
                presencePenalty: presencePenalty,
                preset: preset,
                prompt: prompt,
                rawPrompting: rawPrompting,
                returnLikelihoods: returnLikelihoods,
                seed: seed,
                stopSequences: stopSequences,
                stream: stream,
                temperature: temperature,
                truncate: truncate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GenerateAsync(
                xClientName: xClientName,
                endSequences: endSequences,
                frequencyPenalty: frequencyPenalty,
                k: k,
                maxTokens: maxTokens,
                model: model,
                numGenerations: numGenerations,
                p: p,
                presencePenalty: presencePenalty,
                preset: preset,
                prompt: prompt,
                rawPrompting: rawPrompting,
                returnLikelihoods: returnLikelihoods,
                seed: seed,
                stopSequences: stopSequences,
                stream: stream,
                temperature: temperature,
                truncate: truncate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}