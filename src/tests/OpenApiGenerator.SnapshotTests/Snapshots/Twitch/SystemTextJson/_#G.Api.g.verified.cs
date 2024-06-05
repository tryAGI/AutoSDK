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
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// 
        /// </summary>
        public AdsClient Ads => new AdsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics => new AnalyticsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public BitsClient Bits => new BitsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ChannelsClient Channels => new ChannelsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ChannelPointsClient ChannelPoints => new ChannelPointsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public CharityClient Charity => new CharityClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ClipsClient Clips => new ClipsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ConduitsClient Conduits => new ConduitsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public CCLsClient CCLs => new CCLsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public EntitlementsClient Entitlements => new EntitlementsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ExtensionsClient Extensions => new ExtensionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public EventSubClient EventSub => new EventSubClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public GamesClient Games => new GamesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public GoalsClient Goals => new GoalsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public GuestStarClient GuestStar => new GuestStarClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public HypeTrainClient HypeTrain => new HypeTrainClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ModerationClient Moderation => new ModerationClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public PollsClient Polls => new PollsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions => new PredictionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public RaidsClient Raids => new RaidsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ScheduleClient Schedule => new ScheduleClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search => new SearchClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public StreamsClient Streams => new StreamsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions => new SubscriptionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public TagsClient Tags => new TagsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public TeamsClient Teams => new TeamsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos => new VideosClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public WhispersClient Whispers => new WhispersClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://api.twitch.tv/helix");
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::OpenApiGenerator.JsonConverters.CheermoteTiersIdJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CheermoteTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionTransactionProductDataCostTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionTransactionProductTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModifyChannelInformationBodyContentClassificationLabelsIdJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomRewardRedemptionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateRedemptionStatusBodyStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteEmoteTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteScaleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteThemeModeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteScaleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteThemeModeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteEmoteTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteScaleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteThemeModeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetUserEmotesResponseDataEmoteTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SendChatAnnouncementBodyColorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetConduitShardsResponseDataTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetConduitShardsResponseDataStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsBodyShardsTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsResponseDataTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsResponseDataStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DropsEntitlementFulfillmentStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateDropsEntitlementsBodyFulfillmentStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DropsEntitlementUpdatedStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionConfigurationSegmentSegmentJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SetExtensionConfigurationSegmentBodySegmentJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SendExtensionPubSubMessageBodyTargetJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionConfigurationLocationJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionStateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionSubscriptionsSupportLevelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionBitsProductCostTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateExtensionBitsProductBodyCostTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEventSubSubscriptionBodyTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEventSubSubscriptionBodyTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreatorGoalTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetChannelGuestStarSettingsResponseGroupLayoutJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateChannelGuestStarSettingsBodyGroupLayoutJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.HypeTrainEventEventDataLastContributionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.HypeTrainEventEventDataTopContributionsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ManageHeldAutoModMessagesBodyActionJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PollStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EndPollBodyStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PredictionOutcomeColorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PredictionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EndPredictionBodyStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StreamTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BroadcasterSubscriptionTierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserSubscriptionTierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserBroadcasterTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserExtensionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VideoTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetExtensionAnalyticsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetGameAnalyticsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetBitsLeaderboardPeriodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetCustomRewardRedemptionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetCustomRewardRedemptionSortJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateUserChatColorColorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetDropsEntitlementsFulfillmentStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetExtensionConfigurationSegmentSegmentJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetEventsubSubscriptionsStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetEventsubSubscriptionsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetStreamsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BlockUserSourceContextJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BlockUserReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosPeriodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosSortJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosTypeJsonConverter(),
                }
            };
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}