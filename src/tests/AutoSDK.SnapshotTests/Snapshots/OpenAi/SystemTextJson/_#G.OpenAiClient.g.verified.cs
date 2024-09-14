//HintName: G.OpenAiClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class OpenAiClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.openai.com/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::G.SourceGenerationContext.Default;


        /// <summary>
        /// Build Assistants that can call models and use tools.
        /// </summary>
        public AssistantsClient Assistants => new AssistantsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Turn audio into text or text into audio.
        /// </summary>
        public AudioClient Audio => new AudioClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Given a list of messages comprising a conversation, the model will return a response.
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Given a prompt, the model will return one or more predicted completions, and can also return the probabilities of alternative tokens at each position.
        /// </summary>
        public CompletionsClient Completions => new CompletionsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Manage fine-tuning jobs to tailor a model to your specific training data.
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Create large batches of API requests to run asynchronously.
        /// </summary>
        public BatchClient Batch => new BatchClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Files are used to upload documents that can be used with features like Assistants and Fine-tuning.
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Use Uploads to upload large files in multiple parts.
        /// </summary>
        public UploadsClient Uploads => new UploadsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Given a prompt and/or an input image, the model will generate a new image.
        /// </summary>
        public ImagesClient Images => new ImagesClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// List and describe the various models available in the API.
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Given a input text, outputs if the model classifies it as potentially harmful.
        /// </summary>
        public ModerationsClient Moderations => new ModerationsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// List user actions and configuration changes within this organization.
        /// </summary>
        public AuditLogsClient AuditLogs => new AuditLogsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public VectorStoresClient VectorStores => new VectorStoresClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public InvitesClient Invites => new InvitesClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the OpenAiClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param> 
        public OpenAiClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

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