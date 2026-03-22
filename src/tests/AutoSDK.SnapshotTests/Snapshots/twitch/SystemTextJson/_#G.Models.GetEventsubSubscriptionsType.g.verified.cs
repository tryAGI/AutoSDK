//HintName: G.Models.GetEventsubSubscriptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetEventsubSubscriptionsType
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
    public static class GetEventsubSubscriptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEventsubSubscriptionsType value)
        {
            return value switch
            {
                GetEventsubSubscriptionsType.AutomodMessageHold => "automod.message.hold",
                GetEventsubSubscriptionsType.AutomodMessageUpdate => "automod.message.update",
                GetEventsubSubscriptionsType.AutomodSettingsUpdate => "automod.settings.update",
                GetEventsubSubscriptionsType.AutomodTermsUpdate => "automod.terms.update",
                GetEventsubSubscriptionsType.ChannelAdBreakBegin => "channel.ad_break.begin",
                GetEventsubSubscriptionsType.ChannelBan => "channel.ban",
                GetEventsubSubscriptionsType.ChannelChannelPointsAutomaticRewardAdd => "channel.channel_points_automatic_reward.add",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardAdd => "channel.channel_points_custom_reward.add",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRemove => "channel.channel_points_custom_reward.remove",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardUpdate => "channel.channel_points_custom_reward.update",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRedemptionAdd => "channel.channel_points_custom_reward_redemption.add",
                GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRedemptionUpdate => "channel.channel_points_custom_reward_redemption.update",
                GetEventsubSubscriptionsType.ChannelCharityCampaignDonate => "channel.charity_campaign.donate",
                GetEventsubSubscriptionsType.ChannelCharityCampaignProgress => "channel.charity_campaign.progress",
                GetEventsubSubscriptionsType.ChannelCharityCampaignStart => "channel.charity_campaign.start",
                GetEventsubSubscriptionsType.ChannelCharityCampaignStop => "channel.charity_campaign.stop",
                GetEventsubSubscriptionsType.ChannelChatClear => "channel.chat.clear",
                GetEventsubSubscriptionsType.ChannelChatClearUserMessages => "channel.chat.clear_user_messages",
                GetEventsubSubscriptionsType.ChannelChatMessage => "channel.chat.message",
                GetEventsubSubscriptionsType.ChannelChatMessageDelete => "channel.chat.message_delete",
                GetEventsubSubscriptionsType.ChannelChatNotification => "channel.chat.notification",
                GetEventsubSubscriptionsType.ChannelChatUserMessageHold => "channel.chat.user_message_hold",
                GetEventsubSubscriptionsType.ChannelChatUserMessageUpdate => "channel.chat.user_message_update",
                GetEventsubSubscriptionsType.ChannelChatSettingsUpdate => "channel.chat_settings.update",
                GetEventsubSubscriptionsType.ChannelCheer => "channel.cheer",
                GetEventsubSubscriptionsType.ChannelFollow => "channel.follow",
                GetEventsubSubscriptionsType.ChannelGoalBegin => "channel.goal.begin",
                GetEventsubSubscriptionsType.ChannelGoalEnd => "channel.goal.end",
                GetEventsubSubscriptionsType.ChannelGoalProgress => "channel.goal.progress",
                GetEventsubSubscriptionsType.ChannelGuestStarGuestUpdate => "channel.guest_star_guest.update",
                GetEventsubSubscriptionsType.ChannelGuestStarSessionBegin => "channel.guest_star_session.begin",
                GetEventsubSubscriptionsType.ChannelGuestStarSessionEnd => "channel.guest_star_session.end",
                GetEventsubSubscriptionsType.ChannelGuestStarSettingsUpdate => "channel.guest_star_settings.update",
                GetEventsubSubscriptionsType.ChannelHypeTrainBegin => "channel.hype_train.begin",
                GetEventsubSubscriptionsType.ChannelHypeTrainEnd => "channel.hype_train.end",
                GetEventsubSubscriptionsType.ChannelHypeTrainProgress => "channel.hype_train.progress",
                GetEventsubSubscriptionsType.ChannelModerate => "channel.moderate",
                GetEventsubSubscriptionsType.ChannelModeratorAdd => "channel.moderator.add",
                GetEventsubSubscriptionsType.ChannelModeratorRemove => "channel.moderator.remove",
                GetEventsubSubscriptionsType.ChannelPollBegin => "channel.poll.begin",
                GetEventsubSubscriptionsType.ChannelPollEnd => "channel.poll.end",
                GetEventsubSubscriptionsType.ChannelPollProgress => "channel.poll.progress",
                GetEventsubSubscriptionsType.ChannelPredictionBegin => "channel.prediction.begin",
                GetEventsubSubscriptionsType.ChannelPredictionEnd => "channel.prediction.end",
                GetEventsubSubscriptionsType.ChannelPredictionLock => "channel.prediction.lock",
                GetEventsubSubscriptionsType.ChannelPredictionProgress => "channel.prediction.progress",
                GetEventsubSubscriptionsType.ChannelRaid => "channel.raid",
                GetEventsubSubscriptionsType.ChannelShieldModeBegin => "channel.shield_mode.begin",
                GetEventsubSubscriptionsType.ChannelShieldModeEnd => "channel.shield_mode.end",
                GetEventsubSubscriptionsType.ChannelShoutoutCreate => "channel.shoutout.create",
                GetEventsubSubscriptionsType.ChannelShoutoutReceive => "channel.shoutout.receive",
                GetEventsubSubscriptionsType.ChannelSubscribe => "channel.subscribe",
                GetEventsubSubscriptionsType.ChannelSubscriptionEnd => "channel.subscription.end",
                GetEventsubSubscriptionsType.ChannelSubscriptionGift => "channel.subscription.gift",
                GetEventsubSubscriptionsType.ChannelSubscriptionMessage => "channel.subscription.message",
                GetEventsubSubscriptionsType.ChannelUnban => "channel.unban",
                GetEventsubSubscriptionsType.ChannelUnbanRequestCreate => "channel.unban_request.create",
                GetEventsubSubscriptionsType.ChannelUnbanRequestResolve => "channel.unban_request.resolve",
                GetEventsubSubscriptionsType.ChannelUpdate => "channel.update",
                GetEventsubSubscriptionsType.ChannelVipAdd => "channel.vip.add",
                GetEventsubSubscriptionsType.ChannelVipRemove => "channel.vip.remove",
                GetEventsubSubscriptionsType.ConduitShardDisabled => "conduit.shard.disabled",
                GetEventsubSubscriptionsType.DropEntitlementGrant => "drop.entitlement.grant",
                GetEventsubSubscriptionsType.ExtensionBitsTransactionCreate => "extension.bits_transaction.create",
                GetEventsubSubscriptionsType.StreamOffline => "stream.offline",
                GetEventsubSubscriptionsType.StreamOnline => "stream.online",
                GetEventsubSubscriptionsType.UserAuthorizationGrant => "user.authorization.grant",
                GetEventsubSubscriptionsType.UserAuthorizationRevoke => "user.authorization.revoke",
                GetEventsubSubscriptionsType.UserUpdate => "user.update",
                GetEventsubSubscriptionsType.UserWhisperMessage => "user.whisper.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEventsubSubscriptionsType? ToEnum(string value)
        {
            return value switch
            {
                "automod.message.hold" => GetEventsubSubscriptionsType.AutomodMessageHold,
                "automod.message.update" => GetEventsubSubscriptionsType.AutomodMessageUpdate,
                "automod.settings.update" => GetEventsubSubscriptionsType.AutomodSettingsUpdate,
                "automod.terms.update" => GetEventsubSubscriptionsType.AutomodTermsUpdate,
                "channel.ad_break.begin" => GetEventsubSubscriptionsType.ChannelAdBreakBegin,
                "channel.ban" => GetEventsubSubscriptionsType.ChannelBan,
                "channel.channel_points_automatic_reward.add" => GetEventsubSubscriptionsType.ChannelChannelPointsAutomaticRewardAdd,
                "channel.channel_points_custom_reward.add" => GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardAdd,
                "channel.channel_points_custom_reward.remove" => GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRemove,
                "channel.channel_points_custom_reward.update" => GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardUpdate,
                "channel.channel_points_custom_reward_redemption.add" => GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRedemptionAdd,
                "channel.channel_points_custom_reward_redemption.update" => GetEventsubSubscriptionsType.ChannelChannelPointsCustomRewardRedemptionUpdate,
                "channel.charity_campaign.donate" => GetEventsubSubscriptionsType.ChannelCharityCampaignDonate,
                "channel.charity_campaign.progress" => GetEventsubSubscriptionsType.ChannelCharityCampaignProgress,
                "channel.charity_campaign.start" => GetEventsubSubscriptionsType.ChannelCharityCampaignStart,
                "channel.charity_campaign.stop" => GetEventsubSubscriptionsType.ChannelCharityCampaignStop,
                "channel.chat.clear" => GetEventsubSubscriptionsType.ChannelChatClear,
                "channel.chat.clear_user_messages" => GetEventsubSubscriptionsType.ChannelChatClearUserMessages,
                "channel.chat.message" => GetEventsubSubscriptionsType.ChannelChatMessage,
                "channel.chat.message_delete" => GetEventsubSubscriptionsType.ChannelChatMessageDelete,
                "channel.chat.notification" => GetEventsubSubscriptionsType.ChannelChatNotification,
                "channel.chat.user_message_hold" => GetEventsubSubscriptionsType.ChannelChatUserMessageHold,
                "channel.chat.user_message_update" => GetEventsubSubscriptionsType.ChannelChatUserMessageUpdate,
                "channel.chat_settings.update" => GetEventsubSubscriptionsType.ChannelChatSettingsUpdate,
                "channel.cheer" => GetEventsubSubscriptionsType.ChannelCheer,
                "channel.follow" => GetEventsubSubscriptionsType.ChannelFollow,
                "channel.goal.begin" => GetEventsubSubscriptionsType.ChannelGoalBegin,
                "channel.goal.end" => GetEventsubSubscriptionsType.ChannelGoalEnd,
                "channel.goal.progress" => GetEventsubSubscriptionsType.ChannelGoalProgress,
                "channel.guest_star_guest.update" => GetEventsubSubscriptionsType.ChannelGuestStarGuestUpdate,
                "channel.guest_star_session.begin" => GetEventsubSubscriptionsType.ChannelGuestStarSessionBegin,
                "channel.guest_star_session.end" => GetEventsubSubscriptionsType.ChannelGuestStarSessionEnd,
                "channel.guest_star_settings.update" => GetEventsubSubscriptionsType.ChannelGuestStarSettingsUpdate,
                "channel.hype_train.begin" => GetEventsubSubscriptionsType.ChannelHypeTrainBegin,
                "channel.hype_train.end" => GetEventsubSubscriptionsType.ChannelHypeTrainEnd,
                "channel.hype_train.progress" => GetEventsubSubscriptionsType.ChannelHypeTrainProgress,
                "channel.moderate" => GetEventsubSubscriptionsType.ChannelModerate,
                "channel.moderator.add" => GetEventsubSubscriptionsType.ChannelModeratorAdd,
                "channel.moderator.remove" => GetEventsubSubscriptionsType.ChannelModeratorRemove,
                "channel.poll.begin" => GetEventsubSubscriptionsType.ChannelPollBegin,
                "channel.poll.end" => GetEventsubSubscriptionsType.ChannelPollEnd,
                "channel.poll.progress" => GetEventsubSubscriptionsType.ChannelPollProgress,
                "channel.prediction.begin" => GetEventsubSubscriptionsType.ChannelPredictionBegin,
                "channel.prediction.end" => GetEventsubSubscriptionsType.ChannelPredictionEnd,
                "channel.prediction.lock" => GetEventsubSubscriptionsType.ChannelPredictionLock,
                "channel.prediction.progress" => GetEventsubSubscriptionsType.ChannelPredictionProgress,
                "channel.raid" => GetEventsubSubscriptionsType.ChannelRaid,
                "channel.shield_mode.begin" => GetEventsubSubscriptionsType.ChannelShieldModeBegin,
                "channel.shield_mode.end" => GetEventsubSubscriptionsType.ChannelShieldModeEnd,
                "channel.shoutout.create" => GetEventsubSubscriptionsType.ChannelShoutoutCreate,
                "channel.shoutout.receive" => GetEventsubSubscriptionsType.ChannelShoutoutReceive,
                "channel.subscribe" => GetEventsubSubscriptionsType.ChannelSubscribe,
                "channel.subscription.end" => GetEventsubSubscriptionsType.ChannelSubscriptionEnd,
                "channel.subscription.gift" => GetEventsubSubscriptionsType.ChannelSubscriptionGift,
                "channel.subscription.message" => GetEventsubSubscriptionsType.ChannelSubscriptionMessage,
                "channel.unban" => GetEventsubSubscriptionsType.ChannelUnban,
                "channel.unban_request.create" => GetEventsubSubscriptionsType.ChannelUnbanRequestCreate,
                "channel.unban_request.resolve" => GetEventsubSubscriptionsType.ChannelUnbanRequestResolve,
                "channel.update" => GetEventsubSubscriptionsType.ChannelUpdate,
                "channel.vip.add" => GetEventsubSubscriptionsType.ChannelVipAdd,
                "channel.vip.remove" => GetEventsubSubscriptionsType.ChannelVipRemove,
                "conduit.shard.disabled" => GetEventsubSubscriptionsType.ConduitShardDisabled,
                "drop.entitlement.grant" => GetEventsubSubscriptionsType.DropEntitlementGrant,
                "extension.bits_transaction.create" => GetEventsubSubscriptionsType.ExtensionBitsTransactionCreate,
                "stream.offline" => GetEventsubSubscriptionsType.StreamOffline,
                "stream.online" => GetEventsubSubscriptionsType.StreamOnline,
                "user.authorization.grant" => GetEventsubSubscriptionsType.UserAuthorizationGrant,
                "user.authorization.revoke" => GetEventsubSubscriptionsType.UserAuthorizationRevoke,
                "user.update" => GetEventsubSubscriptionsType.UserUpdate,
                "user.whisper.message" => GetEventsubSubscriptionsType.UserWhisperMessage,
                _ => null,
            };
        }
    }
}