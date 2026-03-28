//HintName: G.Models.ListenV1Results.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Transcription result from the server.
    /// </summary>
    public sealed partial class ListenV1Results
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ListenV1ResultsType Type { get; set; }

        /// <summary>
        /// The index of the channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_index", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> ChannelIndex { get; set; } = default!;

        /// <summary>
        /// Duration of audio segment in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// Start time of audio segment in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// Whether this is a final result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_final")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Channel alternatives.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListenV1ResultsChannel Channel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1Results" /> class.
        /// </summary>
        /// <param name="channelIndex">
        /// The index of the channel.
        /// </param>
        /// <param name="duration">
        /// Duration of audio segment in seconds.
        /// </param>
        /// <param name="start">
        /// Start time of audio segment in seconds.
        /// </param>
        /// <param name="channel">
        /// Channel alternatives.
        /// </param>
        /// <param name="type"></param>
        /// <param name="isFinal">
        /// Whether this is a final result.
        /// </param>
        public ListenV1Results(
            global::System.Collections.Generic.IList<double> channelIndex,
            double duration,
            double start,
            global::G.ListenV1ResultsChannel channel,
            global::G.ListenV1ResultsType type,
            bool? isFinal)
        {
            this.Type = type;
            this.ChannelIndex = channelIndex ?? throw new global::System.ArgumentNullException(nameof(channelIndex));
            this.Duration = duration;
            this.Start = start;
            this.IsFinal = isFinal;
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1Results" /> class.
        /// </summary>
        public ListenV1Results()
        {
        }
    }
}