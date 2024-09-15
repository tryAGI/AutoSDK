//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unofficial Swagger UI for Twitch API.<br/>
    /// All endpoints are generated automatically from the [twitch docs](https://dev.twitch.tv/docs/api/reference) page.<br/>
    /// __Features:__<br/>
    /// * Swagger UI for all Twitch API endpoints<br/>
    /// * Schemas for _Request Query Parameters_, _Request Body_, _Response Body_<br/>
    /// * Some additional schemas like _Clip_, _ChatBadge_, _Prediction_, _Game_, _Channel_, _Video_ etc.<br/>
    /// * Response codes and examples<br/>
    /// * Generated types for TypeScript: [ts-twitch-api](https://github.com/DmitryScaletta/ts-twitch-api)<br/>
    /// __Repository:__ [github.com/DmitryScaletta/twitch-api-swagger](https://github.com/DmitryScaletta/twitch-api-swagger)<br/>
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
        /// 
        /// </summary>
        public AdsClient Ads { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics { get; }

        /// <summary>
        /// 
        /// </summary>
        public BitsClient Bits { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChannelsClient Channels { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChannelPointsClient ChannelPoints { get; }

        /// <summary>
        /// 
        /// </summary>
        public CharityClient Charity { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClipsClient Clips { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConduitsClient Conduits { get; }

        /// <summary>
        /// 
        /// </summary>
        public CCLsClient CCLs { get; }

        /// <summary>
        /// 
        /// </summary>
        public EntitlementsClient Entitlements { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExtensionsClient Extensions { get; }

        /// <summary>
        /// 
        /// </summary>
        public EventSubClient EventSub { get; }

        /// <summary>
        /// 
        /// </summary>
        public GamesClient Games { get; }

        /// <summary>
        /// 
        /// </summary>
        public GoalsClient Goals { get; }

        /// <summary>
        /// 
        /// </summary>
        public GuestStarClient GuestStar { get; }

        /// <summary>
        /// 
        /// </summary>
        public HypeTrainClient HypeTrain { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModerationClient Moderation { get; }

        /// <summary>
        /// 
        /// </summary>
        public PollsClient Polls { get; }

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions { get; }

        /// <summary>
        /// 
        /// </summary>
        public RaidsClient Raids { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScheduleClient Schedule { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// 
        /// </summary>
        public StreamsClient Streams { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TagsClient Tags { get; }

        /// <summary>
        /// 
        /// </summary>
        public TeamsClient Teams { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos { get; }

        /// <summary>
        /// 
        /// </summary>
        public WhispersClient Whispers { get; }

    }
}