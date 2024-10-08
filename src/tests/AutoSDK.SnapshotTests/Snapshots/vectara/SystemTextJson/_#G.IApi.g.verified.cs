//HintName: G.IApi.g.cs

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
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Perform search and Retrieval Augmented Generation (RAG) operations on one or more corpora
        /// </summary>
        public QueriesClient Queries { get; }

        /// <summary>
        /// Upload files to a corpus for automatic parsing, text extraction, chunking, and indexing
        /// </summary>
        public UploadClient Upload { get; }

        /// <summary>
        /// Index and manage core and structured documents for efficient search and retrieval
        /// </summary>
        public IndexClient Index { get; }

        /// <summary>
        /// Create, manage, and update corpora and their associated settings
        /// </summary>
        public CorporaClient Corpora { get; }

        /// <summary>
        /// Retrieve and manage documents stored in a corpus for administrative tasks
        /// </summary>
        public DocumentsClient Documents { get; }

        /// <summary>
        /// Create, manage, and interact with chat sessions for conversational AI
        /// </summary>
        public ChatsClient Chats { get; }

        /// <summary>
        /// List LLMs for text summarization, chat, and other generation tasks
        /// </summary>
        public LargeLanguageModelsClient LargeLanguageModels { get; }

        /// <summary>
        /// List available encoders (such as Boomerang) that turn text into vectors
        /// </summary>
        public EncodersClient Encoders { get; }

        /// <summary>
        /// List rerankers for reranking search results
        /// </summary>
        public RerankersClient Rerankers { get; }

        /// <summary>
        /// Monitor background jobs such as rebuilding indexes or updating corpus settings
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// Create, manage, and authenticate users within the platform for user administration
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// Manage app clients, and perform authentication operations for admin-level access control
        /// </summary>
        public ApplicationClientsClient ApplicationClients { get; }

        /// <summary>
        /// Manage API keys for the account
        /// </summary>
        public APIKeysClient APIKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationPresetsClient GenerationPresets { get; }

    }
}