//HintName: G.Models.CreateEventSubSubscriptionBodyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of subscription to create. For a list of subscriptions that you can create, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types). Set this field to the value in the **Name** column of the Subscription Types table.
    /// </summary>
    public abstract class CreateEventSubSubscriptionBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Automodmessagehold = "automod.message.hold";
        /// <summary>
        /// 
        /// </summary>
        public const string Automodmessageupdate = "automod.message.update";
        /// <summary>
        /// 
        /// </summary>
        public const string Automodsettingsupdate = "automod.settings.update";
        /// <summary>
        /// 
        /// </summary>
        public const string Automodtermsupdate = "automod.terms.update";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelupdate = "channel.update";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelfollow = "channel.follow";
        /// <summary>
        /// 
        /// </summary>
        public const string ChanneladBreakbegin = "channel.ad_break.begin";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelchatclear = "channel.chat.clear";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchatclearUserMessages = "channel.chat.clear_user_messages";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelchatmessage = "channel.chat.message";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchatmessageDelete = "channel.chat.message_delete";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelchatnotification = "channel.chat.notification";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchatSettingsupdate = "channel.chat_settings.update";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchatuserMessageHold = "channel.chat.user_message_hold";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchatuserMessageUpdate = "channel.chat.user_message_update";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelsubscribe = "channel.subscribe";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelsubscriptionend = "channel.subscription.end";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelsubscriptiongift = "channel.subscription.gift";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelsubscriptionmessage = "channel.subscription.message";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelcheer = "channel.cheer";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelraid = "channel.raid";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelban = "channel.ban";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelunban = "channel.unban";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelunbanRequestcreate = "channel.unban_request.create";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelunbanRequestresolve = "channel.unban_request.resolve";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelmoderate = "channel.moderate";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelmoderatoradd = "channel.moderator.add";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelmoderatorremove = "channel.moderator.remove";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelguestStarSessionbegin = "channel.guest_star_session.begin";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelguestStarSessionend = "channel.guest_star_session.end";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelguestStarGuestupdate = "channel.guest_star_guest.update";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelguestStarSettingsupdate = "channel.guest_star_settings.update";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchannelPointsAutomaticRewardadd = "channel.channel_points_automatic_reward.add";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchannelPointsCustomRewardadd = "channel.channel_points_custom_reward.add";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchannelPointsCustomRewardupdate = "channel.channel_points_custom_reward.update";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchannelPointsCustomRewardremove = "channel.channel_points_custom_reward.remove";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchannelPointsCustomRewardRedemptionadd = "channel.channel_points_custom_reward_redemption.add";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelchannelPointsCustomRewardRedemptionupdate = "channel.channel_points_custom_reward_redemption.update";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelpollbegin = "channel.poll.begin";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelpollprogress = "channel.poll.progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelpollend = "channel.poll.end";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelpredictionbegin = "channel.prediction.begin";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelpredictionprogress = "channel.prediction.progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelpredictionlock = "channel.prediction.lock";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelpredictionend = "channel.prediction.end";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelvipadd = "channel.vip.add";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelvipremove = "channel.vip.remove";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelcharityCampaigndonate = "channel.charity_campaign.donate";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelcharityCampaignstart = "channel.charity_campaign.start";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelcharityCampaignprogress = "channel.charity_campaign.progress";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelcharityCampaignstop = "channel.charity_campaign.stop";
        /// <summary>
        /// 
        /// </summary>
        public const string Conduitsharddisabled = "conduit.shard.disabled";
        /// <summary>
        /// 
        /// </summary>
        public const string Dropentitlementgrant = "drop.entitlement.grant";
        /// <summary>
        /// 
        /// </summary>
        public const string ExtensionbitsTransactioncreate = "extension.bits_transaction.create";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelgoalbegin = "channel.goal.begin";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelgoalprogress = "channel.goal.progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelgoalend = "channel.goal.end";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelhypeTrainbegin = "channel.hype_train.begin";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelhypeTrainprogress = "channel.hype_train.progress";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelhypeTrainend = "channel.hype_train.end";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelshieldModebegin = "channel.shield_mode.begin";
        /// <summary>
        /// 
        /// </summary>
        public const string ChannelshieldModeend = "channel.shield_mode.end";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelshoutoutcreate = "channel.shoutout.create";
        /// <summary>
        /// 
        /// </summary>
        public const string Channelshoutoutreceive = "channel.shoutout.receive";
        /// <summary>
        /// 
        /// </summary>
        public const string Streamonline = "stream.online";
        /// <summary>
        /// 
        /// </summary>
        public const string Streamoffline = "stream.offline";
        /// <summary>
        /// 
        /// </summary>
        public const string Userauthorizationgrant = "user.authorization.grant";
        /// <summary>
        /// 
        /// </summary>
        public const string Userauthorizationrevoke = "user.authorization.revoke";
        /// <summary>
        /// 
        /// </summary>
        public const string Userupdate = "user.update";
        /// <summary>
        /// 
        /// </summary>
        public const string Userwhispermessage = "user.whisper.message";
    }
}