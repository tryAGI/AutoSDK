//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API for AI-powered 3D and 2D content generation<br/>
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
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AnimationClient Animation { get; }

        /// <summary>
        /// 
        /// </summary>
        public BalanceClient Balance { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageTo3dClient ImageTo3d { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageToImageClient ImageToImage { get; }

        /// <summary>
        /// 
        /// </summary>
        public MultiImageTo3dClient MultiImageTo3d { get; }

        /// <summary>
        /// 
        /// </summary>
        public RemeshClient Remesh { get; }

        /// <summary>
        /// 
        /// </summary>
        public RetextureClient Retexture { get; }

        /// <summary>
        /// 
        /// </summary>
        public RiggingClient Rigging { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextTo3dClient TextTo3d { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToImageClient TextToImage { get; }

    }
}