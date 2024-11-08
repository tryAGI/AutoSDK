//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Access our powerful language models using an API that makes you smile<br/>
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
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public JambaCompleteClient JambaComplete { get; }

        /// <summary>
        /// 
        /// </summary>
        public CompletionClient Completion { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomModelsClient CustomModels { get; }

        /// <summary>
        /// 
        /// </summary>
        public ParaphraseClient Paraphrase { get; }

        /// <summary>
        /// 
        /// </summary>
        public SummarizeClient Summarize { get; }

        /// <summary>
        /// 
        /// </summary>
        public SegmentationClient Segmentation { get; }

        /// <summary>
        /// 
        /// </summary>
        public LibraryManagementClient LibraryManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public RAGEngineClient RAGEngine { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat { get; }

    }
}