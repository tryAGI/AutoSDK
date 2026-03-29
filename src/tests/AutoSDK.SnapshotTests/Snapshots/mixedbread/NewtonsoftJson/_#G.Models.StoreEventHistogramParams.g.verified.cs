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
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// End time of the histogram
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Number of seconds in each bucket<br/>
        /// Default Value: 7200
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket_seconds")]
        public int? BucketSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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