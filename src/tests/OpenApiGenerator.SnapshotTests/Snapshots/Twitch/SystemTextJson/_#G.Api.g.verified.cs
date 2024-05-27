//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unofficial Swagger UI for Twitch API.
    /// All endpoints are generated automatically from the [twitch docs](https://dev.twitch.tv/docs/api/reference) page.
    /// __Features:__
    /// * Swagger UI for all Twitch API endpoints
    /// * Schemas for _Request Query Parameters_, _Request Body_, _Response Body_
    /// * Some additional schemas like _Clip_, _ChatBadge_, _Prediction_, _Game_, _Channel_, _Video_ etc.
    /// * Response codes and examples
    /// * Generated types for TypeScript: [ts-twitch-api](https://github.com/DmitryScaletta/ts-twitch-api)
    /// __Repository:__ [github.com/DmitryScaletta/twitch-api-swagger](https://github.com/DmitryScaletta/twitch-api-swagger)
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        public AdsClient Ads => new AdsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics => new AnalyticsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public BitsClient Bits => new BitsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ChannelsClient Channels => new ChannelsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ChannelPointsClient ChannelPoints => new ChannelPointsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public CharityClient Charity => new CharityClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ClipsClient Clips => new ClipsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ConduitsClient Conduits => new ConduitsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public CCLsClient CCLs => new CCLsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public EntitlementsClient Entitlements => new EntitlementsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ExtensionsClient Extensions => new ExtensionsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public EventSubClient EventSub => new EventSubClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public GamesClient Games => new GamesClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public GoalsClient Goals => new GoalsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public GuestStarClient GuestStar => new GuestStarClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public HypeTrainClient HypeTrain => new HypeTrainClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ModerationClient Moderation => new ModerationClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public PollsClient Polls => new PollsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions => new PredictionsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public RaidsClient Raids => new RaidsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ScheduleClient Schedule => new ScheduleClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search => new SearchClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public StreamsClient Streams => new StreamsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions => new SubscriptionsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public TagsClient Tags => new TagsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public TeamsClient Teams => new TeamsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos => new VideosClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public WhispersClient Whispers => new WhispersClient(_httpClient);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://api.twitch.tv/helix");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}