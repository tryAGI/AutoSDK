//HintName: G.ITranslateDocumentsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The document translation API allows you to translate whole documents and supports the following file types and extensions:<br/>
    ///   * `docx` - Microsoft Word Document<br/>
    ///   * `pptx` - Microsoft PowerPoint Document<br/>
    ///   * `xlsx` - Microsoft Excel Document<br/>
    ///   * `pdf` - Portable Document Format<br/>
    ///   * `htm / html` - HTML Document<br/>
    ///   * `txt` - Plain Text Document<br/>
    ///   * `xlf / xliff` - XLIFF Document, version 2.1<br/>
    ///   * `srt` - SRT Document<br/>
    ///   * `jpeg / jpg / png` - Image<br/>
    /// Please note that with every submitted document of type .pptx, .docx, .xlsx, or .pdf,<br/>
    /// you are billed a minimum of 50,000 characters with the DeepL API plan,<br/>
    /// no matter how many characters are included in the document.<br/>
    /// Translating a document usually involves three types of HTTP requests:<br/>
    ///   - [upload](https://www.deepl.com/docs-api/documents/translate-document) the document to be translated,<br/>
    ///   - periodically [check the status](https://www.deepl.com/docs-api/documents/get-document-status) of the document translation,<br/>
    ///   - once the status call reports `done`, [download](https://www.deepl.com/docs-api/documents/download-document) the translated document.<br/>
    /// To learn more about context in DeepL API translations, we recommend [this article](https://www.deepl.com/docs-api/general/working-with-context).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ITranslateDocumentsClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}