//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Access Forem articles, users and other resources via API.<br/>
    ///         For a real-world example of Forem in action, check out [DEV](https://www.dev.to).<br/>
    ///         All endpoints can be accessed with the 'api-key' header and a accept header, but<br/>
    ///         some of them are accessible publicly without authentication.<br/>
    ///         Dates and date times, unless otherwise specified, must be in<br/>
    ///         the [RFC 3339](https://tools.ietf.org/html/rfc3339) format.<br/>
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
        public ArticlesClient Articles { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments { get; }

        /// <summary>
        /// 
        /// </summary>
        public DisplayAdsClient DisplayAds { get; }

        /// <summary>
        /// 
        /// </summary>
        public FollowedTagsClient FollowedTags { get; }

        /// <summary>
        /// 
        /// </summary>
        public FollowersClient Followers { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public PagesClient Pages { get; }

        /// <summary>
        /// 
        /// </summary>
        public PodcastEpisodesClient PodcastEpisodes { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProfileImagesClient ProfileImages { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReactionsClient Reactions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReadinglistClient Readinglist { get; }

        /// <summary>
        /// 
        /// </summary>
        public TagsClient Tags { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos { get; }

    }
}