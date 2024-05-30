//HintName: G.Models.GetEventsubSubscriptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetEventsubSubscriptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automod.message.hold")]
        Automodmessagehold,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automod.message.update")]
        Automodmessageupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automod.settings.update")]
        Automodsettingsupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automod.terms.update")]
        Automodtermsupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.update")]
        Channelupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.follow")]
        Channelfollow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.ad_break.begin")]
        ChanneladBreakbegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.clear")]
        Channelchatclear,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.clear_user_messages")]
        ChannelchatclearUserMessages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.message")]
        Channelchatmessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.message_delete")]
        ChannelchatmessageDelete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.notification")]
        Channelchatnotification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat_settings.update")]
        ChannelchatSettingsupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.user_message_hold")]
        ChannelchatuserMessageHold,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.chat.user_message_update")]
        ChannelchatuserMessageUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.subscribe")]
        Channelsubscribe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.subscription.end")]
        Channelsubscriptionend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.subscription.gift")]
        Channelsubscriptiongift,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.subscription.message")]
        Channelsubscriptionmessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.cheer")]
        Channelcheer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.raid")]
        Channelraid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.ban")]
        Channelban,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.unban")]
        Channelunban,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.unban_request.create")]
        ChannelunbanRequestcreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.unban_request.resolve")]
        ChannelunbanRequestresolve,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.moderate")]
        Channelmoderate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.moderator.add")]
        Channelmoderatoradd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.moderator.remove")]
        Channelmoderatorremove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.guest_star_session.begin")]
        ChannelguestStarSessionbegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.guest_star_session.end")]
        ChannelguestStarSessionend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.guest_star_guest.update")]
        ChannelguestStarGuestupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.guest_star_settings.update")]
        ChannelguestStarSettingsupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_automatic_reward.add")]
        ChannelchannelPointsAutomaticRewardadd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward.add")]
        ChannelchannelPointsCustomRewardadd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward.update")]
        ChannelchannelPointsCustomRewardupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward.remove")]
        ChannelchannelPointsCustomRewardremove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward_redemption.add")]
        ChannelchannelPointsCustomRewardRedemptionadd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.channel_points_custom_reward_redemption.update")]
        ChannelchannelPointsCustomRewardRedemptionupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.poll.begin")]
        Channelpollbegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.poll.progress")]
        Channelpollprogress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.poll.end")]
        Channelpollend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.prediction.begin")]
        Channelpredictionbegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.prediction.progress")]
        Channelpredictionprogress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.prediction.lock")]
        Channelpredictionlock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.prediction.end")]
        Channelpredictionend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.vip.add")]
        Channelvipadd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.vip.remove")]
        Channelvipremove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.charity_campaign.donate")]
        ChannelcharityCampaigndonate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.charity_campaign.start")]
        ChannelcharityCampaignstart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.charity_campaign.progress")]
        ChannelcharityCampaignprogress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.charity_campaign.stop")]
        ChannelcharityCampaignstop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conduit.shard.disabled")]
        Conduitsharddisabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drop.entitlement.grant")]
        Dropentitlementgrant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extension.bits_transaction.create")]
        ExtensionbitsTransactioncreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.goal.begin")]
        Channelgoalbegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.goal.progress")]
        Channelgoalprogress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.goal.end")]
        Channelgoalend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.hype_train.begin")]
        ChannelhypeTrainbegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.hype_train.progress")]
        ChannelhypeTrainprogress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.hype_train.end")]
        ChannelhypeTrainend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.shield_mode.begin")]
        ChannelshieldModebegin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.shield_mode.end")]
        ChannelshieldModeend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.shoutout.create")]
        Channelshoutoutcreate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="channel.shoutout.receive")]
        Channelshoutoutreceive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream.online")]
        Streamonline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stream.offline")]
        Streamoffline,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.authorization.grant")]
        Userauthorizationgrant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.authorization.revoke")]
        Userauthorizationrevoke,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.update")]
        Userupdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user.whisper.message")]
        Userwhispermessage,
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEventsubSubscriptionsType ToEnum(string value)
        {
            return value switch
            {
                "automod.message.hold" => GetEventsubSubscriptionsType.Automodmessagehold,
                "automod.message.update" => GetEventsubSubscriptionsType.Automodmessageupdate,
                "automod.settings.update" => GetEventsubSubscriptionsType.Automodsettingsupdate,
                "automod.terms.update" => GetEventsubSubscriptionsType.Automodtermsupdate,
                "channel.update" => GetEventsubSubscriptionsType.Channelupdate,
                "channel.follow" => GetEventsubSubscriptionsType.Channelfollow,
                "channel.ad_break.begin" => GetEventsubSubscriptionsType.ChanneladBreakbegin,
                "channel.chat.clear" => GetEventsubSubscriptionsType.Channelchatclear,
                "channel.chat.clear_user_messages" => GetEventsubSubscriptionsType.ChannelchatclearUserMessages,
                "channel.chat.message" => GetEventsubSubscriptionsType.Channelchatmessage,
                "channel.chat.message_delete" => GetEventsubSubscriptionsType.ChannelchatmessageDelete,
                "channel.chat.notification" => GetEventsubSubscriptionsType.Channelchatnotification,
                "channel.chat_settings.update" => GetEventsubSubscriptionsType.ChannelchatSettingsupdate,
                "channel.chat.user_message_hold" => GetEventsubSubscriptionsType.ChannelchatuserMessageHold,
                "channel.chat.user_message_update" => GetEventsubSubscriptionsType.ChannelchatuserMessageUpdate,
                "channel.subscribe" => GetEventsubSubscriptionsType.Channelsubscribe,
                "channel.subscription.end" => GetEventsubSubscriptionsType.Channelsubscriptionend,
                "channel.subscription.gift" => GetEventsubSubscriptionsType.Channelsubscriptiongift,
                "channel.subscription.message" => GetEventsubSubscriptionsType.Channelsubscriptionmessage,
                "channel.cheer" => GetEventsubSubscriptionsType.Channelcheer,
                "channel.raid" => GetEventsubSubscriptionsType.Channelraid,
                "channel.ban" => GetEventsubSubscriptionsType.Channelban,
                "channel.unban" => GetEventsubSubscriptionsType.Channelunban,
                "channel.unban_request.create" => GetEventsubSubscriptionsType.ChannelunbanRequestcreate,
                "channel.unban_request.resolve" => GetEventsubSubscriptionsType.ChannelunbanRequestresolve,
                "channel.moderate" => GetEventsubSubscriptionsType.Channelmoderate,
                "channel.moderator.add" => GetEventsubSubscriptionsType.Channelmoderatoradd,
                "channel.moderator.remove" => GetEventsubSubscriptionsType.Channelmoderatorremove,
                "channel.guest_star_session.begin" => GetEventsubSubscriptionsType.ChannelguestStarSessionbegin,
                "channel.guest_star_session.end" => GetEventsubSubscriptionsType.ChannelguestStarSessionend,
                "channel.guest_star_guest.update" => GetEventsubSubscriptionsType.ChannelguestStarGuestupdate,
                "channel.guest_star_settings.update" => GetEventsubSubscriptionsType.ChannelguestStarSettingsupdate,
                "channel.channel_points_automatic_reward.add" => GetEventsubSubscriptionsType.ChannelchannelPointsAutomaticRewardadd,
                "channel.channel_points_custom_reward.add" => GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardadd,
                "channel.channel_points_custom_reward.update" => GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardupdate,
                "channel.channel_points_custom_reward.remove" => GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardremove,
                "channel.channel_points_custom_reward_redemption.add" => GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardRedemptionadd,
                "channel.channel_points_custom_reward_redemption.update" => GetEventsubSubscriptionsType.ChannelchannelPointsCustomRewardRedemptionupdate,
                "channel.poll.begin" => GetEventsubSubscriptionsType.Channelpollbegin,
                "channel.poll.progress" => GetEventsubSubscriptionsType.Channelpollprogress,
                "channel.poll.end" => GetEventsubSubscriptionsType.Channelpollend,
                "channel.prediction.begin" => GetEventsubSubscriptionsType.Channelpredictionbegin,
                "channel.prediction.progress" => GetEventsubSubscriptionsType.Channelpredictionprogress,
                "channel.prediction.lock" => GetEventsubSubscriptionsType.Channelpredictionlock,
                "channel.prediction.end" => GetEventsubSubscriptionsType.Channelpredictionend,
                "channel.vip.add" => GetEventsubSubscriptionsType.Channelvipadd,
                "channel.vip.remove" => GetEventsubSubscriptionsType.Channelvipremove,
                "channel.charity_campaign.donate" => GetEventsubSubscriptionsType.ChannelcharityCampaigndonate,
                "channel.charity_campaign.start" => GetEventsubSubscriptionsType.ChannelcharityCampaignstart,
                "channel.charity_campaign.progress" => GetEventsubSubscriptionsType.ChannelcharityCampaignprogress,
                "channel.charity_campaign.stop" => GetEventsubSubscriptionsType.ChannelcharityCampaignstop,
                "conduit.shard.disabled" => GetEventsubSubscriptionsType.Conduitsharddisabled,
                "drop.entitlement.grant" => GetEventsubSubscriptionsType.Dropentitlementgrant,
                "extension.bits_transaction.create" => GetEventsubSubscriptionsType.ExtensionbitsTransactioncreate,
                "channel.goal.begin" => GetEventsubSubscriptionsType.Channelgoalbegin,
                "channel.goal.progress" => GetEventsubSubscriptionsType.Channelgoalprogress,
                "channel.goal.end" => GetEventsubSubscriptionsType.Channelgoalend,
                "channel.hype_train.begin" => GetEventsubSubscriptionsType.ChannelhypeTrainbegin,
                "channel.hype_train.progress" => GetEventsubSubscriptionsType.ChannelhypeTrainprogress,
                "channel.hype_train.end" => GetEventsubSubscriptionsType.ChannelhypeTrainend,
                "channel.shield_mode.begin" => GetEventsubSubscriptionsType.ChannelshieldModebegin,
                "channel.shield_mode.end" => GetEventsubSubscriptionsType.ChannelshieldModeend,
                "channel.shoutout.create" => GetEventsubSubscriptionsType.Channelshoutoutcreate,
                "channel.shoutout.receive" => GetEventsubSubscriptionsType.Channelshoutoutreceive,
                "stream.online" => GetEventsubSubscriptionsType.Streamonline,
                "stream.offline" => GetEventsubSubscriptionsType.Streamoffline,
                "user.authorization.grant" => GetEventsubSubscriptionsType.Userauthorizationgrant,
                "user.authorization.revoke" => GetEventsubSubscriptionsType.Userauthorizationrevoke,
                "user.update" => GetEventsubSubscriptionsType.Userupdate,
                "user.whisper.message" => GetEventsubSubscriptionsType.Userwhispermessage,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}