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
        ChannelUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelFollow,
        /// <summary>
        /// 
        /// </summary>
        ChannelAdBreakBegin,
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
        ChannelChatSettingsUpdate,
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
        ChannelCheer,
        /// <summary>
        /// 
        /// </summary>
        ChannelRaid,
        /// <summary>
        /// 
        /// </summary>
        ChannelBan,
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
        ChannelGuestStarSessionBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelGuestStarSessionEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelGuestStarGuestUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelGuestStarSettingsUpdate,
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
        ChannelChannelPointsCustomRewardUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelChannelPointsCustomRewardRemove,
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
        ChannelPollBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelPollProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelPollEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelPredictionBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelPredictionProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelPredictionLock,
        /// <summary>
        /// 
        /// </summary>
        ChannelPredictionEnd,
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
        ChannelCharityCampaignDonate,
        /// <summary>
        /// 
        /// </summary>
        ChannelCharityCampaignStart,
        /// <summary>
        /// 
        /// </summary>
        ChannelCharityCampaignProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelCharityCampaignStop,
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
        ChannelGoalBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelGoalProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelGoalEnd,
        /// <summary>
        /// 
        /// </summary>
        ChannelHypeTrainBegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelHypeTrainProgress,
        /// <summary>
        /// 
        /// </summary>
        ChannelHypeTrainEnd,
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
        StreamOnline,
        /// <summary>
        /// 
        /// </summary>
        StreamOffline,
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
                EventSubSubscriptionType.ChannelUpdate => "channel.update",
                EventSubSubscriptionType.ChannelFollow => "channel.follow",
                EventSubSubscriptionType.ChannelAdBreakBegin => "channel.ad_break.begin",
                EventSubSubscriptionType.ChannelChatClear => "channel.chat.clear",
                EventSubSubscriptionType.ChannelChatClearUserMessages => "channel.chat.clear_user_messages",
                EventSubSubscriptionType.ChannelChatMessage => "channel.chat.message",
                EventSubSubscriptionType.ChannelChatMessageDelete => "channel.chat.message_delete",
                EventSubSubscriptionType.ChannelChatNotification => "channel.chat.notification",
                EventSubSubscriptionType.ChannelChatSettingsUpdate => "channel.chat_settings.update",
                EventSubSubscriptionType.ChannelChatUserMessageHold => "channel.chat.user_message_hold",
                EventSubSubscriptionType.ChannelChatUserMessageUpdate => "channel.chat.user_message_update",
                EventSubSubscriptionType.ChannelSubscribe => "channel.subscribe",
                EventSubSubscriptionType.ChannelSubscriptionEnd => "channel.subscription.end",
                EventSubSubscriptionType.ChannelSubscriptionGift => "channel.subscription.gift",
                EventSubSubscriptionType.ChannelSubscriptionMessage => "channel.subscription.message",
                EventSubSubscriptionType.ChannelCheer => "channel.cheer",
                EventSubSubscriptionType.ChannelRaid => "channel.raid",
                EventSubSubscriptionType.ChannelBan => "channel.ban",
                EventSubSubscriptionType.ChannelUnban => "channel.unban",
                EventSubSubscriptionType.ChannelUnbanRequestCreate => "channel.unban_request.create",
                EventSubSubscriptionType.ChannelUnbanRequestResolve => "channel.unban_request.resolve",
                EventSubSubscriptionType.ChannelModerate => "channel.moderate",
                EventSubSubscriptionType.ChannelModeratorAdd => "channel.moderator.add",
                EventSubSubscriptionType.ChannelModeratorRemove => "channel.moderator.remove",
                EventSubSubscriptionType.ChannelGuestStarSessionBegin => "channel.guest_star_session.begin",
                EventSubSubscriptionType.ChannelGuestStarSessionEnd => "channel.guest_star_session.end",
                EventSubSubscriptionType.ChannelGuestStarGuestUpdate => "channel.guest_star_guest.update",
                EventSubSubscriptionType.ChannelGuestStarSettingsUpdate => "channel.guest_star_settings.update",
                EventSubSubscriptionType.ChannelChannelPointsAutomaticRewardAdd => "channel.channel_points_automatic_reward.add",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardAdd => "channel.channel_points_custom_reward.add",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardUpdate => "channel.channel_points_custom_reward.update",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardRemove => "channel.channel_points_custom_reward.remove",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardRedemptionAdd => "channel.channel_points_custom_reward_redemption.add",
                EventSubSubscriptionType.ChannelChannelPointsCustomRewardRedemptionUpdate => "channel.channel_points_custom_reward_redemption.update",
                EventSubSubscriptionType.ChannelPollBegin => "channel.poll.begin",
                EventSubSubscriptionType.ChannelPollProgress => "channel.poll.progress",
                EventSubSubscriptionType.ChannelPollEnd => "channel.poll.end",
                EventSubSubscriptionType.ChannelPredictionBegin => "channel.prediction.begin",
                EventSubSubscriptionType.ChannelPredictionProgress => "channel.prediction.progress",
                EventSubSubscriptionType.ChannelPredictionLock => "channel.prediction.lock",
                EventSubSubscriptionType.ChannelPredictionEnd => "channel.prediction.end",
                EventSubSubscriptionType.ChannelVipAdd => "channel.vip.add",
                EventSubSubscriptionType.ChannelVipRemove => "channel.vip.remove",
                EventSubSubscriptionType.ChannelCharityCampaignDonate => "channel.charity_campaign.donate",
                EventSubSubscriptionType.ChannelCharityCampaignStart => "channel.charity_campaign.start",
                EventSubSubscriptionType.ChannelCharityCampaignProgress => "channel.charity_campaign.progress",
                EventSubSubscriptionType.ChannelCharityCampaignStop => "channel.charity_campaign.stop",
                EventSubSubscriptionType.ConduitShardDisabled => "conduit.shard.disabled",
                EventSubSubscriptionType.DropEntitlementGrant => "drop.entitlement.grant",
                EventSubSubscriptionType.ExtensionBitsTransactionCreate => "extension.bits_transaction.create",
                EventSubSubscriptionType.ChannelGoalBegin => "channel.goal.begin",
                EventSubSubscriptionType.ChannelGoalProgress => "channel.goal.progress",
                EventSubSubscriptionType.ChannelGoalEnd => "channel.goal.end",
                EventSubSubscriptionType.ChannelHypeTrainBegin => "channel.hype_train.begin",
                EventSubSubscriptionType.ChannelHypeTrainProgress => "channel.hype_train.progress",
                EventSubSubscriptionType.ChannelHypeTrainEnd => "channel.hype_train.end",
                EventSubSubscriptionType.ChannelShieldModeBegin => "channel.shield_mode.begin",
                EventSubSubscriptionType.ChannelShieldModeEnd => "channel.shield_mode.end",
                EventSubSubscriptionType.ChannelShoutoutCreate => "channel.shoutout.create",
                EventSubSubscriptionType.ChannelShoutoutReceive => "channel.shoutout.receive",
                EventSubSubscriptionType.StreamOnline => "stream.online",
                EventSubSubscriptionType.StreamOffline => "stream.offline",
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
                "channel.update" => EventSubSubscriptionType.ChannelUpdate,
                "channel.follow" => EventSubSubscriptionType.ChannelFollow,
                "channel.ad_break.begin" => EventSubSubscriptionType.ChannelAdBreakBegin,
                "channel.chat.clear" => EventSubSubscriptionType.ChannelChatClear,
                "channel.chat.clear_user_messages" => EventSubSubscriptionType.ChannelChatClearUserMessages,
                "channel.chat.message" => EventSubSubscriptionType.ChannelChatMessage,
                "channel.chat.message_delete" => EventSubSubscriptionType.ChannelChatMessageDelete,
                "channel.chat.notification" => EventSubSubscriptionType.ChannelChatNotification,
                "channel.chat_settings.update" => EventSubSubscriptionType.ChannelChatSettingsUpdate,
                "channel.chat.user_message_hold" => EventSubSubscriptionType.ChannelChatUserMessageHold,
                "channel.chat.user_message_update" => EventSubSubscriptionType.ChannelChatUserMessageUpdate,
                "channel.subscribe" => EventSubSubscriptionType.ChannelSubscribe,
                "channel.subscription.end" => EventSubSubscriptionType.ChannelSubscriptionEnd,
                "channel.subscription.gift" => EventSubSubscriptionType.ChannelSubscriptionGift,
                "channel.subscription.message" => EventSubSubscriptionType.ChannelSubscriptionMessage,
                "channel.cheer" => EventSubSubscriptionType.ChannelCheer,
                "channel.raid" => EventSubSubscriptionType.ChannelRaid,
                "channel.ban" => EventSubSubscriptionType.ChannelBan,
                "channel.unban" => EventSubSubscriptionType.ChannelUnban,
                "channel.unban_request.create" => EventSubSubscriptionType.ChannelUnbanRequestCreate,
                "channel.unban_request.resolve" => EventSubSubscriptionType.ChannelUnbanRequestResolve,
                "channel.moderate" => EventSubSubscriptionType.ChannelModerate,
                "channel.moderator.add" => EventSubSubscriptionType.ChannelModeratorAdd,
                "channel.moderator.remove" => EventSubSubscriptionType.ChannelModeratorRemove,
                "channel.guest_star_session.begin" => EventSubSubscriptionType.ChannelGuestStarSessionBegin,
                "channel.guest_star_session.end" => EventSubSubscriptionType.ChannelGuestStarSessionEnd,
                "channel.guest_star_guest.update" => EventSubSubscriptionType.ChannelGuestStarGuestUpdate,
                "channel.guest_star_settings.update" => EventSubSubscriptionType.ChannelGuestStarSettingsUpdate,
                "channel.channel_points_automatic_reward.add" => EventSubSubscriptionType.ChannelChannelPointsAutomaticRewardAdd,
                "channel.channel_points_custom_reward.add" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardAdd,
                "channel.channel_points_custom_reward.update" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardUpdate,
                "channel.channel_points_custom_reward.remove" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardRemove,
                "channel.channel_points_custom_reward_redemption.add" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardRedemptionAdd,
                "channel.channel_points_custom_reward_redemption.update" => EventSubSubscriptionType.ChannelChannelPointsCustomRewardRedemptionUpdate,
                "channel.poll.begin" => EventSubSubscriptionType.ChannelPollBegin,
                "channel.poll.progress" => EventSubSubscriptionType.ChannelPollProgress,
                "channel.poll.end" => EventSubSubscriptionType.ChannelPollEnd,
                "channel.prediction.begin" => EventSubSubscriptionType.ChannelPredictionBegin,
                "channel.prediction.progress" => EventSubSubscriptionType.ChannelPredictionProgress,
                "channel.prediction.lock" => EventSubSubscriptionType.ChannelPredictionLock,
                "channel.prediction.end" => EventSubSubscriptionType.ChannelPredictionEnd,
                "channel.vip.add" => EventSubSubscriptionType.ChannelVipAdd,
                "channel.vip.remove" => EventSubSubscriptionType.ChannelVipRemove,
                "channel.charity_campaign.donate" => EventSubSubscriptionType.ChannelCharityCampaignDonate,
                "channel.charity_campaign.start" => EventSubSubscriptionType.ChannelCharityCampaignStart,
                "channel.charity_campaign.progress" => EventSubSubscriptionType.ChannelCharityCampaignProgress,
                "channel.charity_campaign.stop" => EventSubSubscriptionType.ChannelCharityCampaignStop,
                "conduit.shard.disabled" => EventSubSubscriptionType.ConduitShardDisabled,
                "drop.entitlement.grant" => EventSubSubscriptionType.DropEntitlementGrant,
                "extension.bits_transaction.create" => EventSubSubscriptionType.ExtensionBitsTransactionCreate,
                "channel.goal.begin" => EventSubSubscriptionType.ChannelGoalBegin,
                "channel.goal.progress" => EventSubSubscriptionType.ChannelGoalProgress,
                "channel.goal.end" => EventSubSubscriptionType.ChannelGoalEnd,
                "channel.hype_train.begin" => EventSubSubscriptionType.ChannelHypeTrainBegin,
                "channel.hype_train.progress" => EventSubSubscriptionType.ChannelHypeTrainProgress,
                "channel.hype_train.end" => EventSubSubscriptionType.ChannelHypeTrainEnd,
                "channel.shield_mode.begin" => EventSubSubscriptionType.ChannelShieldModeBegin,
                "channel.shield_mode.end" => EventSubSubscriptionType.ChannelShieldModeEnd,
                "channel.shoutout.create" => EventSubSubscriptionType.ChannelShoutoutCreate,
                "channel.shoutout.receive" => EventSubSubscriptionType.ChannelShoutoutReceive,
                "stream.online" => EventSubSubscriptionType.StreamOnline,
                "stream.offline" => EventSubSubscriptionType.StreamOffline,
                "user.authorization.grant" => EventSubSubscriptionType.UserAuthorizationGrant,
                "user.authorization.revoke" => EventSubSubscriptionType.UserAuthorizationRevoke,
                "user.update" => EventSubSubscriptionType.UserUpdate,
                "user.whisper.message" => EventSubSubscriptionType.UserWhisperMessage,
                _ => null,
            };
        }
    }
}