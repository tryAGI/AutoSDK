//HintName: G.ManageMultilingualGlossariesClient.g.cs

#nullable enable

namespace G
{
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
    /// Please only use the v3 glossary API in conjunction with multilingual or edited glossaries from the website.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ManageMultilingualGlossariesClient : global::G.IManageMultilingualGlossariesClient, global::System.IDisposable
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
        /// Creates a new instance of the ManageMultilingualGlossariesClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ManageMultilingualGlossariesClient(
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
        /// Creates a new instance of the ManageMultilingualGlossariesClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ManageMultilingualGlossariesClient(
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