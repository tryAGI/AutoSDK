//HintName: G.TranslateDocumentsClient.g.cs

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
    public sealed partial class TranslateDocumentsClient : global::G.ITranslateDocumentsClient, global::System.IDisposable
    {
        /// <summary>
        /// DeepL API Pro
        /// </summary>
        public const string DefaultBaseUrl = "https://api.deepl.com/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// Creates a new instance of the TranslateDocumentsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TranslateDocumentsClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the TranslateDocumentsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TranslateDocumentsClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            global::G.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}