//HintName: G.Commands.GenerationApiCompletionsAsStreamCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerationApiCompletionsAsStreamCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            string prompt,
            long? maxTokens,
            double? temperature,
            double? topP,
            global::G.OneOf<global::System.Collections.Generic.IList<string>, string>? stop,
            int? bestOf,
            int? randomSeed,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IAsyncEnumerable<global::G.StreamingData> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The [ID of the model](https://dev.writer.com/home/models) to use for generating text. Supports `palmyra-x5`, `palmyra-x4`, `palmyra-fin`, `palmyra-med`, `palmyra-creative`, and `palmyra-x-003-instruct`.",
        };

        private global::System.CommandLine.Argument<string> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The input text that the model will process to generate a response.",
        };

        private global::System.CommandLine.Option<long?> MaxTokens { get; } = new(
            name: "maxTokens")
        {
            Description = @"The maximum number of tokens that the model can generate in the response.",
        };

        private global::System.CommandLine.Option<double?> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Controls the randomness of the model's outputs. Higher values lead to more random outputs, while lower values make the model more deterministic.",
        };

        private global::System.CommandLine.Option<double?> TopP { get; } = new(
            name: "topP")
        {
            Description = @"Used to control the nucleus sampling, where only the most probable tokens with a cumulative probability of top_p are considered for sampling, providing a way to fine-tune the randomness of predictions.",
        };

        private global::System.CommandLine.Option<global::G.OneOf<global::System.Collections.Generic.IList<string>, string>?> Stop { get; } = new(
            name: "stop")
        {
            Description = @"Specifies stopping conditions for the model's output generation. This can be an array of strings or a single string that the model will look for as a signal to stop generating further tokens.",
        };

        private global::System.CommandLine.Option<int?> BestOf { get; } = new(
            name: "bestOf")
        {
            Description = @"Specifies the number of completions to generate and return the best one. Useful for generating multiple outputs and choosing the best based on some criteria.",
        };

        private global::System.CommandLine.Option<int?> RandomSeed { get; } = new(
            name: "randomSeed")
        {
            Description = @"A seed used to initialize the random number generator for the model, ensuring reproducibility of the output when the same inputs are provided.",
        };


        public GenerationApiCompletionsAsStreamCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "completions",
            description: @"Generate text completions using the specified model and prompt. This endpoint is useful for text generation tasks that don't require conversational context.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Prompt);
            Options.Add(MaxTokens);
            Options.Add(Temperature);
            Options.Add(TopP);
            Options.Add(Stop);
            Options.Add(BestOf);
            Options.Add(RandomSeed);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var maxTokens = parseResult.GetRequiredValue(MaxTokens);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var topP = parseResult.GetRequiredValue(TopP);
            var stop = parseResult.GetRequiredValue(Stop);
            var bestOf = parseResult.GetRequiredValue(BestOf);
            var randomSeed = parseResult.GetRequiredValue(RandomSeed);

            Validate(
                parseResult: parseResult,
                model: model,
                prompt: prompt,
                maxTokens: maxTokens,
                temperature: temperature,
                topP: topP,
                stop: stop,
                bestOf: bestOf,
                randomSeed: randomSeed,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = _client.GenerationApi.CompletionsAsStreamAsync(
                model: model,
                prompt: prompt,
                maxTokens: maxTokens,
                temperature: temperature,
                topP: topP,
                stop: stop,
                bestOf: bestOf,
                randomSeed: randomSeed,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}