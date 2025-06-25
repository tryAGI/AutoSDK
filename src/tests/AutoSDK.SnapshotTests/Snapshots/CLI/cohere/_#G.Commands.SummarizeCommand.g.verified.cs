//HintName: G.Commands.SummarizeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SummarizeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xClientName,
            string additionalCommand,
            global::G.SummarizeRequestExtractiveness extractiveness,
            global::G.SummarizeRequestFormat format,
            global::G.SummarizeRequestLength length,
            string model,
            double temperature,
            string text,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SummarizeResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> AdditionalCommand { get; } = new(
            name: "additionalCommand")
        {
            Description = @"A free-form instruction for modifying how the summaries get generated. Should complete the sentence ""Generate a summary _"". Eg. ""focusing on the next steps"" or ""written by Yoda""",
        };

        private global::System.CommandLine.Argument<global::G.SummarizeRequestExtractiveness> Extractiveness { get; } = new(
            name: "extractiveness")
        {
            Description = @"One of `low`, `medium`, `high`, or `auto`, defaults to `auto`. Controls how close to the original text the summary is. `high` extractiveness summaries will lean towards reusing sentences verbatim, while `low` extractiveness summaries will tend to paraphrase more. If `auto` is selected, the best option will be picked based on the input text.",
        };

        private global::System.CommandLine.Argument<global::G.SummarizeRequestFormat> Format { get; } = new(
            name: "format")
        {
            Description = @"One of `paragraph`, `bullets`, or `auto`, defaults to `auto`. Indicates the style in which the summary will be delivered - in a free form paragraph or in bullet points. If `auto` is selected, the best option will be picked based on the input text.",
        };

        private global::System.CommandLine.Argument<global::G.SummarizeRequestLength> Length { get; } = new(
            name: "length")
        {
            Description = @"One of `short`, `medium`, `long`, or `auto` defaults to `auto`. Indicates the approximate length of the summary. If `auto` is selected, the best option will be picked based on the input text.",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"The identifier of the model to generate the summary with. Currently available models are `command` (default), `command-nightly` (experimental), `command-light`, and `command-light-nightly` (experimental). Smaller, ""light"" models are faster, while larger models will perform better.",
        };

        private global::System.CommandLine.Argument<double> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"Ranges from 0 to 5. Controls the randomness of the output. Lower values tend to generate more “predictable” output, while higher values tend to generate more “creative” output. The sweet spot is typically between 0 and 1.",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"The text to generate a summary for. Can be up to 100,000 characters long. Currently the only supported language is English.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };
        public SummarizeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "summarize",
            description: @"<Warning>
This API is marked as ""Legacy"" and is no longer maintained. Follow the [migration guide](https://docs.cohere.com/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.
</Warning>
Generates a summary in English for a given text.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(AdditionalCommand);
            Arguments.Add(Extractiveness);
            Arguments.Add(Format);
            Arguments.Add(Length);
            Arguments.Add(Model);
            Arguments.Add(Temperature);
            Arguments.Add(Text);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var additionalCommand = parseResult.GetRequiredValue(AdditionalCommand);
            var extractiveness = parseResult.GetRequiredValue(Extractiveness);
            var format = parseResult.GetRequiredValue(Format);
            var length = parseResult.GetRequiredValue(Length);
            var model = parseResult.GetRequiredValue(Model);
            var temperature = parseResult.GetRequiredValue(Temperature);
            var text = parseResult.GetRequiredValue(Text);

            Validate(
                parseResult: parseResult,
                xClientName: xClientName,
                additionalCommand: additionalCommand,
                extractiveness: extractiveness,
                format: format,
                length: length,
                model: model,
                temperature: temperature,
                text: text,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SummarizeAsync(
                xClientName: xClientName,
                additionalCommand: additionalCommand,
                extractiveness: extractiveness,
                format: format,
                length: length,
                model: model,
                temperature: temperature,
                text: text,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}