//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our Chat Completion and Embeddings APIs specification. Create your account on [La Plateforme](https://console.mistral.ai) to get access and read the [docs](https://docs.mistral.ai) to learn how to use it.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
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
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::G.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// Agents. Agents API.
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// Batch. Batch API.
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// Chat. Chat Completion API.
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// Classifiers. Classifiers API.
        /// </summary>
        public ClassifiersClient Classifiers { get; }

        /// <summary>
        /// Embeddings. Embeddings API.
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// Files. Files API.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// FIM. Fill-in-the-middle API.
        /// </summary>
        public FimClient Fim { get; }

        /// <summary>
        /// Fine Tuning. Fine-tuning API.
        /// </summary>
        public FineTuningClient FineTuning { get; }

        /// <summary>
        /// Models. Model Management API.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// OCR API.
        /// </summary>
        public OcrClient Ocr { get; }

    }
}