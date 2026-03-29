//HintName: G.Models.StoreEventHistogramBucket.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a histogram of events in a store.
    /// </summary>
    public sealed partial class StoreEventHistogramBucket
    {
        /// <summary>
        /// Start time of the bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket_start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime BucketStart { get; set; } = default!;

        /// <summary>
        /// End time of the bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket_end", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime BucketEnd { get; set; } = default!;

        /// <summary>
        /// Type of the event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StoreEventHistogramBucketType Type { get; set; } = default!;

        /// <summary>
        /// Number of events in the bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int EventCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreEventHistogramBucket" /> class.
        /// </summary>
        /// <param name="bucketStart">
        /// Start time of the bucket
        /// </param>
        /// <param name="bucketEnd">
        /// End time of the bucket
        /// </param>
        /// <param name="type">
        /// Type of the event
        /// </param>
        /// <param name="eventCount">
        /// Number of events in the bucket
        /// </param>
        public StoreEventHistogramBucket(
            global::System.DateTime bucketStart,
            global::System.DateTime bucketEnd,
            global::G.StoreEventHistogramBucketType type,
            int eventCount)
        {
            this.BucketStart = bucketStart;
            this.BucketEnd = bucketEnd;
            this.Type = type;
            this.EventCount = eventCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreEventHistogramBucket" /> class.
        /// </summary>
        public StoreEventHistogramBucket()
        {
        }
    }
}