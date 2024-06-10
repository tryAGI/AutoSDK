//HintName: G.Models.CreateEventSubSubscriptionBodyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of subscription to create. For a list of subscriptions that you can create, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types). Set this field to the value in the **Name** column of the Subscription Types table.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEventSubSubscriptionBodyType
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
                CreateEventSubSubscriptionBodyType.ChannelUpdate => "channel.update",
                CreateEventSubSubscriptionBodyType.ChannelFollow => "channel.follow",
                CreateEventSubSubscriptionBodyType.ChannelAdBreakBegin => "channel.ad_break.begin",
                CreateEventSubSubscriptionBodyType.ChannelChatClear => "channel.chat.clear",
                CreateEventSubSubscriptionBodyType.ChannelChatClearUserMessages => "channel.chat.clear_user_messages",
                CreateEventSubSubscriptionBodyType.ChannelChatMessage => "channel.chat.message",
                CreateEventSubSubscriptionBodyType.ChannelChatMessageDelete => "channel.chat.message_delete",
                CreateEventSubSubscriptionBodyType.ChannelChatNotification => "channel.chat.notification",
                CreateEventSubSubscriptionBodyType.ChannelChatSettingsUpdate => "channel.chat_settings.update",
                CreateEventSubSubscriptionBodyType.ChannelChatUserMessageHold => "channel.chat.user_message_hold",
                CreateEventSubSubscriptionBodyType.ChannelChatUserMessageUpdate => "channel.chat.user_message_update",
                CreateEventSubSubscriptionBodyType.ChannelSubscribe => "channel.subscribe",
                CreateEventSubSubscriptionBodyType.ChannelSubscriptionEnd => "channel.subscription.end",
                CreateEventSubSubscriptionBodyType.ChannelSubscriptionGift => "channel.subscription.gift",
                CreateEventSubSubscriptionBodyType.ChannelSubscriptionMessage => "channel.subscription.message",
                CreateEventSubSubscriptionBodyType.ChannelCheer => "channel.cheer",
                CreateEventSubSubscriptionBodyType.ChannelRaid => "channel.raid",
                CreateEventSubSubscriptionBodyType.ChannelBan => "channel.ban",
                CreateEventSubSubscriptionBodyType.ChannelUnban => "channel.unban",
                CreateEventSubSubscriptionBodyType.ChannelUnbanRequestCreate => "channel.unban_request.create",
                CreateEventSubSubscriptionBodyType.ChannelUnbanRequestResolve => "channel.unban_request.resolve",
                CreateEventSubSubscriptionBodyType.ChannelModerate => "channel.moderate",
                CreateEventSubSubscriptionBodyType.ChannelModeratorAdd => "channel.moderator.add",
                CreateEventSubSubscriptionBodyType.ChannelModeratorRemove => "channel.moderator.remove",
                CreateEventSubSubscriptionBodyType.ChannelGuestStarSessionBegin => "channel.guest_star_session.begin",
                CreateEventSubSubscriptionBodyType.ChannelGuestStarSessionEnd => "channel.guest_star_session.end",
                CreateEventSubSubscriptionBodyType.ChannelGuestStarGuestUpdate => "channel.guest_star_guest.update",
                CreateEventSubSubscriptionBodyType.ChannelGuestStarSettingsUpdate => "channel.guest_star_settings.update",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsAutomaticRewardAdd => "channel.channel_points_automatic_reward.add",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardAdd => "channel.channel_points_custom_reward.add",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardUpdate => "channel.channel_points_custom_reward.update",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRemove => "channel.channel_points_custom_reward.remove",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRedemptionAdd => "channel.channel_points_custom_reward_redemption.add",
                CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRedemptionUpdate => "channel.channel_points_custom_reward_redemption.update",
                CreateEventSubSubscriptionBodyType.ChannelPollBegin => "channel.poll.begin",
                CreateEventSubSubscriptionBodyType.ChannelPollProgress => "channel.poll.progress",
                CreateEventSubSubscriptionBodyType.ChannelPollEnd => "channel.poll.end",
                CreateEventSubSubscriptionBodyType.ChannelPredictionBegin => "channel.prediction.begin",
                CreateEventSubSubscriptionBodyType.ChannelPredictionProgress => "channel.prediction.progress",
                CreateEventSubSubscriptionBodyType.ChannelPredictionLock => "channel.prediction.lock",
                CreateEventSubSubscriptionBodyType.ChannelPredictionEnd => "channel.prediction.end",
                CreateEventSubSubscriptionBodyType.ChannelVipAdd => "channel.vip.add",
                CreateEventSubSubscriptionBodyType.ChannelVipRemove => "channel.vip.remove",
                CreateEventSubSubscriptionBodyType.ChannelCharityCampaignDonate => "channel.charity_campaign.donate",
                CreateEventSubSubscriptionBodyType.ChannelCharityCampaignStart => "channel.charity_campaign.start",
                CreateEventSubSubscriptionBodyType.ChannelCharityCampaignProgress => "channel.charity_campaign.progress",
                CreateEventSubSubscriptionBodyType.ChannelCharityCampaignStop => "channel.charity_campaign.stop",
                CreateEventSubSubscriptionBodyType.ConduitShardDisabled => "conduit.shard.disabled",
                CreateEventSubSubscriptionBodyType.DropEntitlementGrant => "drop.entitlement.grant",
                CreateEventSubSubscriptionBodyType.ExtensionBitsTransactionCreate => "extension.bits_transaction.create",
                CreateEventSubSubscriptionBodyType.ChannelGoalBegin => "channel.goal.begin",
                CreateEventSubSubscriptionBodyType.ChannelGoalProgress => "channel.goal.progress",
                CreateEventSubSubscriptionBodyType.ChannelGoalEnd => "channel.goal.end",
                CreateEventSubSubscriptionBodyType.ChannelHypeTrainBegin => "channel.hype_train.begin",
                CreateEventSubSubscriptionBodyType.ChannelHypeTrainProgress => "channel.hype_train.progress",
                CreateEventSubSubscriptionBodyType.ChannelHypeTrainEnd => "channel.hype_train.end",
                CreateEventSubSubscriptionBodyType.ChannelShieldModeBegin => "channel.shield_mode.begin",
                CreateEventSubSubscriptionBodyType.ChannelShieldModeEnd => "channel.shield_mode.end",
                CreateEventSubSubscriptionBodyType.ChannelShoutoutCreate => "channel.shoutout.create",
                CreateEventSubSubscriptionBodyType.ChannelShoutoutReceive => "channel.shoutout.receive",
                CreateEventSubSubscriptionBodyType.StreamOnline => "stream.online",
                CreateEventSubSubscriptionBodyType.StreamOffline => "stream.offline",
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
                "channel.update" => CreateEventSubSubscriptionBodyType.ChannelUpdate,
                "channel.follow" => CreateEventSubSubscriptionBodyType.ChannelFollow,
                "channel.ad_break.begin" => CreateEventSubSubscriptionBodyType.ChannelAdBreakBegin,
                "channel.chat.clear" => CreateEventSubSubscriptionBodyType.ChannelChatClear,
                "channel.chat.clear_user_messages" => CreateEventSubSubscriptionBodyType.ChannelChatClearUserMessages,
                "channel.chat.message" => CreateEventSubSubscriptionBodyType.ChannelChatMessage,
                "channel.chat.message_delete" => CreateEventSubSubscriptionBodyType.ChannelChatMessageDelete,
                "channel.chat.notification" => CreateEventSubSubscriptionBodyType.ChannelChatNotification,
                "channel.chat_settings.update" => CreateEventSubSubscriptionBodyType.ChannelChatSettingsUpdate,
                "channel.chat.user_message_hold" => CreateEventSubSubscriptionBodyType.ChannelChatUserMessageHold,
                "channel.chat.user_message_update" => CreateEventSubSubscriptionBodyType.ChannelChatUserMessageUpdate,
                "channel.subscribe" => CreateEventSubSubscriptionBodyType.ChannelSubscribe,
                "channel.subscription.end" => CreateEventSubSubscriptionBodyType.ChannelSubscriptionEnd,
                "channel.subscription.gift" => CreateEventSubSubscriptionBodyType.ChannelSubscriptionGift,
                "channel.subscription.message" => CreateEventSubSubscriptionBodyType.ChannelSubscriptionMessage,
                "channel.cheer" => CreateEventSubSubscriptionBodyType.ChannelCheer,
                "channel.raid" => CreateEventSubSubscriptionBodyType.ChannelRaid,
                "channel.ban" => CreateEventSubSubscriptionBodyType.ChannelBan,
                "channel.unban" => CreateEventSubSubscriptionBodyType.ChannelUnban,
                "channel.unban_request.create" => CreateEventSubSubscriptionBodyType.ChannelUnbanRequestCreate,
                "channel.unban_request.resolve" => CreateEventSubSubscriptionBodyType.ChannelUnbanRequestResolve,
                "channel.moderate" => CreateEventSubSubscriptionBodyType.ChannelModerate,
                "channel.moderator.add" => CreateEventSubSubscriptionBodyType.ChannelModeratorAdd,
                "channel.moderator.remove" => CreateEventSubSubscriptionBodyType.ChannelModeratorRemove,
                "channel.guest_star_session.begin" => CreateEventSubSubscriptionBodyType.ChannelGuestStarSessionBegin,
                "channel.guest_star_session.end" => CreateEventSubSubscriptionBodyType.ChannelGuestStarSessionEnd,
                "channel.guest_star_guest.update" => CreateEventSubSubscriptionBodyType.ChannelGuestStarGuestUpdate,
                "channel.guest_star_settings.update" => CreateEventSubSubscriptionBodyType.ChannelGuestStarSettingsUpdate,
                "channel.channel_points_automatic_reward.add" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsAutomaticRewardAdd,
                "channel.channel_points_custom_reward.add" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardAdd,
                "channel.channel_points_custom_reward.update" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardUpdate,
                "channel.channel_points_custom_reward.remove" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRemove,
                "channel.channel_points_custom_reward_redemption.add" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRedemptionAdd,
                "channel.channel_points_custom_reward_redemption.update" => CreateEventSubSubscriptionBodyType.ChannelChannelPointsCustomRewardRedemptionUpdate,
                "channel.poll.begin" => CreateEventSubSubscriptionBodyType.ChannelPollBegin,
                "channel.poll.progress" => CreateEventSubSubscriptionBodyType.ChannelPollProgress,
                "channel.poll.end" => CreateEventSubSubscriptionBodyType.ChannelPollEnd,
                "channel.prediction.begin" => CreateEventSubSubscriptionBodyType.ChannelPredictionBegin,
                "channel.prediction.progress" => CreateEventSubSubscriptionBodyType.ChannelPredictionProgress,
                "channel.prediction.lock" => CreateEventSubSubscriptionBodyType.ChannelPredictionLock,
                "channel.prediction.end" => CreateEventSubSubscriptionBodyType.ChannelPredictionEnd,
                "channel.vip.add" => CreateEventSubSubscriptionBodyType.ChannelVipAdd,
                "channel.vip.remove" => CreateEventSubSubscriptionBodyType.ChannelVipRemove,
                "channel.charity_campaign.donate" => CreateEventSubSubscriptionBodyType.ChannelCharityCampaignDonate,
                "channel.charity_campaign.start" => CreateEventSubSubscriptionBodyType.ChannelCharityCampaignStart,
                "channel.charity_campaign.progress" => CreateEventSubSubscriptionBodyType.ChannelCharityCampaignProgress,
                "channel.charity_campaign.stop" => CreateEventSubSubscriptionBodyType.ChannelCharityCampaignStop,
                "conduit.shard.disabled" => CreateEventSubSubscriptionBodyType.ConduitShardDisabled,
                "drop.entitlement.grant" => CreateEventSubSubscriptionBodyType.DropEntitlementGrant,
                "extension.bits_transaction.create" => CreateEventSubSubscriptionBodyType.ExtensionBitsTransactionCreate,
                "channel.goal.begin" => CreateEventSubSubscriptionBodyType.ChannelGoalBegin,
                "channel.goal.progress" => CreateEventSubSubscriptionBodyType.ChannelGoalProgress,
                "channel.goal.end" => CreateEventSubSubscriptionBodyType.ChannelGoalEnd,
                "channel.hype_train.begin" => CreateEventSubSubscriptionBodyType.ChannelHypeTrainBegin,
                "channel.hype_train.progress" => CreateEventSubSubscriptionBodyType.ChannelHypeTrainProgress,
                "channel.hype_train.end" => CreateEventSubSubscriptionBodyType.ChannelHypeTrainEnd,
                "channel.shield_mode.begin" => CreateEventSubSubscriptionBodyType.ChannelShieldModeBegin,
                "channel.shield_mode.end" => CreateEventSubSubscriptionBodyType.ChannelShieldModeEnd,
                "channel.shoutout.create" => CreateEventSubSubscriptionBodyType.ChannelShoutoutCreate,
                "channel.shoutout.receive" => CreateEventSubSubscriptionBodyType.ChannelShoutoutReceive,
                "stream.online" => CreateEventSubSubscriptionBodyType.StreamOnline,
                "stream.offline" => CreateEventSubSubscriptionBodyType.StreamOffline,
                "user.authorization.grant" => CreateEventSubSubscriptionBodyType.UserAuthorizationGrant,
                "user.authorization.revoke" => CreateEventSubSubscriptionBodyType.UserAuthorizationRevoke,
                "user.update" => CreateEventSubSubscriptionBodyType.UserUpdate,
                "user.whisper.message" => CreateEventSubSubscriptionBodyType.UserWhisperMessage,
                _ => null,
            };
        }
    }
}