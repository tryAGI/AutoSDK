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

    public static class EventSubSubscriptionTypeExtensions
    {
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
        public static EventSubSubscriptionType ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EventSubSubscriptionType ToEnum(int value)
        {
            return value switch
            {
                0 => EventSubSubscriptionType.Automodmessagehold,
                1 => EventSubSubscriptionType.Automodmessageupdate,
                2 => EventSubSubscriptionType.Automodsettingsupdate,
                3 => EventSubSubscriptionType.Automodtermsupdate,
                4 => EventSubSubscriptionType.Channelupdate,
                5 => EventSubSubscriptionType.Channelfollow,
                6 => EventSubSubscriptionType.ChanneladBreakbegin,
                7 => EventSubSubscriptionType.Channelchatclear,
                8 => EventSubSubscriptionType.ChannelchatclearUserMessages,
                9 => EventSubSubscriptionType.Channelchatmessage,
                10 => EventSubSubscriptionType.ChannelchatmessageDelete,
                11 => EventSubSubscriptionType.Channelchatnotification,
                12 => EventSubSubscriptionType.ChannelchatSettingsupdate,
                13 => EventSubSubscriptionType.ChannelchatuserMessageHold,
                14 => EventSubSubscriptionType.ChannelchatuserMessageUpdate,
                15 => EventSubSubscriptionType.Channelsubscribe,
                16 => EventSubSubscriptionType.Channelsubscriptionend,
                17 => EventSubSubscriptionType.Channelsubscriptiongift,
                18 => EventSubSubscriptionType.Channelsubscriptionmessage,
                19 => EventSubSubscriptionType.Channelcheer,
                20 => EventSubSubscriptionType.Channelraid,
                21 => EventSubSubscriptionType.Channelban,
                22 => EventSubSubscriptionType.Channelunban,
                23 => EventSubSubscriptionType.ChannelunbanRequestcreate,
                24 => EventSubSubscriptionType.ChannelunbanRequestresolve,
                25 => EventSubSubscriptionType.Channelmoderate,
                26 => EventSubSubscriptionType.Channelmoderatoradd,
                27 => EventSubSubscriptionType.Channelmoderatorremove,
                28 => EventSubSubscriptionType.ChannelguestStarSessionbegin,
                29 => EventSubSubscriptionType.ChannelguestStarSessionend,
                30 => EventSubSubscriptionType.ChannelguestStarGuestupdate,
                31 => EventSubSubscriptionType.ChannelguestStarSettingsupdate,
                32 => EventSubSubscriptionType.ChannelchannelPointsAutomaticRewardadd,
                33 => EventSubSubscriptionType.ChannelchannelPointsCustomRewardadd,
                34 => EventSubSubscriptionType.ChannelchannelPointsCustomRewardupdate,
                35 => EventSubSubscriptionType.ChannelchannelPointsCustomRewardremove,
                36 => EventSubSubscriptionType.ChannelchannelPointsCustomRewardRedemptionadd,
                37 => EventSubSubscriptionType.ChannelchannelPointsCustomRewardRedemptionupdate,
                38 => EventSubSubscriptionType.Channelpollbegin,
                39 => EventSubSubscriptionType.Channelpollprogress,
                40 => EventSubSubscriptionType.Channelpollend,
                41 => EventSubSubscriptionType.Channelpredictionbegin,
                42 => EventSubSubscriptionType.Channelpredictionprogress,
                43 => EventSubSubscriptionType.Channelpredictionlock,
                44 => EventSubSubscriptionType.Channelpredictionend,
                45 => EventSubSubscriptionType.Channelvipadd,
                46 => EventSubSubscriptionType.Channelvipremove,
                47 => EventSubSubscriptionType.ChannelcharityCampaigndonate,
                48 => EventSubSubscriptionType.ChannelcharityCampaignstart,
                49 => EventSubSubscriptionType.ChannelcharityCampaignprogress,
                50 => EventSubSubscriptionType.ChannelcharityCampaignstop,
                51 => EventSubSubscriptionType.Conduitsharddisabled,
                52 => EventSubSubscriptionType.Dropentitlementgrant,
                53 => EventSubSubscriptionType.ExtensionbitsTransactioncreate,
                54 => EventSubSubscriptionType.Channelgoalbegin,
                55 => EventSubSubscriptionType.Channelgoalprogress,
                56 => EventSubSubscriptionType.Channelgoalend,
                57 => EventSubSubscriptionType.ChannelhypeTrainbegin,
                58 => EventSubSubscriptionType.ChannelhypeTrainprogress,
                59 => EventSubSubscriptionType.ChannelhypeTrainend,
                60 => EventSubSubscriptionType.ChannelshieldModebegin,
                61 => EventSubSubscriptionType.ChannelshieldModeend,
                62 => EventSubSubscriptionType.Channelshoutoutcreate,
                63 => EventSubSubscriptionType.Channelshoutoutreceive,
                64 => EventSubSubscriptionType.Streamonline,
                65 => EventSubSubscriptionType.Streamoffline,
                66 => EventSubSubscriptionType.Userauthorizationgrant,
                67 => EventSubSubscriptionType.Userauthorizationrevoke,
                68 => EventSubSubscriptionType.Userupdate,
                69 => EventSubSubscriptionType.Userwhispermessage,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}