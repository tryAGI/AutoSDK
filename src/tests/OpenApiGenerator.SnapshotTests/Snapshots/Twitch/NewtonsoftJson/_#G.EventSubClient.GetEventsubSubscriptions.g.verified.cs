//HintName: G.EventSubClient.GetEventsubSubscriptions.g.cs

#nullable enable

namespace G
{
    public partial class EventSubClient
    {
        /// <summary>
        /// Gets a list of EventSub subscriptions that the client in the access token created.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetEventSubSubscriptionsResponse> GetEventsubSubscriptionsAsync(
            GetEventsubSubscriptionsStatus status,
            GetEventsubSubscriptionsType type,
            string userId,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var statusValue = status switch
            {
                GetEventsubSubscriptionsStatus.Enabled => "enabled",
                GetEventsubSubscriptionsStatus.WebhookCallbackVerificationPending => "webhook_callback_verification_pending",
                GetEventsubSubscriptionsStatus.WebhookCallbackVerificationFailed => "webhook_callback_verification_failed",
                GetEventsubSubscriptionsStatus.NotificationFailuresExceeded => "notification_failures_exceeded",
                GetEventsubSubscriptionsStatus.AuthorizationRevoked => "authorization_revoked",
                GetEventsubSubscriptionsStatus.ModeratorRemoved => "moderator_removed",
                GetEventsubSubscriptionsStatus.UserRemoved => "user_removed",
                GetEventsubSubscriptionsStatus.VersionRemoved => "version_removed",
                GetEventsubSubscriptionsStatus.BetaMaintenance => "beta_maintenance",
                GetEventsubSubscriptionsStatus.WebsocketDisconnected => "websocket_disconnected",
                GetEventsubSubscriptionsStatus.WebsocketFailedPingPong => "websocket_failed_ping_pong",
                GetEventsubSubscriptionsStatus.WebsocketReceivedInboundTraffic => "websocket_received_inbound_traffic",
                GetEventsubSubscriptionsStatus.WebsocketConnectionUnused => "websocket_connection_unused",
                GetEventsubSubscriptionsStatus.WebsocketInternalError => "websocket_internal_error",
                GetEventsubSubscriptionsStatus.WebsocketNetworkTimeout => "websocket_network_timeout",
                GetEventsubSubscriptionsStatus.WebsocketNetworkError => "websocket_network_error",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var typeValue = type switch
            {
                GetEventsubSubscriptionsType.AutomodMessageHold => "automod.message.hold",
                GetEventsubSubscriptionsType.AutomodMessageUpdate => "automod.message.update",
                GetEventsubSubscriptionsType.AutomodSettingsUpdate => "automod.settings.update",
                GetEventsubSubscriptionsType.AutomodTermsUpdate => "automod.terms.update",
                GetEventsubSubscriptionsType.ChannelUpdate => "channel.update",
                GetEventsubSubscriptionsType.ChannelFollow => "channel.follow",
                GetEventsubSubscriptionsType.ChannelAdBreakBegin => "channel.ad_break.begin",
                GetEventsubSubscriptionsType.ChannelChatClear => "channel.chat.clear",
                GetEventsubSubscriptionsType.ChannelChatClearUserMessages => "channel.chat.clear_user_messages",
                GetEventsubSubscriptionsType.ChannelChatMessage => "channel.chat.message",
                GetEventsubSubscriptionsType.ChannelChatMessageDelete => "channel.chat.message_delete",
                GetEventsubSubscriptionsType.ChannelChatNotification => "channel.chat.notification",
                GetEventsubSubscriptionsType.ChannelChatSettingsUpdate => "channel.chat_settings.update",
                GetEventsubSubscriptionsType.ChannelChatUserMessageHold => "channel.chat.user_message_hold",
                GetEventsubSubscriptionsType.ChannelChatUserMessageUpdate => "channel.chat.user_message_update",
                GetEventsubSubscriptionsType.ChannelSubscribe => "channel.subscribe",
                GetEventsubSubscriptionsType.ChannelSubscriptionEnd => "channel.subscription.end",
                GetEventsubSubscriptionsType.ChannelSubscriptionGift => "channel.subscription.gift",
                GetEventsubSubscriptionsType.ChannelSubscriptionMessage => "channel.subscription.message",
                GetEventsubSubscriptionsType.ChannelCheer => "channel.cheer",
                GetEventsubSubscriptionsType.ChannelRaid => "channel.raid",
                GetEventsubSubscriptionsType.ChannelBan => "channel.ban",
                GetEventsubSubscriptionsType.ChannelUnban => "channel.unban",
                GetEventsubSubscriptionsType.ChannelUnbanRequestCreate => "channel.unban_request.create",
                GetEventsubSubscriptionsType.ChannelUnbanRequestResolve => "channel.unban_request.resolve",
                GetEventsubSubscriptionsType.ChannelModerate => "channel.moderate",
                GetEventsubSubscriptionsType.ChannelModeratorAdd => "channel.moderator.add",
                GetEventsubSubscriptionsType.ChannelModeratorRemove => "channel.moderator.remove",
                GetEventsubSubscriptionsType.ChannelGuestStarSessionBegin => "channel.guest_star_session.begin",
                GetEventsubSubscriptionsType.ChannelGuestStarSessionEnd => "channel.guest_star_session.end",
                GetEventsubSubscriptionsType.ChannelGuestStarGuestUpdate => "channel.guest_star_guest.update",
                GetEventsubSubscriptionsType.ChannelGuestStarSettingsUpdate => "channel.guest_star_settings.update",
                GetEventsubSubscriptionsType.ChannelChannelPointsAutomaticRewardAdd => "channel.channel_points_automatic_reward.add",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardAdd => "channel.channel_points_custom_reward.add",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardUpdate => "channel.channel_points_custom_reward.update",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRemove => "channel.channel_points_custom_reward.remove",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRedemptionAdd => "channel.channel_points_custom_reward_redemption.add",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRedemptionUpdate => "channel.channel_points_custom_reward_redemption.update",
                GetEventsubSubscriptionsType.ChannelPollBegin => "channel.poll.begin",
                GetEventsubSubscriptionsType.ChannelPollProgress => "channel.poll.progress",
                GetEventsubSubscriptionsType.ChannelPollEnd => "channel.poll.end",
                GetEventsubSubscriptionsType.ChannelPredictionBegin => "channel.prediction.begin",
                GetEventsubSubscriptionsType.ChannelPredictionProgress => "channel.prediction.progress",
                GetEventsubSubscriptionsType.ChannelPredictionLock => "channel.prediction.lock",
                GetEventsubSubscriptionsType.ChannelPredictionEnd => "channel.prediction.end",
                GetEventsubSubscriptionsType.ChannelVipAdd => "channel.vip.add",
                GetEventsubSubscriptionsType.ChannelVipRemove => "channel.vip.remove",
                GetEventsubSubscriptionsType.ChannelCharityCampaignDonate => "channel.charity_campaign.donate",
                GetEventsubSubscriptionsType.ChannelCharityCampaignStart => "channel.charity_campaign.start",
                GetEventsubSubscriptionsType.ChannelCharityCampaignProgress => "channel.charity_campaign.progress",
                GetEventsubSubscriptionsType.ChannelCharityCampaignStop => "channel.charity_campaign.stop",
                GetEventsubSubscriptionsType.ConduitShardDisabled => "conduit.shard.disabled",
                GetEventsubSubscriptionsType.DropEntitlementGrant => "drop.entitlement.grant",
                GetEventsubSubscriptionsType.ExtensionBitsTransactionCreate => "extension.bits_transaction.create",
                GetEventsubSubscriptionsType.ChannelGoalBegin => "channel.goal.begin",
                GetEventsubSubscriptionsType.ChannelGoalProgress => "channel.goal.progress",
                GetEventsubSubscriptionsType.ChannelGoalEnd => "channel.goal.end",
                GetEventsubSubscriptionsType.ChannelHypeTrainBegin => "channel.hype_train.begin",
                GetEventsubSubscriptionsType.ChannelHypeTrainProgress => "channel.hype_train.progress",
                GetEventsubSubscriptionsType.ChannelHypeTrainEnd => "channel.hype_train.end",
                GetEventsubSubscriptionsType.ChannelShieldModeBegin => "channel.shield_mode.begin",
                GetEventsubSubscriptionsType.ChannelShieldModeEnd => "channel.shield_mode.end",
                GetEventsubSubscriptionsType.ChannelShoutoutCreate => "channel.shoutout.create",
                GetEventsubSubscriptionsType.ChannelShoutoutReceive => "channel.shoutout.receive",
                GetEventsubSubscriptionsType.StreamOnline => "stream.online",
                GetEventsubSubscriptionsType.StreamOffline => "stream.offline",
                GetEventsubSubscriptionsType.UserAuthorizationGrant => "user.authorization.grant",
                GetEventsubSubscriptionsType.UserAuthorizationRevoke => "user.authorization.revoke",
                GetEventsubSubscriptionsType.UserUpdate => "user.update",
                GetEventsubSubscriptionsType.UserWhisperMessage => "user.whisper.message",
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetEventSubSubscriptionsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}