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
                    new global::AutoSDK.JsonConverters.CheermoteTierIdJsonConverter(),
                    new global::AutoSDK.JsonConverters.CheermoteTierIdNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CheermoteTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CheermoteTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionTransactionProductTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionTransactionProductTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionTransactionProductDataCostTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionTransactionProductDataCostTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModifyChannelInformationBodyContentClassificationLabelIdJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModifyChannelInformationBodyContentClassificationLabelIdNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomRewardRedemptionStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomRewardRedemptionStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateRedemptionStatusBodyStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateRedemptionStatusBodyStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChannelEmoteEmoteTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChannelEmoteEmoteTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChannelEmoteFormatItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChannelEmoteFormatItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChannelEmoteScaleItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChannelEmoteScaleItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChannelEmoteThemeModeItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChannelEmoteThemeModeItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GlobalEmoteFormatItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.GlobalEmoteFormatItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GlobalEmoteScaleItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.GlobalEmoteScaleItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GlobalEmoteThemeModeItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.GlobalEmoteThemeModeItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmoteEmoteTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmoteEmoteTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmoteFormatItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmoteFormatItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmoteScaleItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmoteScaleItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmoteThemeModeItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.EmoteThemeModeItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetUserEmotesResponseDataItemEmoteTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetUserEmotesResponseDataItemEmoteTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SendChatAnnouncementBodyColorJsonConverter(),
                    new global::AutoSDK.JsonConverters.SendChatAnnouncementBodyColorNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetConduitShardsResponseDataItemStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetConduitShardsResponseDataItemStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetConduitShardsResponseDataItemTransportMethodJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetConduitShardsResponseDataItemTransportMethodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateConduitShardsBodyShardTransportMethodJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateConduitShardsBodyShardTransportMethodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateConduitShardsResponseDataItemStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateConduitShardsResponseDataItemStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateConduitShardsResponseDataItemTransportMethodJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateConduitShardsResponseDataItemTransportMethodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DropsEntitlementFulfillmentStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.DropsEntitlementFulfillmentStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateDropsEntitlementsBodyFulfillmentStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateDropsEntitlementsBodyFulfillmentStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DropsEntitlementUpdatedStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.DropsEntitlementUpdatedStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionConfigurationSegmentSegmentJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionConfigurationSegmentSegmentNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SetExtensionConfigurationSegmentBodySegmentJsonConverter(),
                    new global::AutoSDK.JsonConverters.SetExtensionConfigurationSegmentBodySegmentNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SendExtensionPubSubMessageBodyTargetItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.SendExtensionPubSubMessageBodyTargetItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionConfigurationLocationJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionConfigurationLocationNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionStateJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionStateNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionSubscriptionsSupportLevelJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionSubscriptionsSupportLevelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionBitsProductCostTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExtensionBitsProductCostTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateExtensionBitsProductBodyCostTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateExtensionBitsProductBodyCostTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEventSubSubscriptionBodyTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEventSubSubscriptionBodyTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEventSubSubscriptionBodyTransportMethodJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEventSubSubscriptionBodyTransportMethodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EventSubSubscriptionStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.EventSubSubscriptionStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EventSubSubscriptionTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.EventSubSubscriptionTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EventSubSubscriptionTransportMethodJsonConverter(),
                    new global::AutoSDK.JsonConverters.EventSubSubscriptionTransportMethodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreatorGoalTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreatorGoalTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetChannelGuestStarSettingsResponseGroupLayoutJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetChannelGuestStarSettingsResponseGroupLayoutNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateChannelGuestStarSettingsBodyGroupLayoutJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateChannelGuestStarSettingsBodyGroupLayoutNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.HypeTrainEventEventDataLastContributionTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.HypeTrainEventEventDataLastContributionTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.HypeTrainEventEventDataTopContributionTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.HypeTrainEventEventDataTopContributionTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ManageHeldAutoModMessagesBodyActionJsonConverter(),
                    new global::AutoSDK.JsonConverters.ManageHeldAutoModMessagesBodyActionNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.PollStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.PollStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EndPollBodyStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.EndPollBodyStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.PredictionOutcomeColorJsonConverter(),
                    new global::AutoSDK.JsonConverters.PredictionOutcomeColorNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.PredictionStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.PredictionStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EndPredictionBodyStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.EndPredictionBodyStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.StreamTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.StreamTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.BroadcasterSubscriptionTierJsonConverter(),
                    new global::AutoSDK.JsonConverters.BroadcasterSubscriptionTierNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserSubscriptionTierJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserSubscriptionTierNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserBroadcasterTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserBroadcasterTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserExtensionTypeItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.UserExtensionTypeItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VideoTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.VideoTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetExtensionAnalyticsTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetExtensionAnalyticsTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetGameAnalyticsTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetGameAnalyticsTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetBitsLeaderboardPeriodJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetBitsLeaderboardPeriodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetCustomRewardRedemptionStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetCustomRewardRedemptionStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetCustomRewardRedemptionSortJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetCustomRewardRedemptionSortNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateUserChatColorColorJsonConverter(),
                    new global::AutoSDK.JsonConverters.UpdateUserChatColorColorNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetDropsEntitlementsFulfillmentStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetDropsEntitlementsFulfillmentStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetExtensionConfigurationSegmentSegmentJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetExtensionConfigurationSegmentSegmentNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetEventsubSubscriptionsStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetEventsubSubscriptionsStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetEventsubSubscriptionsTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetEventsubSubscriptionsTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetStreamsTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetStreamsTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.BlockUserSourceContextJsonConverter(),
                    new global::AutoSDK.JsonConverters.BlockUserSourceContextNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.BlockUserReasonJsonConverter(),
                    new global::AutoSDK.JsonConverters.BlockUserReasonNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetVideosPeriodJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetVideosPeriodNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetVideosSortJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetVideosSortNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetVideosTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.GetVideosTypeNullableJsonConverter(),
                }
            };

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}