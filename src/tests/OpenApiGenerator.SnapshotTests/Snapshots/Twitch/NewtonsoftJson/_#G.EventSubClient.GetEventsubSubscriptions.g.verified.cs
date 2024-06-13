//HintName: G.EventSubClient.GetEventsubSubscriptions.g.cs

#nullable enable

namespace G
{
    public partial class EventSubClient
    {
        /// <summary>
        /// Gets a list of EventSub subscriptions that the client in the access token created.<br/>
        /// Gets a list of EventSub subscriptions that the client in the access token created.<br/>
        /// __Authorization:__<br/>
        /// If you use [Webhooks](https://dev.twitch.tv/docs/eventsub/handling-webhook-events) or [Conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) to receive events, the request must specify an app access token. The request will fail if you use a user access token.<br/>
        /// If you use [WebSockets to receive events](https://dev.twitch.tv/docs/eventsub/handling-websocket-events), the request must specify a user access token. The request will fail if you use an app access token. The token may include any scopes.<br/>
        /// __Request Query Parameters:__<br/>
        /// Use the _status_, _type_, and _user\_id_ query parameters to filter the list of subscriptions that are returned. The filters are mutually exclusive; the request fails if you specify more than one filter.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetEventSubSubscriptionsResponse> GetEventsubSubscriptionsAsync(
            global::G.GetEventsubSubscriptionsStatus status,
            global::G.GetEventsubSubscriptionsType type,
            string userId,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var statusValue = status switch
            {
                global::G.GetEventsubSubscriptionsStatus.Enabled => "enabled",
                global::G.GetEventsubSubscriptionsStatus.WebhookCallbackVerificationPending => "webhook_callback_verification_pending",
                global::G.GetEventsubSubscriptionsStatus.WebhookCallbackVerificationFailed => "webhook_callback_verification_failed",
                global::G.GetEventsubSubscriptionsStatus.NotificationFailuresExceeded => "notification_failures_exceeded",
                global::G.GetEventsubSubscriptionsStatus.AuthorizationRevoked => "authorization_revoked",
                global::G.GetEventsubSubscriptionsStatus.ModeratorRemoved => "moderator_removed",
                global::G.GetEventsubSubscriptionsStatus.UserRemoved => "user_removed",
                global::G.GetEventsubSubscriptionsStatus.VersionRemoved => "version_removed",
                global::G.GetEventsubSubscriptionsStatus.BetaMaintenance => "beta_maintenance",
                global::G.GetEventsubSubscriptionsStatus.WebsocketDisconnected => "websocket_disconnected",
                global::G.GetEventsubSubscriptionsStatus.WebsocketFailedPingPong => "websocket_failed_ping_pong",
                global::G.GetEventsubSubscriptionsStatus.WebsocketReceivedInboundTraffic => "websocket_received_inbound_traffic",
                global::G.GetEventsubSubscriptionsStatus.WebsocketConnectionUnused => "websocket_connection_unused",
                global::G.GetEventsubSubscriptionsStatus.WebsocketInternalError => "websocket_internal_error",
                global::G.GetEventsubSubscriptionsStatus.WebsocketNetworkTimeout => "websocket_network_timeout",
                global::G.GetEventsubSubscriptionsStatus.WebsocketNetworkError => "websocket_network_error",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var typeValue = type switch
            {
                global::G.GetEventsubSubscriptionsType.AutomodMessageHold => "automod.message.hold",
                global::G.GetEventsubSubscriptionsType.AutomodMessageUpdate => "automod.message.update",
                global::G.GetEventsubSubscriptionsType.AutomodSettingsUpdate => "automod.settings.update",
                global::G.GetEventsubSubscriptionsType.AutomodTermsUpdate => "automod.terms.update",
                global::G.GetEventsubSubscriptionsType.ChannelUpdate => "channel.update",
                global::G.GetEventsubSubscriptionsType.ChannelFollow => "channel.follow",
                global::G.GetEventsubSubscriptionsType.ChannelAdBreakBegin => "channel.ad_break.begin",
                global::G.GetEventsubSubscriptionsType.ChannelChatClear => "channel.chat.clear",
                global::G.GetEventsubSubscriptionsType.ChannelChatClearUserMessages => "channel.chat.clear_user_messages",
                global::G.GetEventsubSubscriptionsType.ChannelChatMessage => "channel.chat.message",
                global::G.GetEventsubSubscriptionsType.ChannelChatMessageDelete => "channel.chat.message_delete",
                global::G.GetEventsubSubscriptionsType.ChannelChatNotification => "channel.chat.notification",
                global::G.GetEventsubSubscriptionsType.ChannelChatSettingsUpdate => "channel.chat_settings.update",
                global::G.GetEventsubSubscriptionsType.ChannelChatUserMessageHold => "channel.chat.user_message_hold",
                global::G.GetEventsubSubscriptionsType.ChannelChatUserMessageUpdate => "channel.chat.user_message_update",
                global::G.GetEventsubSubscriptionsType.ChannelSubscribe => "channel.subscribe",
                global::G.GetEventsubSubscriptionsType.ChannelSubscriptionEnd => "channel.subscription.end",
                global::G.GetEventsubSubscriptionsType.ChannelSubscriptionGift => "channel.subscription.gift",
                global::G.GetEventsubSubscriptionsType.ChannelSubscriptionMessage => "channel.subscription.message",
                global::G.GetEventsubSubscriptionsType.ChannelCheer => "channel.cheer",
                global::G.GetEventsubSubscriptionsType.ChannelRaid => "channel.raid",
                global::G.GetEventsubSubscriptionsType.ChannelBan => "channel.ban",
                global::G.GetEventsubSubscriptionsType.ChannelUnban => "channel.unban",
                global::G.GetEventsubSubscriptionsType.ChannelUnbanRequestCreate => "channel.unban_request.create",
                global::G.GetEventsubSubscriptionsType.ChannelUnbanRequestResolve => "channel.unban_request.resolve",
                global::G.GetEventsubSubscriptionsType.ChannelModerate => "channel.moderate",
                global::G.GetEventsubSubscriptionsType.ChannelModeratorAdd => "channel.moderator.add",
                global::G.GetEventsubSubscriptionsType.ChannelModeratorRemove => "channel.moderator.remove",
                global::G.GetEventsubSubscriptionsType.ChannelGuestStarSessionBegin => "channel.guest_star_session.begin",
                global::G.GetEventsubSubscriptionsType.ChannelGuestStarSessionEnd => "channel.guest_star_session.end",
                global::G.GetEventsubSubscriptionsType.ChannelGuestStarGuestUpdate => "channel.guest_star_guest.update",
                global::G.GetEventsubSubscriptionsType.ChannelGuestStarSettingsUpdate => "channel.guest_star_settings.update",
                global::G.GetEventsubSubscriptionsType.ChannelChannelPointsAutomaticRewardAdd => "channel.channel_points_automatic_reward.add",
                global::G.GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardAdd => "channel.channel_points_custom_reward.add",
                global::G.GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardUpdate => "channel.channel_points_custom_reward.update",
                global::G.GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRemove => "channel.channel_points_custom_reward.remove",
                global::G.GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRedemptionAdd => "channel.channel_points_custom_reward_redemption.add",
                global::G.GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRedemptionUpdate => "channel.channel_points_custom_reward_redemption.update",
                global::G.GetEventsubSubscriptionsType.ChannelPollBegin => "channel.poll.begin",
                global::G.GetEventsubSubscriptionsType.ChannelPollProgress => "channel.poll.progress",
                global::G.GetEventsubSubscriptionsType.ChannelPollEnd => "channel.poll.end",
                global::G.GetEventsubSubscriptionsType.ChannelPredictionBegin => "channel.prediction.begin",
                global::G.GetEventsubSubscriptionsType.ChannelPredictionProgress => "channel.prediction.progress",
                global::G.GetEventsubSubscriptionsType.ChannelPredictionLock => "channel.prediction.lock",
                global::G.GetEventsubSubscriptionsType.ChannelPredictionEnd => "channel.prediction.end",
                global::G.GetEventsubSubscriptionsType.ChannelVipAdd => "channel.vip.add",
                global::G.GetEventsubSubscriptionsType.ChannelVipRemove => "channel.vip.remove",
                global::G.GetEventsubSubscriptionsType.ChannelCharityCampaignDonate => "channel.charity_campaign.donate",
                global::G.GetEventsubSubscriptionsType.ChannelCharityCampaignStart => "channel.charity_campaign.start",
                global::G.GetEventsubSubscriptionsType.ChannelCharityCampaignProgress => "channel.charity_campaign.progress",
                global::G.GetEventsubSubscriptionsType.ChannelCharityCampaignStop => "channel.charity_campaign.stop",
                global::G.GetEventsubSubscriptionsType.ConduitShardDisabled => "conduit.shard.disabled",
                global::G.GetEventsubSubscriptionsType.DropEntitlementGrant => "drop.entitlement.grant",
                global::G.GetEventsubSubscriptionsType.ExtensionBitsTransactionCreate => "extension.bits_transaction.create",
                global::G.GetEventsubSubscriptionsType.ChannelGoalBegin => "channel.goal.begin",
                global::G.GetEventsubSubscriptionsType.ChannelGoalProgress => "channel.goal.progress",
                global::G.GetEventsubSubscriptionsType.ChannelGoalEnd => "channel.goal.end",
                global::G.GetEventsubSubscriptionsType.ChannelHypeTrainBegin => "channel.hype_train.begin",
                global::G.GetEventsubSubscriptionsType.ChannelHypeTrainProgress => "channel.hype_train.progress",
                global::G.GetEventsubSubscriptionsType.ChannelHypeTrainEnd => "channel.hype_train.end",
                global::G.GetEventsubSubscriptionsType.ChannelShieldModeBegin => "channel.shield_mode.begin",
                global::G.GetEventsubSubscriptionsType.ChannelShieldModeEnd => "channel.shield_mode.end",
                global::G.GetEventsubSubscriptionsType.ChannelShoutoutCreate => "channel.shoutout.create",
                global::G.GetEventsubSubscriptionsType.ChannelShoutoutReceive => "channel.shoutout.receive",
                global::G.GetEventsubSubscriptionsType.StreamOnline => "stream.online",
                global::G.GetEventsubSubscriptionsType.StreamOffline => "stream.offline",
                global::G.GetEventsubSubscriptionsType.UserAuthorizationGrant => "user.authorization.grant",
                global::G.GetEventsubSubscriptionsType.UserAuthorizationRevoke => "user.authorization.revoke",
                global::G.GetEventsubSubscriptionsType.UserUpdate => "user.update",
                global::G.GetEventsubSubscriptionsType.UserWhisperMessage => "user.whisper.message",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/eventsub/subscriptions?status={statusValue}&type={typeValue}&user_id={userId}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetEventSubSubscriptionsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}