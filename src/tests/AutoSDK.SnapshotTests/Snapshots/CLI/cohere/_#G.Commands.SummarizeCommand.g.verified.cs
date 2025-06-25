//HintName: G.Commands.SummarizeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SummarizeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.SummarizeRequestExtractiveness> Extractiveness { get; } = new(
            name: "extractiveness")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.SummarizeRequestFormat> Format { get; } = new(
            name: "format")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.SummarizeRequestLength> Length { get; } = new(
            name: "length")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<double> Temperature { get; } = new(
            name: "temperature")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"",
        };
        public SummarizeCommand(G.IApi client) : base(
            name: "summarize",
            description: @"<Warning>
This API is marked as ""Legacy"" and is no longer maintained. Follow the [migration guide](https://docs.cohere.com/docs/migrating-from-cogenerate-to-cochat) to start using the Chat API.
</Warning>
Generates a summary in English for a given text.")
        {
            _client = client;

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