//HintName: G.Models.EventSubSubscriptionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The subscription's type. See [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EventSubSubscriptionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automod.message.hold")]
        AutomodMessageHold,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automod.message.update")]
        AutomodMessageUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automod.settings.update")]
        AutomodSettingsUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automod.terms.update")]
        AutomodTermsUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.update")]
        ChannelUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.follow")]
        ChannelFollow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.ad_break.begin")]
        ChannelAdBreakBegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.clear")]
        ChannelChatClear,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.clear_user_messages")]
        ChannelChatClearUserMessages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.message")]
        ChannelChatMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.message_delete")]
        ChannelChatMessageDelete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.notification")]
        ChannelChatNotification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat_settings.update")]
        ChannelChatSettingsUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.user_message_hold")]
        ChannelChatUserMessageHold,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.user_message_update")]
        ChannelChatUserMessageUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.subscribe")]
        ChannelSubscribe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.subscription.end")]
        ChannelSubscriptionEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.subscription.gift")]
        ChannelSubscriptionGift,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.subscription.message")]
        ChannelSubscriptionMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.cheer")]
        ChannelCheer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.raid")]
        ChannelRaid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.ban")]
        ChannelBan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.unban")]
        ChannelUnban,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.unban_request.create")]
        ChannelUnbanRequestCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.unban_request.resolve")]
        ChannelUnbanRequestResolve,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.moderate")]
        ChannelModerate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.moderator.add")]
        ChannelModeratorAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.moderator.remove")]
        ChannelModeratorRemove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.guest_star_session.begin")]
        ChannelGuestStarSessionBegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.guest_star_session.end")]
        ChannelGuestStarSessionEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.guest_star_guest.update")]
        ChannelGuestStarGuestUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.guest_star_settings.update")]
        ChannelGuestStarSettingsUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_automatic_reward.add")]
        ChannelChannelPointsAutomaticRewardAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward.add")]
        ChannelChannelPointsCustomRewardAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward.update")]
        ChannelChannelPointsCustomRewardUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward.remove")]
        ChannelChannelPointsCustomRewardRemove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward_redemption.add")]
        ChannelChannelPointsCustomRewardRedemptionAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward_redemption.update")]
        ChannelChannelPointsCustomRewardRedemptionUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.poll.begin")]
        ChannelPollBegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.poll.progress")]
        ChannelPollProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.poll.end")]
        ChannelPollEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.prediction.begin")]
        ChannelPredictionBegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.prediction.progress")]
        ChannelPredictionProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.prediction.lock")]
        ChannelPredictionLock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.prediction.end")]
        ChannelPredictionEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.vip.add")]
        ChannelVipAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.vip.remove")]
        ChannelVipRemove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.charity_campaign.donate")]
        ChannelCharityCampaignDonate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.charity_campaign.start")]
        ChannelCharityCampaignStart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.charity_campaign.progress")]
        ChannelCharityCampaignProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.charity_campaign.stop")]
        ChannelCharityCampaignStop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conduit.shard.disabled")]
        ConduitShardDisabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drop.entitlement.grant")]
        DropEntitlementGrant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extension.bits_transaction.create")]
        ExtensionBitsTransactionCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.goal.begin")]
        ChannelGoalBegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.goal.progress")]
        ChannelGoalProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.goal.end")]
        ChannelGoalEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.hype_train.begin")]
        ChannelHypeTrainBegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.hype_train.progress")]
        ChannelHypeTrainProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.hype_train.end")]
        ChannelHypeTrainEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.shield_mode.begin")]
        ChannelShieldModeBegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.shield_mode.end")]
        ChannelShieldModeEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.shoutout.create")]
        ChannelShoutoutCreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.shoutout.receive")]
        ChannelShoutoutReceive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream.online")]
        StreamOnline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream.offline")]
        StreamOffline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.authorization.grant")]
        UserAuthorizationGrant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.authorization.revoke")]
        UserAuthorizationRevoke,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.update")]
        UserUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.whisper.message")]
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