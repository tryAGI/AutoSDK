//HintName: G.IOpenAiClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IOpenAiClient : global::System.IDisposable
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
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// Build Assistants that can call models and use tools.
        /// </summary>
        public AssistantsClient Assistants { get; }

        /// <summary>
        /// Turn audio into text or text into audio.
        /// </summary>
        public AudioClient Audio { get; }

        /// <summary>
        /// Given a list of messages comprising a conversation, the model will return a response.
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position.
        /// </summary>
        public CompletionsClient Completions { get; }

        /// <summary>
        /// Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// Manage fine-tuning jobs to tailor a model to your specific training data.
        /// </summary>
        public FineTuningClient FineTuning { get; }

        /// <summary>
        /// Create large batches of API requests to run asynchronously.
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// Files are used to upload documents that can be used with features like Assistants and Fine-tuning.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// Use Uploads to upload large files in multiple parts.
        /// </summary>
        public UploadsClient Uploads { get; }

        /// <summary>
        /// Given a prompt and/or an input image, the model will generate a new image.
        /// </summary>
        public ImagesClient Images { get; }

        /// <summary>
        /// List and describe the various models available in the API.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Given a input text, outputs if the model classifies it as potentially harmful.
        /// </summary>
        public ModerationsClient Moderations { get; }

        /// <summary>
        /// List user actions and configuration changes within this organization.
        /// </summary>
        public AuditLogsClient AuditLogs { get; }

        /// <summary>
        /// 
        /// </summary>
        public VectorStoresClient VectorStores { get; }

        /// <summary>
        /// 
        /// </summary>
        public InvitesClient Invites { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

    }
}