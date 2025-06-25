﻿//HintName: G.Models.Poll.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Poll
    {
        /// <summary>
        /// An ID that identifies the poll.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An ID that identifies the broadcaster that created the poll.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The question that viewers are voting on. For example, _What game should I play next?_ The title may contain a maximum of 60 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// A list of choices that viewers can choose from. The list will contain a minimum of two choices and up to a maximum of five choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PollChoice> Choices { get; set; }

        /// <summary>
        /// Not used; will be set to **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bits_voting_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BitsVotingEnabled { get; set; }

        /// <summary>
        /// Not used; will be set to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bits_per_vote")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BitsPerVote { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_points_voting_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ChannelPointsVotingEnabled { get; set; }

        /// <summary>
        /// The number of points the viewer must spend to cast one additional vote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_points_per_vote")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChannelPointsPerVote { get; set; }

        /// <summary>
        /// The poll’s status. Valid values are:  <br/>
        ///   <br/>
        /// * ACTIVE — The poll is running.<br/>
        /// * COMPLETED — The poll ended on schedule (see the `duration` field).<br/>
        /// * TERMINATED — The poll was terminated before its scheduled end.<br/>
        /// * ARCHIVED — The poll has been archived and is no longer visible on the channel.<br/>
        /// * MODERATED — The poll was deleted.<br/>
        /// * INVALID — Something went wrong while determining the state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PollStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PollStatus Status { get; set; }

        /// <summary>
        /// The length of time (in seconds) that the poll will run for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the poll began.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the poll ended. If `status` is ACTIVE, this field is set to **null**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Poll" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the poll.
        /// </param>
        /// <param name="broadcasterId">
        /// An ID that identifies the broadcaster that created the poll.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="title">
        /// The question that viewers are voting on. For example, _What game should I play next?_ The title may contain a maximum of 60 characters.
        /// </param>
        /// <param name="choices">
        /// A list of choices that viewers can choose from. The list will contain a minimum of two choices and up to a maximum of five choices.
        /// </param>
        /// <param name="bitsVotingEnabled">
        /// Not used; will be set to **false**.
        /// </param>
        /// <param name="bitsPerVote">
        /// Not used; will be set to 0.
        /// </param>
        /// <param name="channelPointsVotingEnabled">
        /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).
        /// </param>
        /// <param name="channelPointsPerVote">
        /// The number of points the viewer must spend to cast one additional vote.
        /// </param>
        /// <param name="status">
        /// The poll’s status. Valid values are:  <br/>
        ///   <br/>
        /// * ACTIVE — The poll is running.<br/>
        /// * COMPLETED — The poll ended on schedule (see the `duration` field).<br/>
        /// * TERMINATED — The poll was terminated before its scheduled end.<br/>
        /// * ARCHIVED — The poll has been archived and is no longer visible on the channel.<br/>
        /// * MODERATED — The poll was deleted.<br/>
        /// * INVALID — Something went wrong while determining the state.
        /// </param>
        /// <param name="duration">
        /// The length of time (in seconds) that the poll will run for.
        /// </param>
        /// <param name="startedAt">
        /// The UTC date and time (in RFC3339 format) of when the poll began.
        /// </param>
        /// <param name="endedAt">
        /// The UTC date and time (in RFC3339 format) of when the poll ended. If `status` is ACTIVE, this field is set to **null**.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Poll(
            string id,
            string broadcasterId,
            string broadcasterName,
            string broadcasterLogin,
            string title,
            global::System.Collections.Generic.IList<global::G.PollChoice> choices,
            bool bitsVotingEnabled,
            int bitsPerVote,
            bool channelPointsVotingEnabled,
            int channelPointsPerVote,
            global::G.PollStatus status,
            int duration,
            global::System.DateTime startedAt,
            global::System.DateTime? endedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.BitsVotingEnabled = bitsVotingEnabled;
            this.BitsPerVote = bitsPerVote;
            this.ChannelPointsVotingEnabled = channelPointsVotingEnabled;
            this.ChannelPointsPerVote = channelPointsPerVote;
            this.Status = status;
            this.Duration = duration;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Poll" /> class.
        /// </summary>
        public Poll()
        {
        }
    }
}