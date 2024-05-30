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
                GetEventsubSubscriptionsType.Automodmessagehold => "automod.message.hold",
                GetEventsubSubscriptionsType.Automodmessageupdate => "automod.message.update",
                GetEventsubSubscriptionsType.Automodsettingsupdate => "automod.settings.update",
                GetEventsubSubscriptionsType.Automodtermsupdate => "automod.terms.update",
                GetEventsubSubscriptionsType.Channelupdate => "channel.update",
                GetEventsubSubscriptionsType.Channelfollow => "channel.follow",
                GetEventsubSubscriptionsType.ChanneladBreakbegin => "channel.ad_break.begin",
                GetEventsubSubscriptionsType.Channelchatclear => "channel.chat.clear",
                GetEventsubSubscriptionsType.ChannelchatclearUserMessages => "channel.chat.clear_user_messages",
                GetEventsubSubscriptionsType.Channelchatmessage => "channel.chat.message",
                GetEventsubSubscriptionsType.ChannelchatmessageDelete => "channel.chat.message_delete",
                GetEventsubSubscriptionsType.Channelchatnotification => "channel.chat.notification",
                GetEventsubSubscriptionsType.ChannelchatSettingsupdate => "channel.chat_settings.update",
                GetEventsubSubscriptionsType.ChannelchatuserMessageHold => "channel.chat.user_message_hold",
                GetEventsubSubscriptionsType.ChannelchatuserMessageUpdate => "channel.chat.user_message_update",
                GetEventsubSubscriptionsType.Channelsubscribe => "channel.subscribe",
                GetEventsubSubscriptionsType.Channelsubscriptionend => "channel.subscription.end",
                GetEventsubSubscriptionsType.Channelsubscriptiongift => "channel.subscription.gift",
                GetEventsubSubscriptionsType.Channelsubscriptionmessage => "channel.subscription.message",
                GetEventsubSubscriptionsType.Channelcheer => "channel.cheer",
                GetEventsubSubscriptionsType.Channelraid => "channel.raid",
                GetEventsubSubscriptionsType.Channelban => "channel.ban",
                GetEventsubSubscriptionsType.Channelunban => "channel.unban",
                GetEventsubSubscriptionsType.ChannelunbanRequestcreate => "channel.unban_request.create",
                GetEventsubSubscriptionsType.ChannelunbanRequestresolve => "channel.unban_request.resolve",
                GetEventsubSubscriptionsType.Channelmoderate => "channel.moderate",
                GetEventsubSubscriptionsType.Channelmoderatoradd => "channel.moderator.add",
                GetEventsubSubscriptionsType.Channelmoderatorremove => "channel.moderator.remove",
                GetEventsubSubscriptionsType.ChannelguestStarSessionbegin => "channel.guest_star_session.begin",
                GetEventsubSubscriptionsType.ChannelguestStarSessionend => "channel.guest_star_session.end",
                GetEventsubSubscriptionsType.ChannelguestStarGuestupdate => "channel.guest_star_guest.update",
                GetEventsubSubscriptionsType.ChannelguestStarSettingsupdate => "channel.guest_star_settings.update",
                GetEventsubSubscriptionsType.ChannelchannelPointsAutomaticRewardadd => "channel.channel_points_automatic_reward.add",
                GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardadd => "channel.channel_points_custom_reward.add",
                GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardupdate => "channel.channel_points_custom_reward.update",
                GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardremove => "channel.channel_points_custom_reward.remove",
                GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardRedemptionadd => "channel.channel_points_custom_reward_redemption.add",
                GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardRedemptionupdate => "channel.channel_points_custom_reward_redemption.update",
                GetEventsubSubscriptionsType.Channelpollbegin => "channel.poll.begin",
                GetEventsubSubscriptionsType.Channelpollprogress => "channel.poll.progress",
                GetEventsubSubscriptionsType.Channelpollend => "channel.poll.end",
                GetEventsubSubscriptionsType.Channelpredictionbegin => "channel.prediction.begin",
                GetEventsubSubscriptionsType.Channelpredictionprogress => "channel.prediction.progress",
                GetEventsubSubscriptionsType.Channelpredictionlock => "channel.prediction.lock",
                GetEventsubSubscriptionsType.Channelpredictionend => "channel.prediction.end",
                GetEventsubSubscriptionsType.Channelvipadd => "channel.vip.add",
                GetEventsubSubscriptionsType.Channelvipremove => "channel.vip.remove",
                GetEventsubSubscriptionsType.ChannelcharityCampaigndonate => "channel.charity_campaign.donate",
                GetEventsubSubscriptionsType.ChannelcharityCampaignstart => "channel.charity_campaign.start",
                GetEventsubSubscriptionsType.ChannelcharityCampaignprogress => "channel.charity_campaign.progress",
                GetEventsubSubscriptionsType.ChannelcharityCampaignstop => "channel.charity_campaign.stop",
                GetEventsubSubscriptionsType.Conduitsharddisabled => "conduit.shard.disabled",
                GetEventsubSubscriptionsType.Dropentitlementgrant => "drop.entitlement.grant",
                GetEventsubSubscriptionsType.ExtensionbitsTransactioncreate => "extension.bits_transaction.create",
                GetEventsubSubscriptionsType.Channelgoalbegin => "channel.goal.begin",
                GetEventsubSubscriptionsType.Channelgoalprogress => "channel.goal.progress",
                GetEventsubSubscriptionsType.Channelgoalend => "channel.goal.end",
                GetEventsubSubscriptionsType.ChannelhypeTrainbegin => "channel.hype_train.begin",
                GetEventsubSubscriptionsType.ChannelhypeTrainprogress => "channel.hype_train.progress",
                GetEventsubSubscriptionsType.ChannelhypeTrainend => "channel.hype_train.end",
                GetEventsubSubscriptionsType.ChannelshieldModebegin => "channel.shield_mode.begin",
                GetEventsubSubscriptionsType.ChannelshieldModeend => "channel.shield_mode.end",
                GetEventsubSubscriptionsType.Channelshoutoutcreate => "channel.shoutout.create",
                GetEventsubSubscriptionsType.Channelshoutoutreceive => "channel.shoutout.receive",
                GetEventsubSubscriptionsType.Streamonline => "stream.online",
                GetEventsubSubscriptionsType.Streamoffline => "stream.offline",
                GetEventsubSubscriptionsType.Userauthorizationgrant => "user.authorization.grant",
                GetEventsubSubscriptionsType.Userauthorizationrevoke => "user.authorization.revoke",
                GetEventsubSubscriptionsType.Userupdate => "user.update",
                GetEventsubSubscriptionsType.Userwhispermessage => "user.whisper.message",
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

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetEventSubSubscriptionsResponse?>(content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{content}\" ");
        }
    }
}