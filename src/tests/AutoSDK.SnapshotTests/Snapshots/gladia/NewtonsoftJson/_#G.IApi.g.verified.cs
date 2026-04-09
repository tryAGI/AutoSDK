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
        public AudioToTextClient AudioToText { get; }

        /// <summary>
        /// 
        /// </summary>
        public FileManagementClient FileManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public JobHistoryClient JobHistory { get; }

        /// <summary>
        /// 
        /// </summary>
        public LiveV2Client LiveV2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public PreRecordedV2Client PreRecordedV2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionV1Client TranscriptionV1 { get; }

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionV2Client TranscriptionV2 { get; }

    }
}