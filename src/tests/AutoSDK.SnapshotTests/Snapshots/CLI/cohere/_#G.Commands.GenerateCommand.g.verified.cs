//HintName: G.Commands.GenerateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The generated text will be cut at the beginning of the earliest occurrence of an end sequence. The sequence will be excluded from the text.",
        };

        private global::System.CommandLine.Argument<double> FrequencyPenalty { get; } = new(
            name: "frequencyPenalty")
        {
            Description = @"Used to reduce repetitiveness of generated tokens. The higher the value, the stronger a penalty is applied to previously present tokens, proportional to how many times they have already appeared in the prompt or prior generation.

Using `frequency_penalty` in combination with `presence_penalty` is not supported on newer models.",
        };

        private global::System.CommandLine.Argument<int> K { get; } = new(
            name: "k")
        {
            Description = @"Ensures only the top `k` most likely tokens are considered for generation at each step.
Defaults to `0`, min value of `0`, max value of `500`.",
        };

        private global::System.CommandLine.Argument<int> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"The maximum number of tokens the model will generate as part of the response. Note: Setting a low value may result in incomplete generations.

This parameter is off by default, and if it's not specified, the model will continue generating until it emits an EOS completion token. See [BPE Tokens](/bpe-tokens-wiki) for more details.

Can only be set to `0` if `return_likelihoods` is set to `ALL` to get the likelihood of the prompt.",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The identifier of the model to generate with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental).
Smaller, ""light"" models are faster, while larger models will perform better. [Custom models](https://docs.cohere.com/docs/training-custom-models) can also be supplied with their full ID.",
        };

        private global::System.CommandLine.Argument<int> NumGenerations { get; } = new(
            name: "numGenerations")
        {
            Description = @"The maximum number of generations that will be returned. Defaults to `1`, min value of `1`, max value of `5`.",
        };

        private global::System.CommandLine.Argument<double> P { get; } = new(
            name: "p")
        {
            Description = @"Ensures that only the most likely tokens, with total probability mass of `p`, are considered for generation at each step. If both `k` and `p` are enabled, `p` acts after `k`.
Defaults to `0.75`. min value of `0.01`, max value of `0.99`.",
        };

        private global::System.CommandLine.Argument<double> PresencePenalty { get; } = new(
            name: "presencePenalty")
        {
            Description = @"Defaults to `0.0`, min value of `0.0`, max value of `1.0`.

Can be used to reduce repetitiveness of generated tokens. Similar to `frequency_penalty`, except that this penalty is applied equally to all tokens that have already appeared, regardless of their exact frequencies.

Using `frequency_penalty` in combination with `presence_penalty` is not supported on newer models.",
        };

        private global::System.CommandLine.Argument<string> Preset { get; } = new(
            name: "preset")
        {
            Description = @"Identifier of a custom preset. A preset is a combination of parameters, such as prompt, temperature etc. You can create presets in the [playground](https://dashboard.cohere.com/playground/generate).
When a preset is specified, the `prompt` parameter becomes optional, and any included parameters will override the preset's parameters.",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The input text that serves as the starting point for generating the response.
Note: The prompt will be pre-processed and modified before reaching the model.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> StopSequences { get; } = new(
            name: "stopSequences")
        {
            Description = @"The generated text will be cut at the end of the earliest occurrence of a stop sequence. The sequence will be included the text.",
        };

        private global::System.CommandLine.Argument<double> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"A non-negative float that tunes the degree of randomness in generation. Lower temperatures mean less random generations. See [Temperature](/temperature-wiki) for more details.
Defaults to `0.75`, min value of `0.0`, max value of `5.0`.",
        };

        private global::System.CommandLine.Argument<global::G.GenerateRequestTruncate> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.

Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.

If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<bool?> RawPrompting { get; } = new(
            name: "rawPrompting")
        {
            Description = @"When enabled, the user's prompt will be sent to the model without any pre-processing.",
        };

        private global::System.CommandLine.Option<global::G.GenerateRequestReturnLikelihoods?> ReturnLikelihoods { get; } = new(
            name: "returnLikelihoods")
        {
            Description = @"One of `GENERATION|NONE` to specify how and if the token likelihoods are returned with the response. Defaults to `NONE`.

If `GENERATION` is selected, the token likelihoods will only be provided for generated text.

WARNING: `ALL` is deprecated, and will be removed in a future release.",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = @"If specified, the backend will make a best effort to sample tokens
deterministically, such that repeated requests with the same
seed and parameters should return the same result. However,
determinism cannot be totally guaranteed.
Compatible Deployments: Cohere Platform, Azure, AWS Sagemaker/Bedrock, Private Deployments",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = @"When `true`, the response will be a JSON stream of events. Streaming is beneficial for user interfaces that render the contents of the response piece by piece, as it gets generated.

The final event will contain the complete response, and will contain an `is_finished` field set to `true`. The event will also contain a `finish_reason`, which can be one of the following:
- `COMPLETE` - the model sent back a finished reply
- `MAX_TOKENS` - the reply was cut off because the model reached the maximum number of tokens for its context length
- `ERROR` - something went wrong when generating the reply
- `ERROR_TOXIC` - the model generated a reply that was deemed toxic",
        };
        public GenerateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "generate",
            description: @"<Warning>
This API is marked as ""Legacy"" and is no longer maintained. Follow the [migration guide](https://docs.cohere.com/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.
</Warning>
Generates realistic text conditioned on a given input.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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