//HintName: G.Commands.TranslationCreateTranslationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslationCreateTranslationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TranslationRequestModel model,
            string sourceLanguageCode,
            string targetLanguageCode,
            string text,
            bool formality,
            bool lengthControl,
            bool maskProfanity,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TranslationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> SourceLanguageCode { get; } = new(
            name: "sourceLanguageCode")
        {
            Description = @"The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the original text to translate. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). For example, Mexican Spanish is `es-MX`. See the [list of supported languages and language codes](https://dev.writer.com/api-reference/translation-api/language-support).",
        };

        private global::System.CommandLine.Argument<string> TargetLanguageCode { get; } = new(
            name: "targetLanguageCode")
        {
            Description = @"The [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639_language_codes) language code of the target language for the translation. For example, `en` for English, `zh` for Chinese, `fr` for French, `es` for Spanish. If the language has a variant, the code appends the two-digit [ISO-3166 country code](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes). For example, Mexican Spanish is `es-MX`. See the [list of supported languages and language codes](https://dev.writer.com/api-reference/translation-api/language-support).",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = @"The text to translate. Maximum of 100,000 words.",
        };

        private global::System.CommandLine.Argument<bool> Formality { get; } = new(
            name: "formality")
        {
            Description = @"Whether to use formal or informal language in the translation. See the [list of languages that support formality](https://dev.writer.com/api-reference/translation-api/language-support#formality). If the language does not support formality, this parameter is ignored.",
        };

        private global::System.CommandLine.Argument<bool> LengthControl { get; } = new(
            name: "lengthControl")
        {
            Description = @"Whether to control the length of the translated text. See the [list of languages that support length control](https://dev.writer.com/api-reference/translation-api/language-support#length-control). If the language does not support length control, this parameter is ignored.",
        };

        private global::System.CommandLine.Argument<bool> MaskProfanity { get; } = new(
            name: "maskProfanity")
        {
            Description = @"Whether to mask profane words in the translated text. See the [list of languages that do not support profanity masking](https://dev.writer.com/api-reference/translation-api/language-support#profanity-masking). If the language does not support profanity masking, this parameter is ignored.",
        };

        private global::System.CommandLine.Option<global::G.TranslationRequestModel> Model { get; } = new(
            name: "model")
        {
            Description = @"The model to use for translation.",
        };


        public TranslationCreateTranslationCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Translate text from one language to another.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(SourceLanguageCode);
            Arguments.Add(TargetLanguageCode);
            Arguments.Add(Text);
            Arguments.Add(Formality);
            Arguments.Add(LengthControl);
            Arguments.Add(MaskProfanity);
            Options.Add(Model);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var sourceLanguageCode = parseResult.GetRequiredValue(SourceLanguageCode);
            var targetLanguageCode = parseResult.GetRequiredValue(TargetLanguageCode);
            var text = parseResult.GetRequiredValue(Text);
            var formality = parseResult.GetRequiredValue(Formality);
            var lengthControl = parseResult.GetRequiredValue(LengthControl);
            var maskProfanity = parseResult.GetRequiredValue(MaskProfanity);

            Validate(
                parseResult: parseResult,
                model: model,
                sourceLanguageCode: sourceLanguageCode,
                targetLanguageCode: targetLanguageCode,
                text: text,
                formality: formality,
                lengthControl: lengthControl,
                maskProfanity: maskProfanity,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Translation.CreateTranslationAsync(
                model: model,
                sourceLanguageCode: sourceLanguageCode,
                targetLanguageCode: targetLanguageCode,
                text: text,
                formality: formality,
                lengthControl: lengthControl,
                maskProfanity: maskProfanity,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}