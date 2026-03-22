//HintName: G.Models.CreateEventSubSubscriptionBodyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of subscription to create. For a list of subscriptions that you can create, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types). Set this field to the value in the **Name** column of the Subscription Types table.
    /// </summary>
    public enum CreateEventSubSubscriptionBodyType
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
    public static class CreateEventSubSubscriptionBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEventSubSubscriptionBodyType value)
        {
            return value switch
            {
                CreateEventSubSubscriptionBodyType.AutomodMessageHold => "automod.message.hold",
                CreateEventSubSubscriptionBodyType.AutomodMessageUpdate => "automod.message.update",
                CreateEventSubSubscriptionBodyType.AutomodSettingsUpdate => "automod.settings.update",
                CreateEventSubSubscriptionBodyType.AutomodTermsUpdate => "automod.terms.update",
                CreateEventSubSubscriptionBodyType.ChannelAdBreakBegin => "channel.ad_break.begin",
                CreateEventSubSubscriptionBodyType.ChannelBan => "channel.ban",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsAutomaticRewardAdd => "channel.channel_points_automatic_reward.add",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardAdd => "channel.channel_points_custom_reward.add",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRemove => "channel.channel_points_custom_reward.remove",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardUpdate => "channel.channel_points_custom_reward.update",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRedemptionAdd => "channel.channel_points_custom_reward_redemption.add",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRedemptionUpdate => "channel.channel_points_custom_reward_redemption.update",
                CreateEventSubSubscriptionBodyType.ChannelCharityCampaignDonate => "channel.charity_campaign.donate",
                CreateEventSubSubscriptionBodyType.ChannelCharityCampaignProgress => "channel.charity_campaign.progress",
                CreateEventSubSubscriptionBodyType.ChannelCharityCampaignStart => "channel.charity_campaign.start",
                CreateEventSubSubscriptionBodyType.ChannelCharityCampaignStop => "channel.charity_campaign.stop",
                CreateEventSubSubscriptionBodyType.ChannelChatClear => "channel.chat.clear",
                CreateEventSubSubscriptionBodyType.ChannelChatClearUserMessages => "channel.chat.clear_user_messages",
                CreateEventSubSubscriptionBodyType.ChannelChatMessage => "channel.chat.message",
                CreateEventSubSubscriptionBodyType.ChannelChatMessageDelete => "channel.chat.message_delete",
                CreateEventSubSubscriptionBodyType.ChannelChatNotification => "channel.chat.notification",
                CreateEventSubSubscriptionBodyType.ChannelChatUserMessageHold => "channel.chat.user_message_hold",
                CreateEventSubSubscriptionBodyType.ChannelChatUserMessageUpdate => "channel.chat.user_message_update",
                CreateEventSubSubscriptionBodyType.ChannelChatSettingsUpdate => "channel.chat_settings.update",
                CreateEventSubSubscriptionBodyType.ChannelCheer => "channel.cheer",
                CreateEventSubSubscriptionBodyType.ChannelFollow => "channel.follow",
                CreateEventSubSubscriptionBodyType.ChannelGoalBegin => "channel.goal.begin",
                CreateEventSubSubscriptionBodyType.ChannelGoalEnd => "channel.goal.end",
                CreateEventSubSubscriptionBodyType.ChannelGoalProgress => "channel.goal.progress",
                CreateEventSubSubscriptionBodyType.ChannelGuestStarGuestUpdate => "channel.guest_star_guest.update",
                CreateEventSubSubscriptionBodyType.ChannelGuestStarSessionBegin => "channel.guest_star_session.begin",
                CreateEventSubSubscriptionBodyType.ChannelGuestStarSessionEnd => "channel.guest_star_session.end",
                CreateEventSubSubscriptionBodyType.ChannelGuestStarSettingsUpdate => "channel.guest_star_settings.update",
                CreateEventSubSubscriptionBodyType.ChannelHypeTrainBegin => "channel.hype_train.begin",
                CreateEventSubSubscriptionBodyType.ChannelHypeTrainEnd => "channel.hype_train.end",
                CreateEventSubSubscriptionBodyType.ChannelHypeTrainProgress => "channel.hype_train.progress",
                CreateEventSubSubscriptionBodyType.ChannelModerate => "channel.moderate",
                CreateEventSubSubscriptionBodyType.ChannelModeratorAdd => "channel.moderator.add",
                CreateEventSubSubscriptionBodyType.ChannelModeratorRemove => "channel.moderator.remove",
                CreateEventSubSubscriptionBodyType.ChannelPollBegin => "channel.poll.begin",
                CreateEventSubSubscriptionBodyType.ChannelPollEnd => "channel.poll.end",
                CreateEventSubSubscriptionBodyType.ChannelPollProgress => "channel.poll.progress",
                CreateEventSubSubscriptionBodyType.ChannelPredictionBegin => "channel.prediction.begin",
                CreateEventSubSubscriptionBodyType.ChannelPredictionEnd => "channel.prediction.end",
                CreateEventSubSubscriptionBodyType.ChannelPredictionLock => "channel.prediction.lock",
                CreateEventSubSubscriptionBodyType.ChannelPredictionProgress => "channel.prediction.progress",
                CreateEventSubSubscriptionBodyType.ChannelRaid => "channel.raid",
                CreateEventSubSubscriptionBodyType.ChannelShieldModeBegin => "channel.shield_mode.begin",
                CreateEventSubSubscriptionBodyType.ChannelShieldModeEnd => "channel.shield_mode.end",
                CreateEventSubSubscriptionBodyType.ChannelShoutoutCreate => "channel.shoutout.create",
                CreateEventSubSubscriptionBodyType.ChannelShoutoutReceive => "channel.shoutout.receive",
                CreateEventSubSubscriptionBodyType.ChannelSubscribe => "channel.subscribe",
                CreateEventSubSubscriptionBodyType.ChannelSubscriptionEnd => "channel.subscription.end",
                CreateEventSubSubscriptionBodyType.ChannelSubscriptionGift => "channel.subscription.gift",
                CreateEventSubSubscriptionBodyType.ChannelSubscriptionMessage => "channel.subscription.message",
                CreateEventSubSubscriptionBodyType.ChannelUnban => "channel.unban",
                CreateEventSubSubscriptionBodyType.ChannelUnbanRequestCreate => "channel.unban_request.create",
                CreateEventSubSubscriptionBodyType.ChannelUnbanRequestResolve => "channel.unban_request.resolve",
                CreateEventSubSubscriptionBodyType.ChannelUpdate => "channel.update",
                CreateEventSubSubscriptionBodyType.ChannelVipAdd => "channel.vip.add",
                CreateEventSubSubscriptionBodyType.ChannelVipRemove => "channel.vip.remove",
                CreateEventSubSubscriptionBodyType.ConduitShardDisabled => "conduit.shard.disabled",
                CreateEventSubSubscriptionBodyType.DropEntitlementGrant => "drop.entitlement.grant",
                CreateEventSubSubscriptionBodyType.ExtensionBitsTransactionCreate => "extension.bits_transaction.create",
                CreateEventSubSubscriptionBodyType.StreamOffline => "stream.offline",
                CreateEventSubSubscriptionBodyType.StreamOnline => "stream.online",
                CreateEventSubSubscriptionBodyType.UserAuthorizationGrant => "user.authorization.grant",
                CreateEventSubSubscriptionBodyType.UserAuthorizationRevoke => "user.authorization.revoke",
                CreateEventSubSubscriptionBodyType.UserUpdate => "user.update",
                CreateEventSubSubscriptionBodyType.UserWhisperMessage => "user.whisper.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEventSubSubscriptionBodyType? ToEnum(string value)
        {
            return value switch
            {
                "automod.message.hold" => CreateEventSubSubscriptionBodyType.AutomodMessageHold,
                "automod.message.update" => CreateEventSubSubscriptionBodyType.AutomodMessageUpdate,
                "automod.settings.update" => CreateEventSubSubscriptionBodyType.AutomodSettingsUpdate,
                "automod.terms.update" => CreateEventSubSubscriptionBodyType.AutomodTermsUpdate,
                "channel.ad_break.begin" => CreateEventSubSubscriptionBodyType.ChannelAdBreakBegin,
                "channel.ban" => CreateEventSubSubscriptionBodyType.ChannelBan,
                "channel.channel_points_automatic_reward.add" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsAutomaticRewardAdd,
                "channel.channel_points_custom_reward.add" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardAdd,
                "channel.channel_points_custom_reward.remove" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRemove,
                "channel.channel_points_custom_reward.update" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardUpdate,
                "channel.channel_points_custom_reward_redemption.add" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRedemptionAdd,
                "channel.channel_points_custom_reward_redemption.update" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRedemptionUpdate,
                "channel.charity_campaign.donate" => CreateEventSubSubscriptionBodyType.ChannelCharityCampaignDonate,
                "channel.charity_campaign.progress" => CreateEventSubSubscriptionBodyType.ChannelCharityCampaignProgress,
                "channel.charity_campaign.start" => CreateEventSubSubscriptionBodyType.ChannelCharityCampaignStart,
                "channel.charity_campaign.stop" => CreateEventSubSubscriptionBodyType.ChannelCharityCampaignStop,
                "channel.chat.clear" => CreateEventSubSubscriptionBodyType.ChannelChatClear,
                "channel.chat.clear_user_messages" => CreateEventSubSubscriptionBodyType.ChannelChatClearUserMessages,
                "channel.chat.message" => CreateEventSubSubscriptionBodyType.ChannelChatMessage,
                "channel.chat.message_delete" => CreateEventSubSubscriptionBodyType.ChannelChatMessageDelete,
                "channel.chat.notification" => CreateEventSubSubscriptionBodyType.ChannelChatNotification,
                "channel.chat.user_message_hold" => CreateEventSubSubscriptionBodyType.ChannelChatUserMessageHold,
                "channel.chat.user_message_update" => CreateEventSubSubscriptionBodyType.ChannelChatUserMessageUpdate,
                "channel.chat_settings.update" => CreateEventSubSubscriptionBodyType.ChannelChatSettingsUpdate,
                "channel.cheer" => CreateEventSubSubscriptionBodyType.ChannelCheer,
                "channel.follow" => CreateEventSubSubscriptionBodyType.ChannelFollow,
                "channel.goal.begin" => CreateEventSubSubscriptionBodyType.ChannelGoalBegin,
                "channel.goal.end" => CreateEventSubSubscriptionBodyType.ChannelGoalEnd,
                "channel.goal.progress" => CreateEventSubSubscriptionBodyType.ChannelGoalProgress,
                "channel.guest_star_guest.update" => CreateEventSubSubscriptionBodyType.ChannelGuestStarGuestUpdate,
                "channel.guest_star_session.begin" => CreateEventSubSubscriptionBodyType.ChannelGuestStarSessionBegin,
                "channel.guest_star_session.end" => CreateEventSubSubscriptionBodyType.ChannelGuestStarSessionEnd,
                "channel.guest_star_settings.update" => CreateEventSubSubscriptionBodyType.ChannelGuestStarSettingsUpdate,
                "channel.hype_train.begin" => CreateEventSubSubscriptionBodyType.ChannelHypeTrainBegin,
                "channel.hype_train.end" => CreateEventSubSubscriptionBodyType.ChannelHypeTrainEnd,
                "channel.hype_train.progress" => CreateEventSubSubscriptionBodyType.ChannelHypeTrainProgress,
                "channel.moderate" => CreateEventSubSubscriptionBodyType.ChannelModerate,
                "channel.moderator.add" => CreateEventSubSubscriptionBodyType.ChannelModeratorAdd,
                "channel.moderator.remove" => CreateEventSubSubscriptionBodyType.ChannelModeratorRemove,
                "channel.poll.begin" => CreateEventSubSubscriptionBodyType.ChannelPollBegin,
                "channel.poll.end" => CreateEventSubSubscriptionBodyType.ChannelPollEnd,
                "channel.poll.progress" => CreateEventSubSubscriptionBodyType.ChannelPollProgress,
                "channel.prediction.begin" => CreateEventSubSubscriptionBodyType.ChannelPredictionBegin,
                "channel.prediction.end" => CreateEventSubSubscriptionBodyType.ChannelPredictionEnd,
                "channel.prediction.lock" => CreateEventSubSubscriptionBodyType.ChannelPredictionLock,
                "channel.prediction.progress" => CreateEventSubSubscriptionBodyType.ChannelPredictionProgress,
                "channel.raid" => CreateEventSubSubscriptionBodyType.ChannelRaid,
                "channel.shield_mode.begin" => CreateEventSubSubscriptionBodyType.ChannelShieldModeBegin,
                "channel.shield_mode.end" => CreateEventSubSubscriptionBodyType.ChannelShieldModeEnd,
                "channel.shoutout.create" => CreateEventSubSubscriptionBodyType.ChannelShoutoutCreate,
                "channel.shoutout.receive" => CreateEventSubSubscriptionBodyType.ChannelShoutoutReceive,
                "channel.subscribe" => CreateEventSubSubscriptionBodyType.ChannelSubscribe,
                "channel.subscription.end" => CreateEventSubSubscriptionBodyType.ChannelSubscriptionEnd,
                "channel.subscription.gift" => CreateEventSubSubscriptionBodyType.ChannelSubscriptionGift,
                "channel.subscription.message" => CreateEventSubSubscriptionBodyType.ChannelSubscriptionMessage,
                "channel.unban" => CreateEventSubSubscriptionBodyType.ChannelUnban,
                "channel.unban_request.create" => CreateEventSubSubscriptionBodyType.ChannelUnbanRequestCreate,
                "channel.unban_request.resolve" => CreateEventSubSubscriptionBodyType.ChannelUnbanRequestResolve,
                "channel.update" => CreateEventSubSubscriptionBodyType.ChannelUpdate,
                "channel.vip.add" => CreateEventSubSubscriptionBodyType.ChannelVipAdd,
                "channel.vip.remove" => CreateEventSubSubscriptionBodyType.ChannelVipRemove,
                "conduit.shard.disabled" => CreateEventSubSubscriptionBodyType.ConduitShardDisabled,
                "drop.entitlement.grant" => CreateEventSubSubscriptionBodyType.DropEntitlementGrant,
                "extension.bits_transaction.create" => CreateEventSubSubscriptionBodyType.ExtensionBitsTransactionCreate,
                "stream.offline" => CreateEventSubSubscriptionBodyType.StreamOffline,
                "stream.online" => CreateEventSubSubscriptionBodyType.StreamOnline,
                "user.authorization.grant" => CreateEventSubSubscriptionBodyType.UserAuthorizationGrant,
                "user.authorization.revoke" => CreateEventSubSubscriptionBodyType.UserAuthorizationRevoke,
                "user.update" => CreateEventSubSubscriptionBodyType.UserUpdate,
                "user.whisper.message" => CreateEventSubSubscriptionBodyType.UserWhisperMessage,
                _ => null,
            };
        }
    }
}