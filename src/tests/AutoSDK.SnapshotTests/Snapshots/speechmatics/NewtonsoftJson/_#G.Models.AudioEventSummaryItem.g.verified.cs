//HintName: G.Models.AudioEventSummaryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary statistics for this audio event type
    /// </summary>
    public sealed partial class AudioEventSummaryItem
    {
        /// <summary>
        /// Total duration (in seconds) of all audio events of this type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_duration")]
        public float? TotalDuration { get; set; }

        /// <summary>
        /// Number of events of this type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public double? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEventSummaryItem" /> class.
        /// </summary>
        /// <param name="totalDuration">
        /// Total duration (in seconds) of all audio events of this type
        /// </param>
        /// <param name="count">
        /// Number of events of this type
        /// </param>
        public AudioEventSummaryItem(
            float? totalDuration,
            double? count)
        {
            this.TotalDuration = totalDuration;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEventSummaryItem" /> class.
        /// </summary>
        public AudioEventSummaryItem()
        {
        }
    }
}