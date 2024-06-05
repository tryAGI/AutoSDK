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
        Automodmessagehold,
        /// <summary>
        /// 
        /// </summary>
        Automodmessageupdate,
        /// <summary>
        /// 
        /// </summary>
        Automodsettingsupdate,
        /// <summary>
        /// 
        /// </summary>
        Automodtermsupdate,
        /// <summary>
        /// 
        /// </summary>
        Channelupdate,
        /// <summary>
        /// 
        /// </summary>
        Channelfollow,
        /// <summary>
        /// 
        /// </summary>
        ChanneladBreakbegin,
        /// <summary>
        /// 
        /// </summary>
        Channelchatclear,
        /// <summary>
        /// 
        /// </summary>
        ChannelchatclearUserMessages,
        /// <summary>
        /// 
        /// </summary>
        Channelchatmessage,
        /// <summary>
        /// 
        /// </summary>
        ChannelchatmessageDelete,
        /// <summary>
        /// 
        /// </summary>
        Channelchatnotification,
        /// <summary>
        /// 
        /// </summary>
        ChannelchatSettingsupdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelchatuserMessageHold,
        /// <summary>
        /// 
        /// </summary>
        ChannelchatuserMessageUpdate,
        /// <summary>
        /// 
        /// </summary>
        Channelsubscribe,
        /// <summary>
        /// 
        /// </summary>
        Channelsubscriptionend,
        /// <summary>
        /// 
        /// </summary>
        Channelsubscriptiongift,
        /// <summary>
        /// 
        /// </summary>
        Channelsubscriptionmessage,
        /// <summary>
        /// 
        /// </summary>
        Channelcheer,
        /// <summary>
        /// 
        /// </summary>
        Channelraid,
        /// <summary>
        /// 
        /// </summary>
        Channelban,
        /// <summary>
        /// 
        /// </summary>
        Channelunban,
        /// <summary>
        /// 
        /// </summary>
        ChannelunbanRequestcreate,
        /// <summary>
        /// 
        /// </summary>
        ChannelunbanRequestresolve,
        /// <summary>
        /// 
        /// </summary>
        Channelmoderate,
        /// <summary>
        /// 
        /// </summary>
        Channelmoderatoradd,
        /// <summary>
        /// 
        /// </summary>
        Channelmoderatorremove,
        /// <summary>
        /// 
        /// </summary>
        ChannelguestStarSessionbegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelguestStarSessionend,
        /// <summary>
        /// 
        /// </summary>
        ChannelguestStarGuestupdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelguestStarSettingsupdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelchannelPointsAutomaticRewardadd,
        /// <summary>
        /// 
        /// </summary>
        ChannelchannelPointsCustomRewardadd,
        /// <summary>
        /// 
        /// </summary>
        ChannelchannelPointsCustomRewardupdate,
        /// <summary>
        /// 
        /// </summary>
        ChannelchannelPointsCustomRewardremove,
        /// <summary>
        /// 
        /// </summary>
        ChannelchannelPointsCustomRewardRedemptionadd,
        /// <summary>
        /// 
        /// </summary>
        ChannelchannelPointsCustomRewardRedemptionupdate,
        /// <summary>
        /// 
        /// </summary>
        Channelpollbegin,
        /// <summary>
        /// 
        /// </summary>
        Channelpollprogress,
        /// <summary>
        /// 
        /// </summary>
        Channelpollend,
        /// <summary>
        /// 
        /// </summary>
        Channelpredictionbegin,
        /// <summary>
        /// 
        /// </summary>
        Channelpredictionprogress,
        /// <summary>
        /// 
        /// </summary>
        Channelpredictionlock,
        /// <summary>
        /// 
        /// </summary>
        Channelpredictionend,
        /// <summary>
        /// 
        /// </summary>
        Channelvipadd,
        /// <summary>
        /// 
        /// </summary>
        Channelvipremove,
        /// <summary>
        /// 
        /// </summary>
        ChannelcharityCampaigndonate,
        /// <summary>
        /// 
        /// </summary>
        ChannelcharityCampaignstart,
        /// <summary>
        /// 
        /// </summary>
        ChannelcharityCampaignprogress,
        /// <summary>
        /// 
        /// </summary>
        ChannelcharityCampaignstop,
        /// <summary>
        /// 
        /// </summary>
        Conduitsharddisabled,
        /// <summary>
        /// 
        /// </summary>
        Dropentitlementgrant,
        /// <summary>
        /// 
        /// </summary>
        ExtensionbitsTransactioncreate,
        /// <summary>
        /// 
        /// </summary>
        Channelgoalbegin,
        /// <summary>
        /// 
        /// </summary>
        Channelgoalprogress,
        /// <summary>
        /// 
        /// </summary>
        Channelgoalend,
        /// <summary>
        /// 
        /// </summary>
        ChannelhypeTrainbegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelhypeTrainprogress,
        /// <summary>
        /// 
        /// </summary>
        ChannelhypeTrainend,
        /// <summary>
        /// 
        /// </summary>
        ChannelshieldModebegin,
        /// <summary>
        /// 
        /// </summary>
        ChannelshieldModeend,
        /// <summary>
        /// 
        /// </summary>
        Channelshoutoutcreate,
        /// <summary>
        /// 
        /// </summary>
        Channelshoutoutreceive,
        /// <summary>
        /// 
        /// </summary>
        Streamonline,
        /// <summary>
        /// 
        /// </summary>
        Streamoffline,
        /// <summary>
        /// 
        /// </summary>
        Userauthorizationgrant,
        /// <summary>
        /// 
        /// </summary>
        Userauthorizationrevoke,
        /// <summary>
        /// 
        /// </summary>
        Userupdate,
        /// <summary>
        /// 
        /// </summary>
        Userwhispermessage,
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
                EventSubSubscriptionType.Automodmessagehold => "automod.message.hold",
                EventSubSubscriptionType.Automodmessageupdate => "automod.message.update",
                EventSubSubscriptionType.Automodsettingsupdate => "automod.settings.update",
                EventSubSubscriptionType.Automodtermsupdate => "automod.terms.update",
                EventSubSubscriptionType.Channelupdate => "channel.update",
                EventSubSubscriptionType.Channelfollow => "channel.follow",
                EventSubSubscriptionType.ChanneladBreakbegin => "channel.ad_break.begin",
                EventSubSubscriptionType.Channelchatclear => "channel.chat.clear",
                EventSubSubscriptionType.ChannelchatclearUserMessages => "channel.chat.clear_user_messages",
                EventSubSubscriptionType.Channelchatmessage => "channel.chat.message",
                EventSubSubscriptionType.ChannelchatmessageDelete => "channel.chat.message_delete",
                EventSubSubscriptionType.Channelchatnotification => "channel.chat.notification",
                EventSubSubscriptionType.ChannelchatSettingsupdate => "channel.chat_settings.update",
                EventSubSubscriptionType.ChannelchatuserMessageHold => "channel.chat.user_message_hold",
                EventSubSubscriptionType.ChannelchatuserMessageUpdate => "channel.chat.user_message_update",
                EventSubSubscriptionType.Channelsubscribe => "channel.subscribe",
                EventSubSubscriptionType.Channelsubscriptionend => "channel.subscription.end",
                EventSubSubscriptionType.Channelsubscriptiongift => "channel.subscription.gift",
                EventSubSubscriptionType.Channelsubscriptionmessage => "channel.subscription.message",
                EventSubSubscriptionType.Channelcheer => "channel.cheer",
                EventSubSubscriptionType.Channelraid => "channel.raid",
                EventSubSubscriptionType.Channelban => "channel.ban",
                EventSubSubscriptionType.Channelunban => "channel.unban",
                EventSubSubscriptionType.ChannelunbanRequestcreate => "channel.unban_request.create",
                EventSubSubscriptionType.ChannelunbanRequestresolve => "channel.unban_request.resolve",
                EventSubSubscriptionType.Channelmoderate => "channel.moderate",
                EventSubSubscriptionType.Channelmoderatoradd => "channel.moderator.add",
                EventSubSubscriptionType.Channelmoderatorremove => "channel.moderator.remove",
                EventSubSubscriptionType.ChannelguestStarSessionbegin => "channel.guest_star_session.begin",
                EventSubSubscriptionType.ChannelguestStarSessionend => "channel.guest_star_session.end",
                EventSubSubscriptionType.ChannelguestStarGuestupdate => "channel.guest_star_guest.update",
                EventSubSubscriptionType.ChannelguestStarSettingsupdate => "channel.guest_star_settings.update",
                EventSubSubscriptionType.ChannelchannelPointsAutomaticRewardadd => "channel.channel_points_automatic_reward.add",
                EventSubSubscriptionType.ChannelchannelPointsCustomRewardadd => "channel.channel_points_custom_reward.add",
                EventSubSubscriptionType.ChannelchannelPointsCustomRewardupdate => "channel.channel_points_custom_reward.update",
                EventSubSubscriptionType.ChannelchannelPointsCustomRewardremove => "channel.channel_points_custom_reward.remove",
                EventSubSubscriptionType.ChannelchannelPointsCustomRewardRedemptionadd => "channel.channel_points_custom_reward_redemption.add",
                EventSubSubscriptionType.ChannelchannelPointsCustomRewardRedemptionupdate => "channel.channel_points_custom_reward_redemption.update",
                EventSubSubscriptionType.Channelpollbegin => "channel.poll.begin",
                EventSubSubscriptionType.Channelpollprogress => "channel.poll.progress",
                EventSubSubscriptionType.Channelpollend => "channel.poll.end",
                EventSubSubscriptionType.Channelpredictionbegin => "channel.prediction.begin",
                EventSubSubscriptionType.Channelpredictionprogress => "channel.prediction.progress",
                EventSubSubscriptionType.Channelpredictionlock => "channel.prediction.lock",
                EventSubSubscriptionType.Channelpredictionend => "channel.prediction.end",
                EventSubSubscriptionType.Channelvipadd => "channel.vip.add",
                EventSubSubscriptionType.Channelvipremove => "channel.vip.remove",
                EventSubSubscriptionType.ChannelcharityCampaigndonate => "channel.charity_campaign.donate",
                EventSubSubscriptionType.ChannelcharityCampaignstart => "channel.charity_campaign.start",
                EventSubSubscriptionType.ChannelcharityCampaignprogress => "channel.charity_campaign.progress",
                EventSubSubscriptionType.ChannelcharityCampaignstop => "channel.charity_campaign.stop",
                EventSubSubscriptionType.Conduitsharddisabled => "conduit.shard.disabled",
                EventSubSubscriptionType.Dropentitlementgrant => "drop.entitlement.grant",
                EventSubSubscriptionType.ExtensionbitsTransactioncreate => "extension.bits_transaction.create",
                EventSubSubscriptionType.Channelgoalbegin => "channel.goal.begin",
                EventSubSubscriptionType.Channelgoalprogress => "channel.goal.progress",
                EventSubSubscriptionType.Channelgoalend => "channel.goal.end",
                EventSubSubscriptionType.ChannelhypeTrainbegin => "channel.hype_train.begin",
                EventSubSubscriptionType.ChannelhypeTrainprogress => "channel.hype_train.progress",
                EventSubSubscriptionType.ChannelhypeTrainend => "channel.hype_train.end",
                EventSubSubscriptionType.ChannelshieldModebegin => "channel.shield_mode.begin",
                EventSubSubscriptionType.ChannelshieldModeend => "channel.shield_mode.end",
                EventSubSubscriptionType.Channelshoutoutcreate => "channel.shoutout.create",
                EventSubSubscriptionType.Channelshoutoutreceive => "channel.shoutout.receive",
                EventSubSubscriptionType.Streamonline => "stream.online",
                EventSubSubscriptionType.Streamoffline => "stream.offline",
                EventSubSubscriptionType.Userauthorizationgrant => "user.authorization.grant",
                EventSubSubscriptionType.Userauthorizationrevoke => "user.authorization.revoke",
                EventSubSubscriptionType.Userupdate => "user.update",
                EventSubSubscriptionType.Userwhispermessage => "user.whisper.message",
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
                "automod.message.hold" => EventSubSubscriptionType.Automodmessagehold,
                "automod.message.update" => EventSubSubscriptionType.Automodmessageupdate,
                "automod.settings.update" => EventSubSubscriptionType.Automodsettingsupdate,
                "automod.terms.update" => EventSubSubscriptionType.Automodtermsupdate,
                "channel.update" => EventSubSubscriptionType.Channelupdate,
                "channel.follow" => EventSubSubscriptionType.Channelfollow,
                "channel.ad_break.begin" => EventSubSubscriptionType.ChanneladBreakbegin,
                "channel.chat.clear" => EventSubSubscriptionType.Channelchatclear,
                "channel.chat.clear_user_messages" => EventSubSubscriptionType.ChannelchatclearUserMessages,
                "channel.chat.message" => EventSubSubscriptionType.Channelchatmessage,
                "channel.chat.message_delete" => EventSubSubscriptionType.ChannelchatmessageDelete,
                "channel.chat.notification" => EventSubSubscriptionType.Channelchatnotification,
                "channel.chat_settings.update" => EventSubSubscriptionType.ChannelchatSettingsupdate,
                "channel.chat.user_message_hold" => EventSubSubscriptionType.ChannelchatuserMessageHold,
                "channel.chat.user_message_update" => EventSubSubscriptionType.ChannelchatuserMessageUpdate,
                "channel.subscribe" => EventSubSubscriptionType.Channelsubscribe,
                "channel.subscription.end" => EventSubSubscriptionType.Channelsubscriptionend,
                "channel.subscription.gift" => EventSubSubscriptionType.Channelsubscriptiongift,
                "channel.subscription.message" => EventSubSubscriptionType.Channelsubscriptionmessage,
                "channel.cheer" => EventSubSubscriptionType.Channelcheer,
                "channel.raid" => EventSubSubscriptionType.Channelraid,
                "channel.ban" => EventSubSubscriptionType.Channelban,
                "channel.unban" => EventSubSubscriptionType.Channelunban,
                "channel.unban_request.create" => EventSubSubscriptionType.ChannelunbanRequestcreate,
                "channel.unban_request.resolve" => EventSubSubscriptionType.ChannelunbanRequestresolve,
                "channel.moderate" => EventSubSubscriptionType.Channelmoderate,
                "channel.moderator.add" => EventSubSubscriptionType.Channelmoderatoradd,
                "channel.moderator.remove" => EventSubSubscriptionType.Channelmoderatorremove,
                "channel.guest_star_session.begin" => EventSubSubscriptionType.ChannelguestStarSessionbegin,
                "channel.guest_star_session.end" => EventSubSubscriptionType.ChannelguestStarSessionend,
                "channel.guest_star_guest.update" => EventSubSubscriptionType.ChannelguestStarGuestupdate,
                "channel.guest_star_settings.update" => EventSubSubscriptionType.ChannelguestStarSettingsupdate,
                "channel.channel_points_automatic_reward.add" => EventSubSubscriptionType.ChannelchannelPointsAutomaticRewardadd,
                "channel.channel_points_custom_reward.add" => EventSubSubscriptionType.ChannelchannelPointsCustomRewardadd,
                "channel.channel_points_custom_reward.update" => EventSubSubscriptionType.ChannelchannelPointsCustomRewardupdate,
                "channel.channel_points_custom_reward.remove" => EventSubSubscriptionType.ChannelchannelPointsCustomRewardremove,
                "channel.channel_points_custom_reward_redemption.add" => EventSubSubscriptionType.ChannelchannelPointsCustomRewardRedemptionadd,
                "channel.channel_points_custom_reward_redemption.update" => EventSubSubscriptionType.ChannelchannelPointsCustomRewardRedemptionupdate,
                "channel.poll.begin" => EventSubSubscriptionType.Channelpollbegin,
                "channel.poll.progress" => EventSubSubscriptionType.Channelpollprogress,
                "channel.poll.end" => EventSubSubscriptionType.Channelpollend,
                "channel.prediction.begin" => EventSubSubscriptionType.Channelpredictionbegin,
                "channel.prediction.progress" => EventSubSubscriptionType.Channelpredictionprogress,
                "channel.prediction.lock" => EventSubSubscriptionType.Channelpredictionlock,
                "channel.prediction.end" => EventSubSubscriptionType.Channelpredictionend,
                "channel.vip.add" => EventSubSubscriptionType.Channelvipadd,
                "channel.vip.remove" => EventSubSubscriptionType.Channelvipremove,
                "channel.charity_campaign.donate" => EventSubSubscriptionType.ChannelcharityCampaigndonate,
                "channel.charity_campaign.start" => EventSubSubscriptionType.ChannelcharityCampaignstart,
                "channel.charity_campaign.progress" => EventSubSubscriptionType.ChannelcharityCampaignprogress,
                "channel.charity_campaign.stop" => EventSubSubscriptionType.ChannelcharityCampaignstop,
                "conduit.shard.disabled" => EventSubSubscriptionType.Conduitsharddisabled,
                "drop.entitlement.grant" => EventSubSubscriptionType.Dropentitlementgrant,
                "extension.bits_transaction.create" => EventSubSubscriptionType.ExtensionbitsTransactioncreate,
                "channel.goal.begin" => EventSubSubscriptionType.Channelgoalbegin,
                "channel.goal.progress" => EventSubSubscriptionType.Channelgoalprogress,
                "channel.goal.end" => EventSubSubscriptionType.Channelgoalend,
                "channel.hype_train.begin" => EventSubSubscriptionType.ChannelhypeTrainbegin,
                "channel.hype_train.progress" => EventSubSubscriptionType.ChannelhypeTrainprogress,
                "channel.hype_train.end" => EventSubSubscriptionType.ChannelhypeTrainend,
                "channel.shield_mode.begin" => EventSubSubscriptionType.ChannelshieldModebegin,
                "channel.shield_mode.end" => EventSubSubscriptionType.ChannelshieldModeend,
                "channel.shoutout.create" => EventSubSubscriptionType.Channelshoutoutcreate,
                "channel.shoutout.receive" => EventSubSubscriptionType.Channelshoutoutreceive,
                "stream.online" => EventSubSubscriptionType.Streamonline,
                "stream.offline" => EventSubSubscriptionType.Streamoffline,
                "user.authorization.grant" => EventSubSubscriptionType.Userauthorizationgrant,
                "user.authorization.revoke" => EventSubSubscriptionType.Userauthorizationrevoke,
                "user.update" => EventSubSubscriptionType.Userupdate,
                "user.whisper.message" => EventSubSubscriptionType.Userwhispermessage,
                _ => null,
            };
        }
    }
}