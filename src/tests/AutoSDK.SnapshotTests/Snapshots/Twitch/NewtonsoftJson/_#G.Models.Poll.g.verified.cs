//HintName: G.Models.Poll.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the broadcaster that created the poll.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The question that viewers are voting on. For example, _What game should I play next?_ The title may contain a maximum of 60 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A list of choices that viewers can choose from. The list will contain a minimum of two choices and up to a maximum of five choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PollChoice> Choices { get; set; } = default!;

        /// <summary>
        /// Not used; will be set to **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bits_voting_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool BitsVotingEnabled { get; set; } = default!;

        /// <summary>
        /// Not used; will be set to 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bits_per_vote", Required = global::Newtonsoft.Json.Required.Always)]
        public int BitsPerVote { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_voting_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ChannelPointsVotingEnabled { get; set; } = default!;

        /// <summary>
        /// The number of points the viewer must spend to cast one additional vote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_per_vote", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChannelPointsPerVote { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PollStatus Status { get; set; } = default!;

        /// <summary>
        /// The length of time (in seconds) that the poll will run for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the poll began.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the poll ended. If `status` is ACTIVE, this field is set to **null**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? EndedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Poll? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Poll>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Poll?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Poll?>(serializer.Deserialize<global::G.Poll>(jsonReader));
        }

    }
}