//HintName: G.Commands.TranslateDocumentsTranslateDocumentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TranslateDocumentsTranslateDocumentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SourceLanguage? sourceLang,
            global::G.TargetLanguage targetLang,
            byte[] file,
            string? filename,
            string? outputFormat,
            global::G.Formality? formality,
            string? glossaryId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.TranslateDocumentResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.TargetLanguage> TargetLang { get; } = new(
            name: "targetLang")
        {
            Description = @"The language into which the text should be translated.

**Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.",
        };

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = @"The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:
  * `docx` - Microsoft Word Document
  * `pptx` - Microsoft PowerPoint Document
  * `xlsx` - Microsoft Excel Document
  * `pdf` - Portable Document Format
  * `htm / html` - HTML Document
  * `txt` - Plain Text Document
  * `xlf / xliff` - XLIFF Document, version 2.1
  * `srt` - SRT Document
  * `jpeg / jpg / png` - Image",
        };

        private global::System.CommandLine.Option<global::G.SourceLanguage?> SourceLang { get; } = new(
            name: "sourceLang")
        {
            Description = @"Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.

**Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = @"The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.",
        };

        private global::System.CommandLine.Option<string?> OutputFormat { get; } = new(
            name: "outputFormat")
        {
            Description = @"File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.

Note: Not all combinations of input file and translation file extensions are permitted. See [Document Format Conversions](https://www.deepl.com/docs-api/documents/format-conversions) for the permitted combinations.",
        };

        private global::System.CommandLine.Option<global::G.Formality?> Formality { get; } = new(
            name: "formality")
        {
            Description = @"Sets whether the translated text should lean towards formal or informal language.
This feature currently only works for target languages
`DE` (German),
`FR` (French),
`IT` (Italian),
`ES` (Spanish),
`ES-419` (Latin American Spanish),
`NL` (Dutch),
`PL` (Polish),
`PT-BR` and `PT-PT` (Portuguese),
`JA` (Japanese),
and `RU` (Russian).
Learn more about the plain/polite feature for Japanese [here](https://support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).
Setting this parameter with a target language that does not support formality will fail,
unless one of the `prefer_...` options are used.
Possible options are:
  * `default` (default)
  * `more` - for a more formal language
  * `less` - for a more informal language
  * `prefer_more` - for a more formal language if available, otherwise fallback to default formality
  * `prefer_less` - for a more informal language if available, otherwise fallback to default formality",
        };

        private global::System.CommandLine.Option<string?> GlossaryId { get; } = new(
            name: "glossaryId")
        {
            Description = @"A unique ID assigned to a glossary.",
        };


        public TranslateDocumentsTranslateDocumentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "translate",
            description: @"This call uploads a document and queues it for translation.
The call returns once the upload is complete, returning a document ID and key which can be used to
[query the translation status](https://www.deepl.com/docs-api/documents/get-document-status)
and to [download the translated document](https://www.deepl.com/docs-api/documents/download-document) once translation is complete.



Because the request includes a file upload, it must be an HTTP POST request with content type `multipart/form-data`.


Please be aware that the uploaded document is automatically removed from the server once the translated document has been downloaded.
You have to upload the document again in order to restart the translation.


The maximum upload limit for documents is [available here](https://support.deepl.com/hc/articles/360020582359-Document-formats)
and may vary based on API plan and document type.


You may specify the glossary to use for the document translation using the `glossary_id` parameter.
**Important:** This requires the `source_lang` parameter to be set and the language pair of the glossary has to match the language pair of the request.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(TargetLang);
            Arguments.Add(File);
            Options.Add(SourceLang);
            Options.Add(Filename);
            Options.Add(OutputFormat);
            Options.Add(Formality);
            Options.Add(GlossaryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sourceLang = parseResult.GetRequiredValue(SourceLang);
            var targetLang = parseResult.GetRequiredValue(TargetLang);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var outputFormat = parseResult.GetRequiredValue(OutputFormat);
            var formality = parseResult.GetRequiredValue(Formality);
            var glossaryId = parseResult.GetRequiredValue(GlossaryId);

            Validate(
                parseResult: parseResult,
                sourceLang: sourceLang,
                targetLang: targetLang,
                file: file,
                filename: filename,
                outputFormat: outputFormat,
                formality: formality,
                glossaryId: glossaryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.TranslateDocuments.TranslateDocumentAsync(
                sourceLang: sourceLang,
                targetLang: targetLang,
                file: file,
                filename: filename,
                outputFormat: outputFormat,
                formality: formality,
                glossaryId: glossaryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}