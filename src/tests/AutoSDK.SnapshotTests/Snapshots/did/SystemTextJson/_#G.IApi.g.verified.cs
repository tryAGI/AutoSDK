//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// D-ID API for creating talking avatar videos, AI agents, streaming conversations, and animations.<br/>
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
        public AgentsClient Agents { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentsStreamsClient AgentsStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnimationsClient Animations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudiosClient Audios { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatsExportClient ChatsExport { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClientKeysClient ClientKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClipsPremiumAvatarsClient ClipsPremiumAvatars { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClipsStreamsClient ClipsStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConsentsClient Consents { get; }

        /// <summary>
        /// 
        /// </summary>
        public CreditsClient Credits { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images { get; }

        /// <summary>
        /// 
        /// </summary>
        public KnowledgeClient Knowledge { get; }

        /// <summary>
        /// 
        /// </summary>
        public RatingsClient Ratings { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScenesExpressAvatarsClient ScenesExpressAvatars { get; }

        /// <summary>
        /// 
        /// </summary>
        public SecretsClient Secrets { get; }

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings { get; }

        /// <summary>
        /// 
        /// </summary>
        public TalksStandardAvatarsClient TalksStandardAvatars { get; }

        /// <summary>
        /// 
        /// </summary>
        public TalksStreamsClient TalksStreams { get; }

        /// <summary>
        /// 
        /// </summary>
        public V4AvatarsClient V4Avatars { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoTranslateClient VideoTranslate { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices { get; }

    }
}