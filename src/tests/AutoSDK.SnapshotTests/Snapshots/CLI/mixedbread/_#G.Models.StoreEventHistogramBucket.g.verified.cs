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
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BucketStart { get; set; }

        /// <summary>
        /// End time of the bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime BucketEnd { get; set; }

        /// <summary>
        /// Type of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StoreEventHistogramBucketTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StoreEventHistogramBucketType Type { get; set; }

        /// <summary>
        /// Number of events in the bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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