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

    public static class CreateEventSubSubscriptionBodyTypeExtensions
    {
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
        public static CreateEventSubSubscriptionBodyType ToEnum(int value)
        {
            return value switch
            {
                0 => CreateEventSubSubscriptionBodyType.Automodmessagehold,
                1 => CreateEventSubSubscriptionBodyType.Automodmessageupdate,
                2 => CreateEventSubSubscriptionBodyType.Automodsettingsupdate,
                3 => CreateEventSubSubscriptionBodyType.Automodtermsupdate,
                4 => CreateEventSubSubscriptionBodyType.Channelupdate,
                5 => CreateEventSubSubscriptionBodyType.Channelfollow,
                6 => CreateEventSubSubscriptionBodyType.ChanneladBreakbegin,
                7 => CreateEventSubSubscriptionBodyType.Channelchatclear,
                8 => CreateEventSubSubscriptionBodyType.ChannelchatclearUserMessages,
                9 => CreateEventSubSubscriptionBodyType.Channelchatmessage,
                10 => CreateEventSubSubscriptionBodyType.ChannelchatmessageDelete,
                11 => CreateEventSubSubscriptionBodyType.Channelchatnotification,
                12 => CreateEventSubSubscriptionBodyType.ChannelchatSettingsupdate,
                13 => CreateEventSubSubscriptionBodyType.ChannelchatuserMessageHold,
                14 => CreateEventSubSubscriptionBodyType.ChannelchatuserMessageUpdate,
                15 => CreateEventSubSubscriptionBodyType.Channelsubscribe,
                16 => CreateEventSubSubscriptionBodyType.Channelsubscriptionend,
                17 => CreateEventSubSubscriptionBodyType.Channelsubscriptiongift,
                18 => CreateEventSubSubscriptionBodyType.Channelsubscriptionmessage,
                19 => CreateEventSubSubscriptionBodyType.Channelcheer,
                20 => CreateEventSubSubscriptionBodyType.Channelraid,
                21 => CreateEventSubSubscriptionBodyType.Channelban,
                22 => CreateEventSubSubscriptionBodyType.Channelunban,
                23 => CreateEventSubSubscriptionBodyType.ChannelunbanRequestcreate,
                24 => CreateEventSubSubscriptionBodyType.ChannelunbanRequestresolve,
                25 => CreateEventSubSubscriptionBodyType.Channelmoderate,
                26 => CreateEventSubSubscriptionBodyType.Channelmoderatoradd,
                27 => CreateEventSubSubscriptionBodyType.Channelmoderatorremove,
                28 => CreateEventSubSubscriptionBodyType.ChannelguestStarSessionbegin,
                29 => CreateEventSubSubscriptionBodyType.ChannelguestStarSessionend,
                30 => CreateEventSubSubscriptionBodyType.ChannelguestStarGuestupdate,
                31 => CreateEventSubSubscriptionBodyType.ChannelguestStarSettingsupdate,
                32 => CreateEventSubSubscriptionBodyType.ChannelchannelPointsAutomaticRewardadd,
                33 => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardadd,
                34 => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardupdate,
                35 => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardremove,
                36 => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardRedemptionadd,
                37 => CreateEventSubSubscriptionBodyType.ChannelchannelPointsCustomRewardRedemptionupdate,
                38 => CreateEventSubSubscriptionBodyType.Channelpollbegin,
                39 => CreateEventSubSubscriptionBodyType.Channelpollprogress,
                40 => CreateEventSubSubscriptionBodyType.Channelpollend,
                41 => CreateEventSubSubscriptionBodyType.Channelpredictionbegin,
                42 => CreateEventSubSubscriptionBodyType.Channelpredictionprogress,
                43 => CreateEventSubSubscriptionBodyType.Channelpredictionlock,
                44 => CreateEventSubSubscriptionBodyType.Channelpredictionend,
                45 => CreateEventSubSubscriptionBodyType.Channelvipadd,
                46 => CreateEventSubSubscriptionBodyType.Channelvipremove,
                47 => CreateEventSubSubscriptionBodyType.ChannelcharityCampaigndonate,
                48 => CreateEventSubSubscriptionBodyType.ChannelcharityCampaignstart,
                49 => CreateEventSubSubscriptionBodyType.ChannelcharityCampaignprogress,
                50 => CreateEventSubSubscriptionBodyType.ChannelcharityCampaignstop,
                51 => CreateEventSubSubscriptionBodyType.Conduitsharddisabled,
                52 => CreateEventSubSubscriptionBodyType.Dropentitlementgrant,
                53 => CreateEventSubSubscriptionBodyType.ExtensionbitsTransactioncreate,
                54 => CreateEventSubSubscriptionBodyType.Channelgoalbegin,
                55 => CreateEventSubSubscriptionBodyType.Channelgoalprogress,
                56 => CreateEventSubSubscriptionBodyType.Channelgoalend,
                57 => CreateEventSubSubscriptionBodyType.ChannelhypeTrainbegin,
                58 => CreateEventSubSubscriptionBodyType.ChannelhypeTrainprogress,
                59 => CreateEventSubSubscriptionBodyType.ChannelhypeTrainend,
                60 => CreateEventSubSubscriptionBodyType.ChannelshieldModebegin,
                61 => CreateEventSubSubscriptionBodyType.ChannelshieldModeend,
                62 => CreateEventSubSubscriptionBodyType.Channelshoutoutcreate,
                63 => CreateEventSubSubscriptionBodyType.Channelshoutoutreceive,
                64 => CreateEventSubSubscriptionBodyType.Streamonline,
                65 => CreateEventSubSubscriptionBodyType.Streamoffline,
                66 => CreateEventSubSubscriptionBodyType.Userauthorizationgrant,
                67 => CreateEventSubSubscriptionBodyType.Userauthorizationrevoke,
                68 => CreateEventSubSubscriptionBodyType.Userupdate,
                69 => CreateEventSubSubscriptionBodyType.Userwhispermessage,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}