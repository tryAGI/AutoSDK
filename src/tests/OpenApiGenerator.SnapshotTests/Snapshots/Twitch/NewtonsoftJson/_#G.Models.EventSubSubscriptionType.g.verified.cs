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
}