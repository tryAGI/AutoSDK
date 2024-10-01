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
        private global::G.EndPointAuthorization? _authorization;

        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings();


        /// <summary>
        /// Perform search and Retrieval Augmented Generation (RAG) operations on one or more corpora
        /// </summary>
        public QueriesClient Queries => new QueriesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Upload files to a corpus for automatic parsing and document extraction
        /// </summary>
        public UploadClient Upload => new UploadClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Index and manage core and structured documents for efficient search and retrieval
        /// </summary>
        public IndexClient Index => new IndexClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, manage, and update corpora and their associated settings for administration purposes
        /// </summary>
        public CorporaClient Corpora => new CorporaClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve and manage documents stored in a corpus for administrative tasks
        /// </summary>
        public DocumentsClient Documents => new DocumentsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, manage, and interact with chat sessions for conversational AI and administrative monitoring
        /// </summary>
        public ChatsClient Chats => new ChatsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List LLMs for text summarization, chat, and other generation tasks
        /// </summary>
        public LargeLanguageModelsClient LargeLanguageModels => new LargeLanguageModelsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List encoders that turn text into vectors such as Boomerang
        /// </summary>
        public EncodersClient Encoders => new EncodersClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// List rerankers for reranking search results
        /// </summary>
        public RerankersClient Rerankers => new RerankersClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Monitor background jobs such as rebuilding indexes or updating corpus settings
        /// </summary>
        public JobsClient Jobs => new JobsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, manage, and authenticate users within the platform for user administration
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage app clients, and perform authentication operations for admin-level access control
        /// </summary>
        public ApplicationClientsClient ApplicationClients => new ApplicationClientsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Manage API keys for the account
        /// </summary>
        public APIKeysClient APIKeys => new APIKeysClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GenerationPresetsClient GenerationPresets => new GenerationPresetsClient(_httpClient, authorization: _authorization)
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
        /// <param name="authorization"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::G.EndPointAuthorization? authorization = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorization = authorization;

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