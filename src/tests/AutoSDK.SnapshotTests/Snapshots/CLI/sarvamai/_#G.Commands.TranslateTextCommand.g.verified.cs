//HintName: G.Commands.TranslateTextCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslateTextCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string input,
            global::G.TranslateRequestSourceLanguageCode sourceLanguageCode,
            global::G.TranslateRequestTargetLanguageCode targetLanguageCode,
            global::G.TranslateRequestSpeakerGender? speakerGender,
            global::G.TranslateRequestMode? mode,
            global::G.TranslateRequestModel? model,
            global::G.TranslateRequestOutputScript? outputScript,
            global::G.TranslateRequestNumeralsFormat? numeralsFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TranslateResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Input { get; } = new(
            name: "input")
        {
            Description = @"Text to translate (max 1000 chars for mayura:v1, 2000 for sarvam-translate:v1)",
        };

        private global::System.CommandLine.Argument<global::G.TranslateRequestSourceLanguageCode> SourceLanguageCode { get; } = new(
            name: "sourceLanguageCode")
        {
            Description = @"Source language code (BCP-47) or ""auto"" for automatic detection with mayura:v1",
        };

        private global::System.CommandLine.Argument<global::G.TranslateRequestTargetLanguageCode> TargetLanguageCode { get; } = new(
            name: "targetLanguageCode")
        {
            Description = @"Target language code (BCP-47)",
        };

        private global::System.CommandLine.Option<global::G.TranslateRequestSpeakerGender?> SpeakerGender { get; } = new(
            name: "speakerGender")
        {
            Description = @"Gender of the speaker for better translations",
        };

        private global::System.CommandLine.Option<global::G.TranslateRequestMode?> Mode { get; } = new(
            name: "mode")
        {
            Description = @"Tone or style of the translation",
        };

        private global::System.CommandLine.Option<global::G.TranslateRequestModel?> Model { get; } = new(
            name: "model")
        {
            Description = @"Translation model to use",
        };

        private global::System.CommandLine.Option<global::G.TranslateRequestOutputScript?> OutputScript { get; } = new(
            name: "outputScript")
        {
            Description = @"Controls transliteration style applied to the output text",
        };

        private global::System.CommandLine.Option<global::G.TranslateRequestNumeralsFormat?> NumeralsFormat { get; } = new(
            name: "numeralsFormat")
        {
            Description = @"Format of numerals in the output",
        };


        public TranslateTextCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "translate",
            description: @"Translates text from one language to another. Supports 22+ Indian languages
plus English with options for formal, colloquial, and code-mixed styles.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Input);
            Arguments.Add(SourceLanguageCode);
            Arguments.Add(TargetLanguageCode);
            Options.Add(SpeakerGender);
            Options.Add(Mode);
            Options.Add(Model);
            Options.Add(OutputScript);
            Options.Add(NumeralsFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var input = parseResult.GetRequiredValue(Input);
            var sourceLanguageCode = parseResult.GetRequiredValue(SourceLanguageCode);
            var targetLanguageCode = parseResult.GetRequiredValue(TargetLanguageCode);
            var speakerGender = parseResult.GetRequiredValue(SpeakerGender);
            var mode = parseResult.GetRequiredValue(Mode);
            var model = parseResult.GetRequiredValue(Model);
            var outputScript = parseResult.GetRequiredValue(OutputScript);
            var numeralsFormat = parseResult.GetRequiredValue(NumeralsFormat);

            Validate(
                parseResult: parseResult,
                input: input,
                sourceLanguageCode: sourceLanguageCode,
                targetLanguageCode: targetLanguageCode,
                speakerGender: speakerGender,
                mode: mode,
                model: model,
                outputScript: outputScript,
                numeralsFormat: numeralsFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TranslateTextAsync(
                input: input,
                sourceLanguageCode: sourceLanguageCode,
                targetLanguageCode: targetLanguageCode,
                speakerGender: speakerGender,
                mode: mode,
                model: model,
                outputScript: outputScript,
                numeralsFormat: numeralsFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}