//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vectara provides an end-to-end platform for creating GenAI products using <br/>
    /// a simple to use API.<br/>
    /// You can [sign up for an account](https://console.vectara.com/signup) and <br/>
    /// then view several [API Recipes](https://docs.vectara.com/docs/api-recipes) with example queries <br/>
    /// and parameter values.<br/>
    /// The Vectara API Playground lets you experiment with REST endpoints from <br/>
    /// your browser. Select an endpoint to view its definition, including the <br/>
    /// required or optional headers, body, responses, and sample commands. On the <br/>
    /// right side of each endpoint page, like [Get Corpus](/docs/rest-api/get-corpus), you manually <br/>
    /// enter your API Key or OAuth Bearer Token, `customer_id`, and then any <br/>
    /// required body parameters like the `corpusID` before sending the API <br/>
    /// request.<br/>
    /// :::note<br/>
    /// Vectara supports two primary methods of authentication: API keys and OAuth <br/>
    /// 2.0, which are applicable to all endpoints. Query API Keys are used for <br/>
    /// read-only querying operations, while Index API Keys provide read and write <br/>
    /// access. The OAuth 2.0 operations authenticate with a Bearer Token via the <br/>
    /// OAuth 2.0 client credentials grant. Review the [**OAuth 2.0 section**](https://docs.vectara.com/docs/learn/authentication/oauth-2) about <br/>
    /// how to generate the token.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.vectara.io";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::System.Collections.Generic.List<global::G.EndPointAuthorization> _authorizations;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.FilterAttributeLevelJsonConverter(),
                    new global::G.JsonConverters.FilterAttributeLevelNullableJsonConverter(),
                    new global::G.JsonConverters.FilterAttributeTypeJsonConverter(),
                    new global::G.JsonConverters.FilterAttributeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SearchRerankerDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.SearchRerankerDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LanguageJsonConverter(),
                    new global::G.JsonConverters.LanguageNullableJsonConverter(),
                    new global::G.JsonConverters.CitationParametersStyleJsonConverter(),
                    new global::G.JsonConverters.CitationParametersStyleNullableJsonConverter(),
                    new global::G.JsonConverters.SearchSemanticsJsonConverter(),
                    new global::G.JsonConverters.SearchSemanticsNullableJsonConverter(),
                    new global::G.JsonConverters.QueryStreamedResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.QueryStreamedResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateDocumentRequestDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateDocumentRequestDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatStreamedResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ChatStreamedResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ApiKeyRoleJsonConverter(),
                    new global::G.JsonConverters.ApiKeyRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ApiRoleJsonConverter(),
                    new global::G.JsonConverters.ApiRoleNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAppClientRequestDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAppClientRequestDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobTypeJsonConverter(),
                    new global::G.JsonConverters.JobTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobStateJsonConverter(),
                    new global::G.JsonConverters.JobStateNullableJsonConverter(),
                    new global::G.JsonConverters.SearchRerankerJsonConverter(),
                    new global::G.JsonConverters.SearchCorporaParametersJsonConverter(),
                    new global::G.JsonConverters.KeyedSearchCorpusJsonConverter(),
                    new global::G.JsonConverters.AllOfJsonConverterFactory2(),
                    new global::G.JsonConverters.QueryStreamedResponseJsonConverter(),
                    new global::G.JsonConverters.CreateDocumentRequestJsonConverter(),
                    new global::G.JsonConverters.ChatStreamedResponseJsonConverter(),
                    new global::G.JsonConverters.CreateAppClientRequestJsonConverter(),
                }
            };


        /// <summary>
        /// Perform search and Retrieval Augmented Generation (RAG) operations on one or more corpora
        /// </summary>
        public QueriesClient Queries => new QueriesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Upload files to a corpus for automatic parsing, text extraction, chunking, and indexing
        /// </summary>
        public UploadClient Upload => new UploadClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Index and manage core and structured documents for efficient search and retrieval
        /// </summary>
        public IndexClient Index => new IndexClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, manage, and update corpora and their associated settings
        /// </summary>
        public CorporaClient Corpora => new CorporaClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve and manage documents stored in a corpus for administrative tasks
        /// </summary>
        public DocumentsClient Documents => new DocumentsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, manage, and interact with chat sessions for conversational AI
        /// </summary>
        public ChatsClient Chats => new ChatsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List LLMs for text summarization, chat, and other generation tasks
        /// </summary>
        public LargeLanguageModelsClient LargeLanguageModels => new LargeLanguageModelsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List available encoders (such as Boomerang) that turn text into vectors
        /// </summary>
        public EncodersClient Encoders => new EncodersClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List rerankers for reranking search results
        /// </summary>
        public RerankersClient Rerankers => new RerankersClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Monitor background jobs such as rebuilding indexes or updating corpus settings
        /// </summary>
        public JobsClient Jobs => new JobsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, manage, and authenticate users within the platform for user administration
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage app clients, and perform authentication operations for admin-level access control
        /// </summary>
        public ApplicationClientsClient ApplicationClients => new ApplicationClientsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage API keys for the account
        /// </summary>
        public APIKeysClient APIKeys => new APIKeysClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationPresetsClient GenerationPresets => new GenerationPresetsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorizations"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
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