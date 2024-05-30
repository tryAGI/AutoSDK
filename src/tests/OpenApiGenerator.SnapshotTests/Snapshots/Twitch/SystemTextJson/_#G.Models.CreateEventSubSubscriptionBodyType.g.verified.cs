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
    public static class CreateEventSubSubscriptionBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEventSubSubscriptionBodyType value)
        {
            return value switch
            {
                CreateEventSubSubscriptionBodyType.Automodmessagehold => "automod.message.hold",
                CreateEventSubSubscriptionBodyType.Automodmessageupdate => "automod.message.update",
                CreateEventSubSubscriptionBodyType.Automodsettingsupdate => "automod.settings.update",
                CreateEventSubSubscriptionBodyType.Automodtermsupdate => "automod.terms.update",
                CreateEventSubSubscriptionBodyType.Channelupdate => "channel.update",
                CreateEventSubSubscriptionBodyType.Channelfollow => "channel.follow",
                CreateEventSubSubscriptionBodyType.ChanneladBreakbegin => "channel.ad_break.begin",
                CreateEventSubSubscriptionBodyType.Channelchatclear => "channel.chat.clear",
                CreateEventSubSubscriptionBodyType.ChannelchatclearUserMessages => "channel.chat.clear_user_messages",
                CreateEventSubSubscriptionBodyType.Channelchatmessage => "channel.chat.message",
                CreateEventSubSubscriptionBodyType.ChannelchatmessageDelete => "channel.chat.message_delete",
                CreateEventSubSubscriptionBodyType.Channelchatnotification => "channel.chat.notification",
                CreateEventSubSubscriptionBodyType.ChannelchatSettingsupdate => "channel.chat_settings.update",
                CreateEventSubSubscriptionBodyType.ChannelchatuserMessageHold => "channel.chat.user_message_hold",
                CreateEventSubSubscriptionBodyType.ChannelchatuserMessageUpdate => "channel.chat.user_message_update",
                CreateEventSubSubscriptionBodyType.Channelsubscribe => "channel.subscribe",
                CreateEventSubSubscriptionBodyType.Channelsubscriptionend => "channel.subscription.end",
                CreateEventSubSubscriptionBodyType.Channelsubscriptiongift => "channel.subscription.gift",
                CreateEventSubSubscriptionBodyType.Channelsubscriptionmessage => "channel.subscription.message",
                CreateEventSubSubscriptionBodyType.Channelcheer => "channel.cheer",
                CreateEventSubSubscriptionBodyType.Channelraid => "channel.raid",
                CreateEventSubSubscriptionBodyType.Channelban => "channel.ban",
                CreateEventSubSubscriptionBodyType.Channelunban => "channel.unban",
                CreateEventSubSubscriptionBodyType.ChannelunbanRequestcreate => "channel.unban_request.create",
                CreateEventSubSubscriptionBodyType.ChannelunbanRequestresolve => "channel.unban_request.resolve",
                CreateEventSubSubscriptionBodyType.Channelmoderate => "channel.moderate",
                CreateEventSubSubscriptionBodyType.Channelmoderatoradd => "channel.moderator.add",
                CreateEventSubSubscriptionBodyType.Channelmoderatorremove => "channel.moderator.remove",
                CreateEventSubSubscriptionBodyType.ChannelguestStarSessionbegin => "channel.guest_star_session.begin",
                CreateEventSubSubscriptionBodyType.ChannelguestStarSessionend => "channel.guest_star_session.end",
                CreateEventSubSubscriptionBodyType.ChannelguestStarGuestupdate => "channel.guest_star_guest.update",
                CreateEventSubSubscriptionBodyType.ChannelguestStarSettingsupdate => "channel.guest_star_settings.update",
                CreateEventSubSubscriptionBodyType.ChannelchannelPointsAutomaticRewardadd => "channel.channel_points_automatic_reward.add",
                CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardadd => "channel.channel_points_custom_reward.add",
                CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardupdate => "channel.channel_points_custom_reward.update",
                CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardremove => "channel.channel_points_custom_reward.remove",
                CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardRedemptionadd => "channel.channel_points_custom_reward_redemption.add",
                CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardRedemptionupdate => "channel.channel_points_custom_reward_redemption.update",
                CreateEventSubSubscriptionBodyType.Channelpollbegin => "channel.poll.begin",
                CreateEventSubSubscriptionBodyType.Channelpollprogress => "channel.poll.progress",
                CreateEventSubSubscriptionBodyType.Channelpollend => "channel.poll.end",
                CreateEventSubSubscriptionBodyType.Channelpredictionbegin => "channel.prediction.begin",
                CreateEventSubSubscriptionBodyType.Channelpredictionprogress => "channel.prediction.progress",
                CreateEventSubSubscriptionBodyType.Channelpredictionlock => "channel.prediction.lock",
                CreateEventSubSubscriptionBodyType.Channelpredictionend => "channel.prediction.end",
                CreateEventSubSubscriptionBodyType.Channelvipadd => "channel.vip.add",
                CreateEventSubSubscriptionBodyType.Channelvipremove => "channel.vip.remove",
                CreateEventSubSubscriptionBodyType.ChannelcharityCampaigndonate => "channel.charity_campaign.donate",
                CreateEventSubSubscriptionBodyType.ChannelcharityCampaignstart => "channel.charity_campaign.start",
                CreateEventSubSubscriptionBodyType.ChannelcharityCampaignprogress => "channel.charity_campaign.progress",
                CreateEventSubSubscriptionBodyType.ChannelcharityCampaignstop => "channel.charity_campaign.stop",
                CreateEventSubSubscriptionBodyType.Conduitsharddisabled => "conduit.shard.disabled",
                CreateEventSubSubscriptionBodyType.Dropentitlementgrant => "drop.entitlement.grant",
                CreateEventSubSubscriptionBodyType.ExtensionbitsTransactioncreate => "extension.bits_transaction.create",
                CreateEventSubSubscriptionBodyType.Channelgoalbegin => "channel.goal.begin",
                CreateEventSubSubscriptionBodyType.Channelgoalprogress => "channel.goal.progress",
                CreateEventSubSubscriptionBodyType.Channelgoalend => "channel.goal.end",
                CreateEventSubSubscriptionBodyType.ChannelhypeTrainbegin => "channel.hype_train.begin",
                CreateEventSubSubscriptionBodyType.ChannelhypeTrainprogress => "channel.hype_train.progress",
                CreateEventSubSubscriptionBodyType.ChannelhypeTrainend => "channel.hype_train.end",
                CreateEventSubSubscriptionBodyType.ChannelshieldModebegin => "channel.shield_mode.begin",
                CreateEventSubSubscriptionBodyType.ChannelshieldModeend => "channel.shield_mode.end",
                CreateEventSubSubscriptionBodyType.Channelshoutoutcreate => "channel.shoutout.create",
                CreateEventSubSubscriptionBodyType.Channelshoutoutreceive => "channel.shoutout.receive",
                CreateEventSubSubscriptionBodyType.Streamonline => "stream.online",
                CreateEventSubSubscriptionBodyType.Streamoffline => "stream.offline",
                CreateEventSubSubscriptionBodyType.Userauthorizationgrant => "user.authorization.grant",
                CreateEventSubSubscriptionBodyType.Userauthorizationrevoke => "user.authorization.revoke",
                CreateEventSubSubscriptionBodyType.Userupdate => "user.update",
                CreateEventSubSubscriptionBodyType.Userwhispermessage => "user.whisper.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEventSubSubscriptionBodyType ToEnum(string value)
        {
            return value switch
            {
                "automod.message.hold" => CreateEventSubSubscriptionBodyType.Automodmessagehold,
                "automod.message.update" => CreateEventSubSubscriptionBodyType.Automodmessageupdate,
                "automod.settings.update" => CreateEventSubSubscriptionBodyType.Automodsettingsupdate,
                "automod.terms.update" => CreateEventSubSubscriptionBodyType.Automodtermsupdate,
                "channel.update" => CreateEventSubSubscriptionBodyType.Channelupdate,
                "channel.follow" => CreateEventSubSubscriptionBodyType.Channelfollow,
                "channel.ad_break.begin" => CreateEventSubSubscriptionBodyType.ChanneladBreakbegin,
                "channel.chat.clear" => CreateEventSubSubscriptionBodyType.Channelchatclear,
                "channel.chat.clear_user_messages" => CreateEventSubSubscriptionBodyType.ChannelchatclearUserMessages,
                "channel.chat.message" => CreateEventSubSubscriptionBodyType.Channelchatmessage,
                "channel.chat.message_delete" => CreateEventSubSubscriptionBodyType.ChannelchatmessageDelete,
                "channel.chat.notification" => CreateEventSubSubscriptionBodyType.Channelchatnotification,
                "channel.chat_settings.update" => CreateEventSubSubscriptionBodyType.ChannelchatSettingsupdate,
                "channel.chat.user_message_hold" => CreateEventSubSubscriptionBodyType.ChannelchatuserMessageHold,
                "channel.chat.user_message_update" => CreateEventSubSubscriptionBodyType.ChannelchatuserMessageUpdate,
                "channel.subscribe" => CreateEventSubSubscriptionBodyType.Channelsubscribe,
                "channel.subscription.end" => CreateEventSubSubscriptionBodyType.Channelsubscriptionend,
                "channel.subscription.gift" => CreateEventSubSubscriptionBodyType.Channelsubscriptiongift,
                "channel.subscription.message" => CreateEventSubSubscriptionBodyType.Channelsubscriptionmessage,
                "channel.cheer" => CreateEventSubSubscriptionBodyType.Channelcheer,
                "channel.raid" => CreateEventSubSubscriptionBodyType.Channelraid,
                "channel.ban" => CreateEventSubSubscriptionBodyType.Channelban,
                "channel.unban" => CreateEventSubSubscriptionBodyType.Channelunban,
                "channel.unban_request.create" => CreateEventSubSubscriptionBodyType.ChannelunbanRequestcreate,
                "channel.unban_request.resolve" => CreateEventSubSubscriptionBodyType.ChannelunbanRequestresolve,
                "channel.moderate" => CreateEventSubSubscriptionBodyType.Channelmoderate,
                "channel.moderator.add" => CreateEventSubSubscriptionBodyType.Channelmoderatoradd,
                "channel.moderator.remove" => CreateEventSubSubscriptionBodyType.Channelmoderatorremove,
                "channel.guest_star_session.begin" => CreateEventSubSubscriptionBodyType.ChannelguestStarSessionbegin,
                "channel.guest_star_session.end" => CreateEventSubSubscriptionBodyType.ChannelguestStarSessionend,
                "channel.guest_star_guest.update" => CreateEventSubSubscriptionBodyType.ChannelguestStarGuestupdate,
                "channel.guest_star_settings.update" => CreateEventSubSubscriptionBodyType.ChannelguestStarSettingsupdate,
                "channel.channel_points_automatic_reward.add" => CreateEventSubSubscriptionBodyType.ChannelchannelPointsAutomaticRewardadd,
                "channel.channel_points_custom_reward.add" => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardadd,
                "channel.channel_points_custom_reward.update" => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardupdate,
                "channel.channel_points_custom_reward.remove" => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardremove,
                "channel.channel_points_custom_reward_redemption.add" => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardRedemptionadd,
                "channel.channel_points_custom_reward_redemption.update" => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardRedemptionupdate,
                "channel.poll.begin" => CreateEventSubSubscriptionBodyType.Channelpollbegin,
                "channel.poll.progress" => CreateEventSubSubscriptionBodyType.Channelpollprogress,
                "channel.poll.end" => CreateEventSubSubscriptionBodyType.Channelpollend,
                "channel.prediction.begin" => CreateEventSubSubscriptionBodyType.Channelpredictionbegin,
                "channel.prediction.progress" => CreateEventSubSubscriptionBodyType.Channelpredictionprogress,
                "channel.prediction.lock" => CreateEventSubSubscriptionBodyType.Channelpredictionlock,
                "channel.prediction.end" => CreateEventSubSubscriptionBodyType.Channelpredictionend,
                "channel.vip.add" => CreateEventSubSubscriptionBodyType.Channelvipadd,
                "channel.vip.remove" => CreateEventSubSubscriptionBodyType.Channelvipremove,
                "channel.charity_campaign.donate" => CreateEventSubSubscriptionBodyType.ChannelcharityCampaigndonate,
                "channel.charity_campaign.start" => CreateEventSubSubscriptionBodyType.ChannelcharityCampaignstart,
                "channel.charity_campaign.progress" => CreateEventSubSubscriptionBodyType.ChannelcharityCampaignprogress,
                "channel.charity_campaign.stop" => CreateEventSubSubscriptionBodyType.ChannelcharityCampaignstop,
                "conduit.shard.disabled" => CreateEventSubSubscriptionBodyType.Conduitsharddisabled,
                "drop.entitlement.grant" => CreateEventSubSubscriptionBodyType.Dropentitlementgrant,
                "extension.bits_transaction.create" => CreateEventSubSubscriptionBodyType.ExtensionbitsTransactioncreate,
                "channel.goal.begin" => CreateEventSubSubscriptionBodyType.Channelgoalbegin,
                "channel.goal.progress" => CreateEventSubSubscriptionBodyType.Channelgoalprogress,
                "channel.goal.end" => CreateEventSubSubscriptionBodyType.Channelgoalend,
                "channel.hype_train.begin" => CreateEventSubSubscriptionBodyType.ChannelhypeTrainbegin,
                "channel.hype_train.progress" => CreateEventSubSubscriptionBodyType.ChannelhypeTrainprogress,
                "channel.hype_train.end" => CreateEventSubSubscriptionBodyType.ChannelhypeTrainend,
                "channel.shield_mode.begin" => CreateEventSubSubscriptionBodyType.ChannelshieldModebegin,
                "channel.shield_mode.end" => CreateEventSubSubscriptionBodyType.ChannelshieldModeend,
                "channel.shoutout.create" => CreateEventSubSubscriptionBodyType.Channelshoutoutcreate,
                "channel.shoutout.receive" => CreateEventSubSubscriptionBodyType.Channelshoutoutreceive,
                "stream.online" => CreateEventSubSubscriptionBodyType.Streamonline,
                "stream.offline" => CreateEventSubSubscriptionBodyType.Streamoffline,
                "user.authorization.grant" => CreateEventSubSubscriptionBodyType.Userauthorizationgrant,
                "user.authorization.revoke" => CreateEventSubSubscriptionBodyType.Userauthorizationrevoke,
                "user.update" => CreateEventSubSubscriptionBodyType.Userupdate,
                "user.whisper.message" => CreateEventSubSubscriptionBodyType.Userwhispermessage,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}