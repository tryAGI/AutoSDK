//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API for creating and managing 3D avatars, motions, and scenes<br/>
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
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AssetsClient Assets { get; }

        /// <summary>
        /// 
        /// </summary>
        public AvatarsClient Avatars { get; }

        /// <summary>
        /// 
        /// </summary>
        public AvatarsFromBetasClient AvatarsFromBetas { get; }

        /// <summary>
        /// 
        /// </summary>
        public AvatarsFromImagesClient AvatarsFromImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public AvatarsFromMeasurementsClient AvatarsFromMeasurements { get; }

        /// <summary>
        /// 
        /// </summary>
        public AvatarsFromScansClient AvatarsFromScans { get; }

        /// <summary>
        /// 
        /// </summary>
        public AvatarsFromSmplClient AvatarsFromSmpl { get; }

        /// <summary>
        /// 
        /// </summary>
        public AvatarsFromVideoClient AvatarsFromVideo { get; }

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
        public InfoClient Info { get; }

        /// <summary>
        /// 
        /// </summary>
        public MeshesClient Meshes { get; }

        /// <summary>
        /// 
        /// </summary>
        public MotionsClient Motions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScenesClient Scenes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TeamsClient Teams { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos { get; }

    }
}