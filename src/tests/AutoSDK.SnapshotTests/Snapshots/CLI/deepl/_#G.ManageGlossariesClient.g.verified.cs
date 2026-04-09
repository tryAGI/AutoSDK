//HintName: G.ManageGlossariesClient.g.cs

#nullable enable

namespace G
{
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
    /// - [create a new glossary](https://www.deepl.com/docs-api/glossaries/create-glossary) with the same name.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ManageGlossariesClient : global::G.IManageGlossariesClient, global::System.IDisposable
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
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions();


        /// <summary>
        /// Creates a new instance of the ManageGlossariesClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ManageGlossariesClient(
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
        /// Creates a new instance of the ManageGlossariesClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ManageGlossariesClient(
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