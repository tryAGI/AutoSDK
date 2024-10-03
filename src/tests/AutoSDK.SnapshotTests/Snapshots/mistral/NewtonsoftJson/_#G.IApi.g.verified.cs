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
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// Chat Completion API.
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// Fill-in-the-middle API.
        /// </summary>
        public FimClient Fim { get; }

        /// <summary>
        /// Agents API.
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// Embeddings API.
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// Files API
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// Fine-tuning API
        /// </summary>
        public FineTuningClient FineTuning { get; }

        /// <summary>
        /// Model Management API
        /// </summary>
        public ModelsClient Models { get; }

    }
}