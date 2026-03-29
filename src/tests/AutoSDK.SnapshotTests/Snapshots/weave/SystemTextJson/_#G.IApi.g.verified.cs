//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// W&amp;B Weave API for LLM observability, tracing, evaluations, and datasets<br/>
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
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues { get; }

        /// <summary>
        /// 
        /// </summary>
        public CallsClient Calls { get; }

        /// <summary>
        /// 
        /// </summary>
        public CostsClient Costs { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvalResultsClient EvalResults { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvaluationRunsClient EvaluationRuns { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvaluationsClient Evaluations { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback { get; }

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images { get; }

        /// <summary>
        /// 
        /// </summary>
        public InferenceClient Inference { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObjectsClient Objects { get; }

        /// <summary>
        /// 
        /// </summary>
        public OpenTelemetryClient OpenTelemetry { get; }

        /// <summary>
        /// 
        /// </summary>
        public OpsClient Ops { get; }

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions { get; }

        /// <summary>
        /// 
        /// </summary>
        public RefsClient Refs { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScorersClient Scorers { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScoresClient Scores { get; }

        /// <summary>
        /// 
        /// </summary>
        public ServiceClient Service { get; }

        /// <summary>
        /// 
        /// </summary>
        public TablesClient Tables { get; }

        /// <summary>
        /// 
        /// </summary>
        public ThreadsClient Threads { get; }

    }
}