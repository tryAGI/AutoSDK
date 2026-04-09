//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The DeepL API provides programmatic access to DeepL’s language AI technology.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// DeepL API Pro
        /// </summary>
        public const string DefaultBaseUrl = "https://api.deepl.com";

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
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// 
        /// </summary>
        public AdminApiClient AdminApi => new AdminApiClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Please note that this is the spec for the (old) v2 glossary endpoint.<br/>
        /// We recommend users switch to the newer v3 glossary endpoints, which support editability and multilinguality.<br/>
        /// The *glossary* functions allow you to create, inspect, and delete glossaries.<br/>
        /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
        /// `glossary_id` parameter.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.<br/>
        /// Currently you can create glossaries with any of the languages DeepL supports.<br/>
        /// The maximum size limit for a glossary is 10 MiB = 10485760 bytes and each source/target text,<br/>
        /// as well as the name of the glossary, is limited to 1024 UTF-8 bytes.<br/>
        /// A total of 1000 glossaries are allowed per account.<br/>
        /// When creating a glossary with target language `EN`, `PT`, or `ZH`, it's not necessary to specify a variant<br/>
        /// (e.g. `EN-US`, `EN-GB`, `PT-PT`, `PT-BR`, or `ZH-HANS`).<br/>
        /// Glossaries with target language `EN` can be used in translations with either English variant.<br/>
        /// Similarly `PT`, and `ZH` glossaries can be used in translations with their corresponding variants.<br/>
        /// Note that on the v2 API, glossaries are immutable: once created, the glossary entries for a given glossary ID cannot be modified.<br/>
        /// As a workaround for effectively editable glossaries, we suggest to identify glossaries by name instead of ID in your application<br/>
        /// and then use the following procedure for modifications:<br/>
        /// - [download](https://www.deepl.com/docs-api/glossaries/get-glossary-entries) and store the current glossary's entries,<br/>
        /// - locally modify the glossary entries,<br/>
        /// - [delete](https://www.deepl.com/docs-api/glossaries/delete-glossary) the existing glossary,<br/>
        /// - [create a new glossary](https://www.deepl.com/docs-api/glossaries/create-glossary) with the same name.
        /// </summary>
        public ManageGlossariesClient ManageGlossaries => new ManageGlossariesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The *glossary* functions allow you to create, inspect, edit and delete glossaries.<br/>
        /// Glossaries created with the glossary function can be used in translate requests by specifying the<br/>
        /// `glossary_id` parameter. A glossary contains (several) dictionaries.<br/>
        /// A dictionary is a mapping of source phrases to target phrases for a single language pair.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.<br/>
        /// Currently you can create glossaries with any of the languages DeepL supports.<br/>
        /// The maximum size limit for a glossary is 10 MiB = 10485760 bytes and each source/target text,<br/>
        /// as well as the name of the glossary, is limited to 1024 UTF-8 bytes.<br/>
        /// A total of 1000 glossaries are allowed per account.<br/>
        /// When creating a dictionary with target language `EN`, `PT`, or `ZH`, it's not necessary to specify a variant<br/>
        /// (e.g. `EN-US`, `EN-GB`, `PT-PT`, `PT-BR`, or `ZH-HANS`).<br/>
        /// Dictionaries with target language `EN` can be used in translations with either English variant.<br/>
        /// Similarly `PT`, and `ZH` dictionaries can be used in translations with their corresponding variants.<br/>
        /// (When you provide the ID of a glossary to a translation, the appropriate dictionary is automatically applied. Currently glossaries can not yet be used with source language detection.)<br/>
        /// Glossaries created via the DeepL API are now unified with glossaries created via the DeepL website and DeepL apps.<br/>
        /// Please only use the v3 glossary API in conjunction with multilingual or edited glossaries from the website.
        /// </summary>
        public ManageMultilingualGlossariesClient ManageMultilingualGlossaries => new ManageMultilingualGlossariesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Information about API usage and value ranges
        /// </summary>
        public MetaInformationClient MetaInformation => new MetaInformationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The `rephrase` endpoint  is used to make corrections and adjustments to texts based on style or tone.<br/>
        /// For more details, visit [this documentation page](https://developers.deepl.com/docs/api-reference/improve-text)
        /// </summary>
        public RephraseTextClient RephraseText => new RephraseTextClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The *style rules* functions allow you to create, inspect, edit and delete style rules.<br/>
        /// Style rules can be used in translate requests by specifying the `style_id` parameter, allowing you to<br/>
        /// select a set of rules to apply when translating text. These rules make changes to your text according<br/>
        /// to the selected formatting and spelling conventions.<br/>
        /// If you encounter issues, please let us know at support@DeepL.com.
        /// </summary>
        public StyleRulesClient StyleRules => new StyleRulesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

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
        /// To learn more about context in DeepL API translations, we recommend [this article](https://www.deepl.com/docs-api/general/working-with-context).
        /// </summary>
        public TranslateDocumentsClient TranslateDocuments => new TranslateDocumentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The text-translation API currently consists of a single endpoint, `translate`, which is described below.<br/>
        /// To learn more about context in DeepL API translations, we recommend [this article](https://www.deepl.com/docs-api/general/working-with-context).
        /// </summary>
        public TranslateTextClient TranslateText => new TranslateTextClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// The Voice API provides real-time voice transcription and translation services.<br/>
        /// Use a two-step flow: first request a streaming URL via REST, then establish a WebSocket connection for streaming audio and receiving transcriptions.
        /// </summary>
        public VoiceAPIClient VoiceAPI => new VoiceAPIClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
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