﻿//HintName: G.Models.CreatePollBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePollBody
    {
        /// <summary>
        /// The ID of the broadcaster that’s running the poll. This ID must match the user ID in the user access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The question that viewers will vote on. For example, _What game should I play next?_ The question may contain a maximum of 60 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A list of choices that viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 5 choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreatePollBodyChoice> Choices { get; set; } = default!;

        /// <summary>
        /// The length of time (in seconds) that the poll will run for. The minimum is 15 seconds and the maximum is 1800 seconds (30 minutes).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. If **true**, the viewer may cast more than one vote but each additional vote costs the number of Channel Points specified in `channel_points_per_vote`. The default is **false** (viewers may cast only one vote). For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_voting_enabled")]
        public bool? ChannelPointsVotingEnabled { get; set; }

        /// <summary>
        /// The number of points that the viewer must spend to cast one additional vote. The minimum is 1 and the maximum is 1000000\. Set only if `ChannelPointsVotingEnabled` is **true**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_per_vote")]
        public int? ChannelPointsPerVote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePollBody" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that’s running the poll. This ID must match the user ID in the user access token.
        /// </param>
        /// <param name="title">
        /// The question that viewers will vote on. For example, _What game should I play next?_ The question may contain a maximum of 60 characters.
        /// </param>
        /// <param name="choices">
        /// A list of choices that viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 5 choices.
        /// </param>
        /// <param name="duration">
        /// The length of time (in seconds) that the poll will run for. The minimum is 15 seconds and the maximum is 1800 seconds (30 minutes).
        /// </param>
        /// <param name="channelPointsVotingEnabled">
        /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. If **true**, the viewer may cast more than one vote but each additional vote costs the number of Channel Points specified in `channel_points_per_vote`. The default is **false** (viewers may cast only one vote). For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).
        /// </param>
        /// <param name="channelPointsPerVote">
        /// The number of points that the viewer must spend to cast one additional vote. The minimum is 1 and the maximum is 1000000\. Set only if `ChannelPointsVotingEnabled` is **true**.
        /// </param>
        public CreatePollBody(
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<global::G.CreatePollBodyChoice> choices,
            int duration,
            bool? channelPointsVotingEnabled,
            int? channelPointsPerVote)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Duration = duration;
            this.ChannelPointsVotingEnabled = channelPointsVotingEnabled;
            this.ChannelPointsPerVote = channelPointsPerVote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePollBody" /> class.
        /// </summary>
        public CreatePollBody()
        {
        }
    }
}