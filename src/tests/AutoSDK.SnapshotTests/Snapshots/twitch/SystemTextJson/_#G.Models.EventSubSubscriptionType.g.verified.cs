//HintName: G.Models.EventSubSubscriptionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The subscription's type. See [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types).
    /// </summary>
    public enum EventSubSubscriptionType
    {
        /// <summary>
        /// 
        /// </summary>
        AutomodMessageHold,
        /// <summary>
        /// 
        /// </summary>
        AutomodMessageUpdate,
        /// <summary>
        /// 
        /// </summary>
        AutomodSettingsUpdate,
        /// <summary>
        /// 
        /// </summary>
        AutomodTermsUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelAdBreakBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelBan,
        /// <summary>
        /// 
        /// </summary>
        ChannelChannelPointsAutomaticRewardAdd,
        /// <summary>
        /// 
        /// </summary>
        ChannelChannelPointsCustomRewardAdd,
        /// <summary>
        /// 
        /// </summary>
        ChannelChannelPointsCustomRewardRemove,
        /// <summary>
        /// 
        /// </summary>
        ChannelChannelPointsCustomRewardUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelChannelPointsCustomRewardRedemptionAdd,
        /// <summary>
        /// 
        /// </summary>
        ChannelChannelPointsCustomRewardRedemptionUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelCharityCampaignDonate,
        /// <summary>
        /// 
        /// </summary>
        ChannelCharityCampaignProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelCharityCampaignStart,
        /// <summary>
        /// 
        /// </summary>
        ChannelCharityCampaignStop,
        /// <summary>
        /// 
        /// </summary>
        ChannelChatClear,
        /// <summary>
        /// 
        /// </summary>
        ChannelChatClearUserMessages,
        /// <summary>
        /// 
        /// </summary>
        ChannelChatMessage,
        /// <summary>
        /// 
        /// </summary>
        ChannelChatMessageDelete,
        /// <summary>
        /// 
        /// </summary>
        ChannelChatNotification,
        /// <summary>
        /// 
        /// </summary>
        ChannelChatUserMessageHold,
        /// <summary>
        /// 
        /// </summary>
        ChannelChatUserMessageUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelChatSettingsUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelCheer,
        /// <summary>
        /// 
        /// </summary>
        ChannelFollow,
        /// <summary>
        /// 
        /// </summary>
        ChannelGoalBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelGoalEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelGoalProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelGuestStarGuestUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelGuestStarSessionBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelGuestStarSessionEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelGuestStarSettingsUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelHypeTrainBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelHypeTrainEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelHypeTrainProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelModerate,
        /// <summary>
        /// 
        /// </summary>
        ChannelModeratorAdd,
        /// <summary>
        /// 
        /// </summary>
        ChannelModeratorRemove,
        /// <summary>
        /// 
        /// </summary>
        ChannelPollBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelPollEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelPollProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelPredictionBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelPredictionEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelPredictionLock,
        /// <summary>
        /// 
        /// </summary>
        ChannelPredictionProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelRaid,
        /// <summary>
        /// 
        /// </summary>
        ChannelShieldModeBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelShieldModeEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelShoutoutCreate,
        /// <summary>
        /// 
        /// </summary>
        ChannelShoutoutReceive,
        /// <summary>
        /// 
        /// </summary>
        ChannelSubscribe,
        /// <summary>
        /// 
        /// </summary>
        ChannelSubscriptionEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelSubscriptionGift,
        /// <summary>
        /// 
        /// </summary>
        ChannelSubscriptionMessage,
        /// <summary>
        /// 
        /// </summary>
        ChannelUnban,
        /// <summary>
        /// 
        /// </summary>
        ChannelUnbanRequestCreate,
        /// <summary>
        /// 
        /// </summary>
        ChannelUnbanRequestResolve,
        /// <summary>
        /// 
        /// </summary>
        ChannelUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelVipAdd,
        /// <summary>
        /// 
        /// </summary>
        ChannelVipRemove,
        /// <summary>
        /// 
        /// </summary>
        ConduitShardDisabled,
        /// <summary>
        /// 
        /// </summary>
        DropEntitlementGrant,
        /// <summary>
        /// 
        /// </summary>
        ExtensionBitsTransactionCreate,
        /// <summary>
        /// 
        /// </summary>
        StreamOffline,
        /// <summary>
        /// 
        /// </summary>
        StreamOnline,
        /// <summary>
        /// 
        /// </summary>
        UserAuthorizationGrant,
        /// <summary>
        /// 
        /// </summary>
        UserAuthorizationRevoke,
        /// <summary>
        /// 
        /// </summary>
        UserUpdate,
        /// <summary>
        /// 
        /// </summary>
        UserWhisperMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventSubSubscriptionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventSubSubscriptionType value)
        {
            return value switch
            {
                EventSubSubscriptionType.AutomodMessageHold => "automod.message.hold",
                EventSubSubscriptionType.AutomodMessageUpdate => "automod.message.update",
                EventSubSubscriptionType.AutomodSettingsUpdate => "automod.settings.update",
                EventSubSubscriptionType.AutomodTermsUpdate => "automod.terms.update",
                EventSubSubscriptionType.ChannelAdBreakBegin => "channel.ad_break.begin",
                EventSubSubscriptionType.ChannelBan => "channel.ban",
                EventSubSubscriptionType.ChannelChannelPointsAutomaticRewardAdd => "channel.channel_points_automatic_reward.add",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardAdd => "channel.channel_points_custom_reward.add",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardRemove => "channel.channel_points_custom_reward.remove",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardUpdate => "channel.channel_points_custom_reward.update",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardRedemptionAdd => "channel.channel_points_custom_reward_redemption.add",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardRedemptionUpdate => "channel.channel_points_custom_reward_redemption.update",
                EventSubSubscriptionType.ChannelCharityCampaignDonate => "channel.charity_campaign.donate",
                EventSubSubscriptionType.ChannelCharityCampaignProgress => "channel.charity_campaign.progress",
                EventSubSubscriptionType.ChannelCharityCampaignStart => "channel.charity_campaign.start",
                EventSubSubscriptionType.ChannelCharityCampaignStop => "channel.charity_campaign.stop",
                EventSubSubscriptionType.ChannelChatClear => "channel.chat.clear",
                EventSubSubscriptionType.ChannelChatClearUserMessages => "channel.chat.clear_user_messages",
                EventSubSubscriptionType.ChannelChatMessage => "channel.chat.message",
                EventSubSubscriptionType.ChannelChatMessageDelete => "channel.chat.message_delete",
                EventSubSubscriptionType.ChannelChatNotification => "channel.chat.notification",
                EventSubSubscriptionType.ChannelChatUserMessageHold => "channel.chat.user_message_hold",
                EventSubSubscriptionType.ChannelChatUserMessageUpdate => "channel.chat.user_message_update",
                EventSubSubscriptionType.ChannelChatSettingsUpdate => "channel.chat_settings.update",
                EventSubSubscriptionType.ChannelCheer => "channel.cheer",
                EventSubSubscriptionType.ChannelFollow => "channel.follow",
                EventSubSubscriptionType.ChannelGoalBegin => "channel.goal.begin",
                EventSubSubscriptionType.ChannelGoalEnd => "channel.goal.end",
                EventSubSubscriptionType.ChannelGoalProgress => "channel.goal.progress",
                EventSubSubscriptionType.ChannelGuestStarGuestUpdate => "channel.guest_star_guest.update",
                EventSubSubscriptionType.ChannelGuestStarSessionBegin => "channel.guest_star_session.begin",
                EventSubSubscriptionType.ChannelGuestStarSessionEnd => "channel.guest_star_session.end",
                EventSubSubscriptionType.ChannelGuestStarSettingsUpdate => "channel.guest_star_settings.update",
                EventSubSubscriptionType.ChannelHypeTrainBegin => "channel.hype_train.begin",
                EventSubSubscriptionType.ChannelHypeTrainEnd => "channel.hype_train.end",
                EventSubSubscriptionType.ChannelHypeTrainProgress => "channel.hype_train.progress",
                EventSubSubscriptionType.ChannelModerate => "channel.moderate",
                EventSubSubscriptionType.ChannelModeratorAdd => "channel.moderator.add",
                EventSubSubscriptionType.ChannelModeratorRemove => "channel.moderator.remove",
                EventSubSubscriptionType.ChannelPollBegin => "channel.poll.begin",
                EventSubSubscriptionType.ChannelPollEnd => "channel.poll.end",
                EventSubSubscriptionType.ChannelPollProgress => "channel.poll.progress",
                EventSubSubscriptionType.ChannelPredictionBegin => "channel.prediction.begin",
                EventSubSubscriptionType.ChannelPredictionEnd => "channel.prediction.end",
                EventSubSubscriptionType.ChannelPredictionLock => "channel.prediction.lock",
                EventSubSubscriptionType.ChannelPredictionProgress => "channel.prediction.progress",
                EventSubSubscriptionType.ChannelRaid => "channel.raid",
                EventSubSubscriptionType.ChannelShieldModeBegin => "channel.shield_mode.begin",
                EventSubSubscriptionType.ChannelShieldModeEnd => "channel.shield_mode.end",
                EventSubSubscriptionType.ChannelShoutoutCreate => "channel.shoutout.create",
                EventSubSubscriptionType.ChannelShoutoutReceive => "channel.shoutout.receive",
                EventSubSubscriptionType.ChannelSubscribe => "channel.subscribe",
                EventSubSubscriptionType.ChannelSubscriptionEnd => "channel.subscription.end",
                EventSubSubscriptionType.ChannelSubscriptionGift => "channel.subscription.gift",
                EventSubSubscriptionType.ChannelSubscriptionMessage => "channel.subscription.message",
                EventSubSubscriptionType.ChannelUnban => "channel.unban",
                EventSubSubscriptionType.ChannelUnbanRequestCreate => "channel.unban_request.create",
                EventSubSubscriptionType.ChannelUnbanRequestResolve => "channel.unban_request.resolve",
                EventSubSubscriptionType.ChannelUpdate => "channel.update",
                EventSubSubscriptionType.ChannelVipAdd => "channel.vip.add",
                EventSubSubscriptionType.ChannelVipRemove => "channel.vip.remove",
                EventSubSubscriptionType.ConduitShardDisabled => "conduit.shard.disabled",
                EventSubSubscriptionType.DropEntitlementGrant => "drop.entitlement.grant",
                EventSubSubscriptionType.ExtensionBitsTransactionCreate => "extension.bits_transaction.create",
                EventSubSubscriptionType.StreamOffline => "stream.offline",
                EventSubSubscriptionType.StreamOnline => "stream.online",
                EventSubSubscriptionType.UserAuthorizationGrant => "user.authorization.grant",
                EventSubSubscriptionType.UserAuthorizationRevoke => "user.authorization.revoke",
                EventSubSubscriptionType.UserUpdate => "user.update",
                EventSubSubscriptionType.UserWhisperMessage => "user.whisper.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventSubSubscriptionType? ToEnum(string value)
        {
            return value switch
            {
                "automod.message.hold" => EventSubSubscriptionType.AutomodMessageHold,
                "automod.message.update" => EventSubSubscriptionType.AutomodMessageUpdate,
                "automod.settings.update" => EventSubSubscriptionType.AutomodSettingsUpdate,
                "automod.terms.update" => EventSubSubscriptionType.AutomodTermsUpdate,
                "channel.ad_break.begin" => EventSubSubscriptionType.ChannelAdBreakBegin,
                "channel.ban" => EventSubSubscriptionType.ChannelBan,
                "channel.channel_points_automatic_reward.add" => EventSubSubscriptionType.ChannelChannelPointsAutomaticRewardAdd,
                "channel.channel_points_custom_reward.add" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardAdd,
                "channel.channel_points_custom_reward.remove" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardRemove,
                "channel.channel_points_custom_reward.update" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardUpdate,
                "channel.channel_points_custom_reward_redemption.add" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardRedemptionAdd,
                "channel.channel_points_custom_reward_redemption.update" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardRedemptionUpdate,
                "channel.charity_campaign.donate" => EventSubSubscriptionType.ChannelCharityCampaignDonate,
                "channel.charity_campaign.progress" => EventSubSubscriptionType.ChannelCharityCampaignProgress,
                "channel.charity_campaign.start" => EventSubSubscriptionType.ChannelCharityCampaignStart,
                "channel.charity_campaign.stop" => EventSubSubscriptionType.ChannelCharityCampaignStop,
                "channel.chat.clear" => EventSubSubscriptionType.ChannelChatClear,
                "channel.chat.clear_user_messages" => EventSubSubscriptionType.ChannelChatClearUserMessages,
                "channel.chat.message" => EventSubSubscriptionType.ChannelChatMessage,
                "channel.chat.message_delete" => EventSubSubscriptionType.ChannelChatMessageDelete,
                "channel.chat.notification" => EventSubSubscriptionType.ChannelChatNotification,
                "channel.chat.user_message_hold" => EventSubSubscriptionType.ChannelChatUserMessageHold,
                "channel.chat.user_message_update" => EventSubSubscriptionType.ChannelChatUserMessageUpdate,
                "channel.chat_settings.update" => EventSubSubscriptionType.ChannelChatSettingsUpdate,
                "channel.cheer" => EventSubSubscriptionType.ChannelCheer,
                "channel.follow" => EventSubSubscriptionType.ChannelFollow,
                "channel.goal.begin" => EventSubSubscriptionType.ChannelGoalBegin,
                "channel.goal.end" => EventSubSubscriptionType.ChannelGoalEnd,
                "channel.goal.progress" => EventSubSubscriptionType.ChannelGoalProgress,
                "channel.guest_star_guest.update" => EventSubSubscriptionType.ChannelGuestStarGuestUpdate,
                "channel.guest_star_session.begin" => EventSubSubscriptionType.ChannelGuestStarSessionBegin,
                "channel.guest_star_session.end" => EventSubSubscriptionType.ChannelGuestStarSessionEnd,
                "channel.guest_star_settings.update" => EventSubSubscriptionType.ChannelGuestStarSettingsUpdate,
                "channel.hype_train.begin" => EventSubSubscriptionType.ChannelHypeTrainBegin,
                "channel.hype_train.end" => EventSubSubscriptionType.ChannelHypeTrainEnd,
                "channel.hype_train.progress" => EventSubSubscriptionType.ChannelHypeTrainProgress,
                "channel.moderate" => EventSubSubscriptionType.ChannelModerate,
                "channel.moderator.add" => EventSubSubscriptionType.ChannelModeratorAdd,
                "channel.moderator.remove" => EventSubSubscriptionType.ChannelModeratorRemove,
                "channel.poll.begin" => EventSubSubscriptionType.ChannelPollBegin,
                "channel.poll.end" => EventSubSubscriptionType.ChannelPollEnd,
                "channel.poll.progress" => EventSubSubscriptionType.ChannelPollProgress,
                "channel.prediction.begin" => EventSubSubscriptionType.ChannelPredictionBegin,
                "channel.prediction.end" => EventSubSubscriptionType.ChannelPredictionEnd,
                "channel.prediction.lock" => EventSubSubscriptionType.ChannelPredictionLock,
                "channel.prediction.progress" => EventSubSubscriptionType.ChannelPredictionProgress,
                "channel.raid" => EventSubSubscriptionType.ChannelRaid,
                "channel.shield_mode.begin" => EventSubSubscriptionType.ChannelShieldModeBegin,
                "channel.shield_mode.end" => EventSubSubscriptionType.ChannelShieldModeEnd,
                "channel.shoutout.create" => EventSubSubscriptionType.ChannelShoutoutCreate,
                "channel.shoutout.receive" => EventSubSubscriptionType.ChannelShoutoutReceive,
                "channel.subscribe" => EventSubSubscriptionType.ChannelSubscribe,
                "channel.subscription.end" => EventSubSubscriptionType.ChannelSubscriptionEnd,
                "channel.subscription.gift" => EventSubSubscriptionType.ChannelSubscriptionGift,
                "channel.subscription.message" => EventSubSubscriptionType.ChannelSubscriptionMessage,
                "channel.unban" => EventSubSubscriptionType.ChannelUnban,
                "channel.unban_request.create" => EventSubSubscriptionType.ChannelUnbanRequestCreate,
                "channel.unban_request.resolve" => EventSubSubscriptionType.ChannelUnbanRequestResolve,
                "channel.update" => EventSubSubscriptionType.ChannelUpdate,
                "channel.vip.add" => EventSubSubscriptionType.ChannelVipAdd,
                "channel.vip.remove" => EventSubSubscriptionType.ChannelVipRemove,
                "conduit.shard.disabled" => EventSubSubscriptionType.ConduitShardDisabled,
                "drop.entitlement.grant" => EventSubSubscriptionType.DropEntitlementGrant,
                "extension.bits_transaction.create" => EventSubSubscriptionType.ExtensionBitsTransactionCreate,
                "stream.offline" => EventSubSubscriptionType.StreamOffline,
                "stream.online" => EventSubSubscriptionType.StreamOnline,
                "user.authorization.grant" => EventSubSubscriptionType.UserAuthorizationGrant,
                "user.authorization.revoke" => EventSubSubscriptionType.UserAuthorizationRevoke,
                "user.update" => EventSubSubscriptionType.UserUpdate,
                "user.whisper.message" => EventSubSubscriptionType.UserWhisperMessage,
                _ => null,
            };
        }
    }
}