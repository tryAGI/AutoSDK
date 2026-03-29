//HintName: G.Models.TranslateDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateDocumentRequest
    {
        /// <summary>
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: EN
        /// </summary>
        /// <example>EN</example>
        [global::Newtonsoft.Json.JsonProperty("source_lang")]
        public global::G.SourceLanguage? SourceLang { get; set; }

        /// <summary>
        /// The language into which the text should be translated.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: DE
        /// </summary>
        /// <example>DE</example>
        [global::Newtonsoft.Json.JsonProperty("target_lang", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TargetLanguage TargetLang { get; set; } = default!;

        /// <summary>
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
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// The name of the uploaded file. Can be used as an alternative to including the file name in the file part's content disposition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// File extension of desired format of translated file, for example: `docx`. If unspecified, by default the translated file will be in the same format as the input file.<br/>
        /// Note: Not all combinations of input file and translation file extensions are permitted. See [Document Format Conversions](https://www.deepl.com/docs-api/documents/format-conversions) for the permitted combinations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
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
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("formality")]
        public global::G.Formality? Formality { get; set; }

        /// <summary>
        /// A unique ID assigned to a glossary.<br/>
        /// Example: def3a26b-3e84-45b3-84ae-0c0aaf3525f7
        /// </summary>
        /// <example>def3a26b-3e84-45b3-84ae-0c0aaf3525f7</example>
        [global::Newtonsoft.Json.JsonProperty("glossary_id")]
        public string? GlossaryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateDocumentRequest" /> class.
        /// </summary>
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
        /// <param name="sourceLang">
        /// Language of the text to be translated. If this parameter is omitted, the API will attempt to detect the language of the text and translate it.<br/>
        /// **Note:** Some languages only work with `model_type` set to `quality_optimized`. See [supported languages](https://developers.deepl.com/docs/getting-started/supported-languages) for more details.<br/>
        /// Example: EN
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
        public TranslateDocumentRequest(
            global::G.TargetLanguage targetLang,
            byte[] file,
            global::G.SourceLanguage? sourceLang,
            string? filename,
            string? outputFormat,
            global::G.Formality? formality,
            string? glossaryId)
        {
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename;
            this.OutputFormat = outputFormat;
            this.Formality = formality;
            this.GlossaryId = glossaryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateDocumentRequest" /> class.
        /// </summary>
        public TranslateDocumentRequest()
        {
        }
    }
}