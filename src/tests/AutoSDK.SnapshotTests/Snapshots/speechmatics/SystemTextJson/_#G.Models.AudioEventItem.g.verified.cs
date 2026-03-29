//HintName: G.Models.AudioEventItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioEventItem
    {
        /// <summary>
        /// Kind of audio event. E.g. music
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Time (in seconds) at which the audio event starts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public float? StartTime { get; set; }

        /// <summary>
        /// Time (in seconds) at which the audio event ends
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public float? EndTime { get; set; }

        /// <summary>
        /// Prediction confidence associated with this event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public float? Confidence { get; set; }

        /// <summary>
        /// Input channel this event occurred on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEventItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Kind of audio event. E.g. music
        /// </param>
        /// <param name="startTime">
        /// Time (in seconds) at which the audio event starts
        /// </param>
        /// <param name="endTime">
        /// Time (in seconds) at which the audio event ends
        /// </param>
        /// <param name="confidence">
        /// Prediction confidence associated with this event
        /// </param>
        /// <param name="channel">
        /// Input channel this event occurred on
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEventItem(
            string? type,
            float? startTime,
            float? endTime,
            float? confidence,
            string? channel)
        {
            this.Type = type;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Confidence = confidence;
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEventItem" /> class.
        /// </summary>
        public AudioEventItem()
        {
        }
    }
}