//HintName: G.OpenAiClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class OpenAiClient : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;

        public AssistantsClient Assistants => new AssistantsClient(_httpClient);
        public AudioClient Audio => new AudioClient(_httpClient);
        public ChatClient Chat => new ChatClient(_httpClient);
        public CompletionsClient Completions => new CompletionsClient(_httpClient);
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient);
        public FineTuningClient FineTuning => new FineTuningClient(_httpClient);
        public BatchClient Batch => new BatchClient(_httpClient);
        public FilesClient Files => new FilesClient(_httpClient);
        public ImagesClient Images => new ImagesClient(_httpClient);
        public ModelsClient Models => new ModelsClient(_httpClient);
        public ModerationsClient Moderations => new ModerationsClient(_httpClient);
        public VectorStoresClient VectorStores => new VectorStoresClient(_httpClient);

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
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://api.openai.com/v1");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}