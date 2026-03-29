//HintName: G.ITranslateDocumentsClient.TranslateDocument.g.cs
#nullable enable

namespace G
{
    public partial interface ITranslateDocumentsClient
    {
        /// <summary>
        /// Upload and Translate a Document<br/>
        /// This call uploads a document and queues it for translation.<br/>
        /// The call returns once the upload is complete, returning a document ID and key which can be used to<br/>
        /// [query the translation status](https://www.deepl.com/docs-api/documents/get-document-status)<br/>
        /// and to [download the translated document](https://www.deepl.com/docs-api/documents/download-document) once translation is complete.<br/>
        /// Because the request includes a file upload, it must be an HTTP POST request with content type `multipart/form-data`.<br/>
        /// Please be aware that the uploaded document is automatically removed from the server once the translated document has been downloaded.<br/>
        /// You have to upload the document again in order to restart the translation.<br/>
        /// The maximum upload limit for documents is [available here](https://support.deepl.com/hc/articles/360020582359-Document-formats)<br/>
        /// and may vary based on API plan and document type.<br/>
        /// You may specify the glossary to use for the document translation using the `glossary_id` parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set and the language pair of the glossary has to match the language pair of the request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranslateDocumentResponse> TranslateDocumentAsync(

            global::G.TranslateDocumentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload and Translate a Document<br/>
        /// This call uploads a document and queues it for translation.<br/>
        /// The call returns once the upload is complete, returning a document ID and key which can be used to<br/>
        /// [query the translation status](https://www.deepl.com/docs-api/documents/get-document-status)<br/>
        /// and to [download the translated document](https://www.deepl.com/docs-api/documents/download-document) once translation is complete.<br/>
        /// Because the request includes a file upload, it must be an HTTP POST request with content type `multipart/form-data`.<br/>
        /// Please be aware that the uploaded document is automatically removed from the server once the translated document has been downloaded.<br/>
        /// You have to upload the document again in order to restart the translation.<br/>
        /// The maximum upload limit for documents is [available here](https://support.deepl.com/hc/articles/360020582359-Document-formats)<br/>
        /// and may vary based on API plan and document type.<br/>
        /// You may specify the glossary to use for the document translation using the `glossary_id` parameter.<br/>
        /// **Important:** This requires the `source_lang` parameter to be set and the language pair of the glossary has to match the language pair of the request.
        /// </summary>
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: EN
        /// </param>
        /// <param name="targetLang">
        /// The language into which the text should be translated.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: DE
        /// </param>
        /// <param name="file">
        /// The document file to be translated. The file name should be included in this part's content disposition. As an alternative, the filename parameter can be used. The following file types and extensions are supported:<br/>
        ///   * `docx` - Microsoft Word Document<br/>
        ///   * `pptx` - Microsoft PowerPoint Document<br/>
        ///   * `xlsx` - Microsoft Excel Document<br/>
        ///   * `pdf` - Portable Document Format<br/>
        ///   * `htm / html` - HTML Document<br/>
        ///   * `txt` - Plain Text Document<br/>
        ///   * `xlf / xliff` - XLIFF Document, version 2.1<br/>
        ///   * `srt` - SRT Document<br/>
        ///   * `jpeg / jpg / png` - Image
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.
        /// </param>
        /// <param name="outputFormat">
        /// File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.<br/>
        /// Note: Not all combinations of input file and translation file extensions are permitted. See [Document Format Conversions](https://www.deepl.com/docs-api/documents/format-conversions) for the permitted combinations.
        /// </param>
        /// <param name="formality">
        /// Sets whether the translated text should lean towards formal or informal language.<br/>
        /// This feature currently only works for target languages<br/>
        /// `DE` (German),<br/>
        /// `FR` (French),<br/>
        /// `IT` (Italian),<br/>
        /// `ES` (Spanish),<br/>
        /// `ES-419` (Latin American Spanish),<br/>
        /// `NL` (Dutch),<br/>
        /// `PL` (Polish),<br/>
        /// `PT-BR` and `PT-PT` (Portuguese),<br/>
        /// `JA` (Japanese),<br/>
        /// and `RU` (Russian).<br/>
        /// Learn more about the plain/polite feature for Japanese [here](https://support.deepl.com/hc/en-us/articles/6306700061852-About-the-plain-polite-feature-in-Japanese).<br/>
        /// Setting this parameter with a target language that does not support formality will fail,<br/>
        /// unless one of the `prefer_...` options are used.<br/>
        /// Possible options are:<br/>
        ///   * `default` (default)<br/>
        ///   * `more` - for a more formal language<br/>
        ///   * `less` - for a more informal language<br/>
        ///   * `prefer_more` - for a more formal language if available, otherwise fallback to default formality<br/>
        ///   * `prefer_less` - for a more informal language if available, otherwise fallback to default formality<br/>
        /// Default Value: default
        /// </param>
        /// <param name="glossaryId">
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranslateDocumentResponse> TranslateDocumentAsync(
            global::G.TargetLanguage targetLang,
            byte[] file,
            global::G.SourceLanguage? sourceLang = default,
            string? filename = default,
            string? outputFormat = default,
            global::G.Formality? formality = default,
            string? glossaryId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}