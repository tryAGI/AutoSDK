//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
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
        /// 
        /// </summary>
        public BetaClient Beta { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClassifierClient Classifier { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataSinksClient DataSinks { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataSourcesClient DataSources { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingModelConfigsClient EmbeddingModelConfigs { get; }

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlamaExtractClient LlamaExtract { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public PageFiguresClient PageFigures { get; }

        /// <summary>
        /// 
        /// </summary>
        public PageScreenshotsClient PageScreenshots { get; }

        /// <summary>
        /// 
        /// </summary>
        public ParsingClient Parsing { get; }

        /// <summary>
        /// 
        /// </summary>
        public PipelineDataSourcesClient PipelineDataSources { get; }

        /// <summary>
        /// 
        /// </summary>
        public PipelineFilesClient PipelineFiles { get; }

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public RetrieversClient Retrievers { get; }

        /// <summary>
        /// 
        /// </summary>
        public V2Client V2 { get; }

    }
}