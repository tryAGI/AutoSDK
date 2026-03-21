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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListenV1ResultsTypeJsonConverter))]
        public global::G.ListenV1ResultsType Type { get; set; }

        /// <summary>
        /// The index of the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> ChannelIndex { get; set; }

        /// <summary>
        /// Duration of audio segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Start time of audio segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Whether this is a final result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Channel alternatives.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ListenV1ResultsChannel Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1Results" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="channelIndex">
        /// The index of the channel.
        /// </param>
        /// <param name="duration">
        /// Duration of audio segment in seconds.
        /// </param>
        /// <param name="start">
        /// Start time of audio segment in seconds.
        /// </param>
        /// <param name="isFinal">
        /// Whether this is a final result.
        /// </param>
        /// <param name="channel">
        /// Channel alternatives.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1Results(
            global::System.Collections.Generic.IList<double> channelIndex,
            double duration,
            double start,
            global::G.ListenV1ResultsChannel channel,
            global::G.ListenV1ResultsType type,
            bool? isFinal)
        {
            this.ChannelIndex = channelIndex ?? throw new global::System.ArgumentNullException(nameof(channelIndex));
            this.Duration = duration;
            this.Start = start;
            this.Channel = channel ?? throw new global::System.ArgumentNullException(nameof(channel));
            this.Type = type;
            this.IsFinal = isFinal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1Results" /> class.
        /// </summary>
        public ListenV1Results()
        {
        }
    }
}