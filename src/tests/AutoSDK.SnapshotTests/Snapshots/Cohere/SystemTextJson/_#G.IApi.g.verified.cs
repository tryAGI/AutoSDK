//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Cohere Platform is centered around models.<br/>
    /// Each model has a different amount of power (i.e. parameters), to be used for different tasks.<br/>
    /// Cohere also supports finetuning of baseline models to improve performance on downstream tasks or to teach the model large quantities of information which cannot be extracted with few-shot learning or prompt engineering.<br/>
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
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// Datasets API
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// Connectors API
        /// </summary>
        public ConnectorsClient Connectors { get; }

        /// <summary>
        /// Embed Jobs API
        /// </summary>
        public EmbedJobsClient EmbedJobs { get; }

        /// <summary>
        /// Finetuning API (Beta)
        /// </summary>
        public FinetuningClient Finetuning { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

    }
}