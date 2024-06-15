//HintName: G.Api.g.cs

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
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// Helix
        /// </summary>
        public const string BaseUrl = "https://api.twitch.tv/helix";

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
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::OpenApiGenerator.JsonConverters.CheermoteTiersIdJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CheermoteTiersIdNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CheermoteTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CheermoteTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionTransactionProductDataCostTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionTransactionProductDataCostTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionTransactionProductTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionTransactionProductTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModifyChannelInformationBodyContentClassificationLabelsIdJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModifyChannelInformationBodyContentClassificationLabelsIdNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomRewardRedemptionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomRewardRedemptionStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateRedemptionStatusBodyStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateRedemptionStatusBodyStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteEmoteTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteEmoteTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteScaleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteScaleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteThemeModeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChannelEmoteThemeModeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteScaleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteScaleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteThemeModeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GlobalEmoteThemeModeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteEmoteTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteEmoteTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteScaleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteScaleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteThemeModeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EmoteThemeModeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetUserEmotesResponseDataEmoteTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetUserEmotesResponseDataEmoteTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SendChatAnnouncementBodyColorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SendChatAnnouncementBodyColorNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetConduitShardsResponseDataTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetConduitShardsResponseDataTransportMethodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetConduitShardsResponseDataStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetConduitShardsResponseDataStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsBodyShardsTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsBodyShardsTransportMethodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsResponseDataTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsResponseDataTransportMethodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsResponseDataStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateConduitShardsResponseDataStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DropsEntitlementFulfillmentStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DropsEntitlementFulfillmentStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateDropsEntitlementsBodyFulfillmentStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateDropsEntitlementsBodyFulfillmentStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DropsEntitlementUpdatedStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DropsEntitlementUpdatedStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionConfigurationSegmentSegmentJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionConfigurationSegmentSegmentNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SetExtensionConfigurationSegmentBodySegmentJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SetExtensionConfigurationSegmentBodySegmentNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SendExtensionPubSubMessageBodyTargetJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SendExtensionPubSubMessageBodyTargetNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionConfigurationLocationJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionConfigurationLocationNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionStateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionStateNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionSubscriptionsSupportLevelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionSubscriptionsSupportLevelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionBitsProductCostTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExtensionBitsProductCostTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateExtensionBitsProductBodyCostTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateExtensionBitsProductBodyCostTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEventSubSubscriptionBodyTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEventSubSubscriptionBodyTransportMethodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEventSubSubscriptionBodyTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEventSubSubscriptionBodyTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionTransportMethodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionTransportMethodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EventSubSubscriptionTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreatorGoalTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreatorGoalTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetChannelGuestStarSettingsResponseGroupLayoutJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetChannelGuestStarSettingsResponseGroupLayoutNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateChannelGuestStarSettingsBodyGroupLayoutJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateChannelGuestStarSettingsBodyGroupLayoutNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.HypeTrainEventEventDataLastContributionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.HypeTrainEventEventDataLastContributionTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.HypeTrainEventEventDataTopContributionsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.HypeTrainEventEventDataTopContributionsTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ManageHeldAutoModMessagesBodyActionJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ManageHeldAutoModMessagesBodyActionNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PollStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PollStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EndPollBodyStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EndPollBodyStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PredictionOutcomeColorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PredictionOutcomeColorNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PredictionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PredictionStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EndPredictionBodyStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EndPredictionBodyStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StreamTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.StreamTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BroadcasterSubscriptionTierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BroadcasterSubscriptionTierNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserSubscriptionTierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserSubscriptionTierNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserBroadcasterTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserBroadcasterTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserExtensionTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UserExtensionTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VideoTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VideoTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetExtensionAnalyticsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetExtensionAnalyticsTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetGameAnalyticsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetGameAnalyticsTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetBitsLeaderboardPeriodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetBitsLeaderboardPeriodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetCustomRewardRedemptionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetCustomRewardRedemptionStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetCustomRewardRedemptionSortJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetCustomRewardRedemptionSortNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateUserChatColorColorJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateUserChatColorColorNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetDropsEntitlementsFulfillmentStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetDropsEntitlementsFulfillmentStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetExtensionConfigurationSegmentSegmentJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetExtensionConfigurationSegmentSegmentNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetEventsubSubscriptionsStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetEventsubSubscriptionsStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetEventsubSubscriptionsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetEventsubSubscriptionsTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetStreamsTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetStreamsTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BlockUserSourceContextJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BlockUserSourceContextNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BlockUserReasonJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BlockUserReasonNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosPeriodJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosPeriodNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosSortJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosSortNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetVideosTypeNullableJsonConverter(),
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