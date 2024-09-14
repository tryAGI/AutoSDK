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

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.CheermoteTierIdJsonConverter(),
                    new global::G.JsonConverters.CheermoteTierIdNullableJsonConverter(),
                    new global::G.JsonConverters.CheermoteTypeJsonConverter(),
                    new global::G.JsonConverters.CheermoteTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ExtensionTransactionProductTypeJsonConverter(),
                    new global::G.JsonConverters.ExtensionTransactionProductTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ExtensionTransactionProductDataCostTypeJsonConverter(),
                    new global::G.JsonConverters.ExtensionTransactionProductDataCostTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModifyChannelInformationBodyContentClassificationLabelIdJsonConverter(),
                    new global::G.JsonConverters.ModifyChannelInformationBodyContentClassificationLabelIdNullableJsonConverter(),
                    new global::G.JsonConverters.CustomRewardRedemptionStatusJsonConverter(),
                    new global::G.JsonConverters.CustomRewardRedemptionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateRedemptionStatusBodyStatusJsonConverter(),
                    new global::G.JsonConverters.UpdateRedemptionStatusBodyStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ChannelEmoteEmoteTypeJsonConverter(),
                    new global::G.JsonConverters.ChannelEmoteEmoteTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChannelEmoteFormatItemJsonConverter(),
                    new global::G.JsonConverters.ChannelEmoteFormatItemNullableJsonConverter(),
                    new global::G.JsonConverters.ChannelEmoteScaleItemJsonConverter(),
                    new global::G.JsonConverters.ChannelEmoteScaleItemNullableJsonConverter(),
                    new global::G.JsonConverters.ChannelEmoteThemeModeItemJsonConverter(),
                    new global::G.JsonConverters.ChannelEmoteThemeModeItemNullableJsonConverter(),
                    new global::G.JsonConverters.GlobalEmoteFormatItemJsonConverter(),
                    new global::G.JsonConverters.GlobalEmoteFormatItemNullableJsonConverter(),
                    new global::G.JsonConverters.GlobalEmoteScaleItemJsonConverter(),
                    new global::G.JsonConverters.GlobalEmoteScaleItemNullableJsonConverter(),
                    new global::G.JsonConverters.GlobalEmoteThemeModeItemJsonConverter(),
                    new global::G.JsonConverters.GlobalEmoteThemeModeItemNullableJsonConverter(),
                    new global::G.JsonConverters.EmoteEmoteTypeJsonConverter(),
                    new global::G.JsonConverters.EmoteEmoteTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmoteFormatItemJsonConverter(),
                    new global::G.JsonConverters.EmoteFormatItemNullableJsonConverter(),
                    new global::G.JsonConverters.EmoteScaleItemJsonConverter(),
                    new global::G.JsonConverters.EmoteScaleItemNullableJsonConverter(),
                    new global::G.JsonConverters.EmoteThemeModeItemJsonConverter(),
                    new global::G.JsonConverters.EmoteThemeModeItemNullableJsonConverter(),
                    new global::G.JsonConverters.GetUserEmotesResponseDataItemEmoteTypeJsonConverter(),
                    new global::G.JsonConverters.GetUserEmotesResponseDataItemEmoteTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SendChatAnnouncementBodyColorJsonConverter(),
                    new global::G.JsonConverters.SendChatAnnouncementBodyColorNullableJsonConverter(),
                    new global::G.JsonConverters.GetConduitShardsResponseDataItemStatusJsonConverter(),
                    new global::G.JsonConverters.GetConduitShardsResponseDataItemStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetConduitShardsResponseDataItemTransportMethodJsonConverter(),
                    new global::G.JsonConverters.GetConduitShardsResponseDataItemTransportMethodNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateConduitShardsBodyShardTransportMethodJsonConverter(),
                    new global::G.JsonConverters.UpdateConduitShardsBodyShardTransportMethodNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateConduitShardsResponseDataItemStatusJsonConverter(),
                    new global::G.JsonConverters.UpdateConduitShardsResponseDataItemStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateConduitShardsResponseDataItemTransportMethodJsonConverter(),
                    new global::G.JsonConverters.UpdateConduitShardsResponseDataItemTransportMethodNullableJsonConverter(),
                    new global::G.JsonConverters.DropsEntitlementFulfillmentStatusJsonConverter(),
                    new global::G.JsonConverters.DropsEntitlementFulfillmentStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateDropsEntitlementsBodyFulfillmentStatusJsonConverter(),
                    new global::G.JsonConverters.UpdateDropsEntitlementsBodyFulfillmentStatusNullableJsonConverter(),
                    new global::G.JsonConverters.DropsEntitlementUpdatedStatusJsonConverter(),
                    new global::G.JsonConverters.DropsEntitlementUpdatedStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ExtensionConfigurationSegmentSegmentJsonConverter(),
                    new global::G.JsonConverters.ExtensionConfigurationSegmentSegmentNullableJsonConverter(),
                    new global::G.JsonConverters.SetExtensionConfigurationSegmentBodySegmentJsonConverter(),
                    new global::G.JsonConverters.SetExtensionConfigurationSegmentBodySegmentNullableJsonConverter(),
                    new global::G.JsonConverters.SendExtensionPubSubMessageBodyTargetItemJsonConverter(),
                    new global::G.JsonConverters.SendExtensionPubSubMessageBodyTargetItemNullableJsonConverter(),
                    new global::G.JsonConverters.ExtensionConfigurationLocationJsonConverter(),
                    new global::G.JsonConverters.ExtensionConfigurationLocationNullableJsonConverter(),
                    new global::G.JsonConverters.ExtensionStateJsonConverter(),
                    new global::G.JsonConverters.ExtensionStateNullableJsonConverter(),
                    new global::G.JsonConverters.ExtensionSubscriptionsSupportLevelJsonConverter(),
                    new global::G.JsonConverters.ExtensionSubscriptionsSupportLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ExtensionBitsProductCostTypeJsonConverter(),
                    new global::G.JsonConverters.ExtensionBitsProductCostTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateExtensionBitsProductBodyCostTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateExtensionBitsProductBodyCostTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEventSubSubscriptionBodyTypeJsonConverter(),
                    new global::G.JsonConverters.CreateEventSubSubscriptionBodyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEventSubSubscriptionBodyTransportMethodJsonConverter(),
                    new global::G.JsonConverters.CreateEventSubSubscriptionBodyTransportMethodNullableJsonConverter(),
                    new global::G.JsonConverters.EventSubSubscriptionStatusJsonConverter(),
                    new global::G.JsonConverters.EventSubSubscriptionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EventSubSubscriptionTypeJsonConverter(),
                    new global::G.JsonConverters.EventSubSubscriptionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EventSubSubscriptionTransportMethodJsonConverter(),
                    new global::G.JsonConverters.EventSubSubscriptionTransportMethodNullableJsonConverter(),
                    new global::G.JsonConverters.CreatorGoalTypeJsonConverter(),
                    new global::G.JsonConverters.CreatorGoalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetChannelGuestStarSettingsResponseGroupLayoutJsonConverter(),
                    new global::G.JsonConverters.GetChannelGuestStarSettingsResponseGroupLayoutNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateChannelGuestStarSettingsBodyGroupLayoutJsonConverter(),
                    new global::G.JsonConverters.UpdateChannelGuestStarSettingsBodyGroupLayoutNullableJsonConverter(),
                    new global::G.JsonConverters.HypeTrainEventEventDataLastContributionTypeJsonConverter(),
                    new global::G.JsonConverters.HypeTrainEventEventDataLastContributionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.HypeTrainEventEventDataTopContributionTypeJsonConverter(),
                    new global::G.JsonConverters.HypeTrainEventEventDataTopContributionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ManageHeldAutoModMessagesBodyActionJsonConverter(),
                    new global::G.JsonConverters.ManageHeldAutoModMessagesBodyActionNullableJsonConverter(),
                    new global::G.JsonConverters.PollStatusJsonConverter(),
                    new global::G.JsonConverters.PollStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EndPollBodyStatusJsonConverter(),
                    new global::G.JsonConverters.EndPollBodyStatusNullableJsonConverter(),
                    new global::G.JsonConverters.PredictionOutcomeColorJsonConverter(),
                    new global::G.JsonConverters.PredictionOutcomeColorNullableJsonConverter(),
                    new global::G.JsonConverters.PredictionStatusJsonConverter(),
                    new global::G.JsonConverters.PredictionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EndPredictionBodyStatusJsonConverter(),
                    new global::G.JsonConverters.EndPredictionBodyStatusNullableJsonConverter(),
                    new global::G.JsonConverters.StreamTypeJsonConverter(),
                    new global::G.JsonConverters.StreamTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BroadcasterSubscriptionTierJsonConverter(),
                    new global::G.JsonConverters.BroadcasterSubscriptionTierNullableJsonConverter(),
                    new global::G.JsonConverters.UserSubscriptionTierJsonConverter(),
                    new global::G.JsonConverters.UserSubscriptionTierNullableJsonConverter(),
                    new global::G.JsonConverters.UserTypeJsonConverter(),
                    new global::G.JsonConverters.UserTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UserBroadcasterTypeJsonConverter(),
                    new global::G.JsonConverters.UserBroadcasterTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UserExtensionTypeItemJsonConverter(),
                    new global::G.JsonConverters.UserExtensionTypeItemNullableJsonConverter(),
                    new global::G.JsonConverters.VideoTypeJsonConverter(),
                    new global::G.JsonConverters.VideoTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetExtensionAnalyticsTypeJsonConverter(),
                    new global::G.JsonConverters.GetExtensionAnalyticsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetGameAnalyticsTypeJsonConverter(),
                    new global::G.JsonConverters.GetGameAnalyticsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetBitsLeaderboardPeriodJsonConverter(),
                    new global::G.JsonConverters.GetBitsLeaderboardPeriodNullableJsonConverter(),
                    new global::G.JsonConverters.GetCustomRewardRedemptionStatusJsonConverter(),
                    new global::G.JsonConverters.GetCustomRewardRedemptionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetCustomRewardRedemptionSortJsonConverter(),
                    new global::G.JsonConverters.GetCustomRewardRedemptionSortNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateUserChatColorColorJsonConverter(),
                    new global::G.JsonConverters.UpdateUserChatColorColorNullableJsonConverter(),
                    new global::G.JsonConverters.GetDropsEntitlementsFulfillmentStatusJsonConverter(),
                    new global::G.JsonConverters.GetDropsEntitlementsFulfillmentStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetExtensionConfigurationSegmentSegmentJsonConverter(),
                    new global::G.JsonConverters.GetExtensionConfigurationSegmentSegmentNullableJsonConverter(),
                    new global::G.JsonConverters.GetEventsubSubscriptionsStatusJsonConverter(),
                    new global::G.JsonConverters.GetEventsubSubscriptionsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetEventsubSubscriptionsTypeJsonConverter(),
                    new global::G.JsonConverters.GetEventsubSubscriptionsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetStreamsTypeJsonConverter(),
                    new global::G.JsonConverters.GetStreamsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BlockUserSourceContextJsonConverter(),
                    new global::G.JsonConverters.BlockUserSourceContextNullableJsonConverter(),
                    new global::G.JsonConverters.BlockUserReasonJsonConverter(),
                    new global::G.JsonConverters.BlockUserReasonNullableJsonConverter(),
                    new global::G.JsonConverters.GetVideosPeriodJsonConverter(),
                    new global::G.JsonConverters.GetVideosPeriodNullableJsonConverter(),
                    new global::G.JsonConverters.GetVideosSortJsonConverter(),
                    new global::G.JsonConverters.GetVideosSortNullableJsonConverter(),
                    new global::G.JsonConverters.GetVideosTypeJsonConverter(),
                    new global::G.JsonConverters.GetVideosTypeNullableJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public AdsClient Ads => new AdsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics => new AnalyticsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BitsClient Bits => new BitsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChannelsClient Channels => new ChannelsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChannelPointsClient ChannelPoints => new ChannelPointsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CharityClient Charity => new CharityClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClipsClient Clips => new ClipsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConduitsClient Conduits => new ConduitsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CCLsClient CCLs => new CCLsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EntitlementsClient Entitlements => new EntitlementsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExtensionsClient Extensions => new ExtensionsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EventSubClient EventSub => new EventSubClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GamesClient Games => new GamesClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GoalsClient Goals => new GoalsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GuestStarClient GuestStar => new GuestStarClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HypeTrainClient HypeTrain => new HypeTrainClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModerationClient Moderation => new ModerationClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PollsClient Polls => new PollsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions => new PredictionsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RaidsClient Raids => new RaidsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScheduleClient Schedule => new ScheduleClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search => new SearchClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StreamsClient Streams => new StreamsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions => new SubscriptionsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TagsClient Tags => new TagsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TeamsClient Teams => new TeamsClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos => new VideosClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WhispersClient Whispers => new WhispersClient(_httpClient)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

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
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

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