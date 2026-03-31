//HintName: G.Models.StoreEventHistogramParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for getting a histogram of events in a store.
    /// </summary>
    public sealed partial class StoreEventHistogramParams
    {
        /// <summary>
        /// Start time of the histogram
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// End time of the histogram
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Number of seconds in each bucket<br/>
        /// Default Value: 7200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_seconds")]
        public int? BucketSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreEventHistogramParams" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start time of the histogram
        /// </param>
        /// <param name="endTime">
        /// End time of the histogram
        /// </param>
        /// <param name="bucketSeconds">
        /// Number of seconds in each bucket<br/>
        /// Default Value: 7200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreEventHistogramParams(
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? bucketSeconds)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.BucketSeconds = bucketSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreEventHistogramParams" /> class.
        /// </summary>
        public StoreEventHistogramParams()
        {
        }
    }
}