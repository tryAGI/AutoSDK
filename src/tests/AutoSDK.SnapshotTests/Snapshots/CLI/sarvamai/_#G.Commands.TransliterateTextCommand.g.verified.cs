//HintName: G.Commands.TransliterateTextCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TransliterateTextCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string input,
            global::G.TransliterateRequestSourceLanguageCode sourceLanguageCode,
            global::G.TransliterateRequestTargetLanguageCode targetLanguageCode,
            global::G.TransliterateRequestNumeralsFormat? numeralsFormat,
            bool? spokenForm,
            global::G.TransliterateRequestSpokenFormNumeralsLanguage? spokenFormNumeralsLanguage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TransliterateResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Input { get; } = new(
            name: "input")
        {
            Description = @"Text to transliterate (max 1000 characters)",
        };

        private global::System.CommandLine.Argument<global::G.TransliterateRequestSourceLanguageCode> SourceLanguageCode { get; } = new(
            name: "sourceLanguageCode")
        {
            Description = @"Source language code (BCP-47) or ""auto""",
        };

        private global::System.CommandLine.Argument<global::G.TransliterateRequestTargetLanguageCode> TargetLanguageCode { get; } = new(
            name: "targetLanguageCode")
        {
            Description = @"Target language code (BCP-47)",
        };

        private global::System.CommandLine.Option<global::G.TransliterateRequestNumeralsFormat?> NumeralsFormat { get; } = new(
            name: "numeralsFormat")
        {
            Description = @"Format of numerals in the output",
        };

        private global::System.CommandLine.Option<bool?> SpokenForm { get; } = new(
            name: "spokenForm")
        {
            Description = @"Whether to convert text into a natural spoken form",
        };

        private global::System.CommandLine.Option<global::G.TransliterateRequestSpokenFormNumeralsLanguage?> SpokenFormNumeralsLanguage { get; } = new(
            name: "spokenFormNumeralsLanguage")
        {
            Description = @"Language for spoken form numerals (only applies when spoken_form is true)",
        };


        public TransliterateTextCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "transliterate",
            description: @"Converts text from one script to another while maintaining the same language.
Supports transliteration between Indic scripts and Roman script.
Max 1000 characters per request.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Input);
            Arguments.Add(SourceLanguageCode);
            Arguments.Add(TargetLanguageCode);
            Options.Add(NumeralsFormat);
            Options.Add(SpokenForm);
            Options.Add(SpokenFormNumeralsLanguage);

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
            var numeralsFormat = parseResult.GetRequiredValue(NumeralsFormat);
            var spokenForm = parseResult.GetRequiredValue(SpokenForm);
            var spokenFormNumeralsLanguage = parseResult.GetRequiredValue(SpokenFormNumeralsLanguage);

            Validate(
                parseResult: parseResult,
                input: input,
                sourceLanguageCode: sourceLanguageCode,
                targetLanguageCode: targetLanguageCode,
                numeralsFormat: numeralsFormat,
                spokenForm: spokenForm,
                spokenFormNumeralsLanguage: spokenFormNumeralsLanguage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TransliterateTextAsync(
                input: input,
                sourceLanguageCode: sourceLanguageCode,
                targetLanguageCode: targetLanguageCode,
                numeralsFormat: numeralsFormat,
                spokenForm: spokenForm,
                spokenFormNumeralsLanguage: spokenFormNumeralsLanguage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}