//HintName: G.Models.WalConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalConfig
    {
        /// <summary>
        /// Size of a single WAL segment in MB
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wal_capacity_mb", Required = global::Newtonsoft.Json.Required.Always)]
        public long WalCapacityMb { get; set; } = default!;

        /// <summary>
        /// Number of WAL segments to create ahead of actually used ones
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wal_segments_ahead", Required = global::Newtonsoft.Json.Required.Always)]
        public long WalSegmentsAhead { get; set; } = default!;

        /// <summary>
        /// Number of closed WAL segments to keep<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wal_retain_closed")]
        public long? WalRetainClosed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalConfig" /> class.
        /// </summary>
        /// <param name="walCapacityMb">
        /// Size of a single WAL segment in MB
        /// </param>
        /// <param name="walSegmentsAhead">
        /// Number of WAL segments to create ahead of actually used ones
        /// </param>
        /// <param name="walRetainClosed">
        /// Number of closed WAL segments to keep<br/>
        /// Default Value: 1
        /// </param>
        public WalConfig(
            long walCapacityMb,
            long walSegmentsAhead,
            long? walRetainClosed)
        {
            this.WalCapacityMb = walCapacityMb;
            this.WalSegmentsAhead = walSegmentsAhead;
            this.WalRetainClosed = walRetainClosed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalConfig" /> class.
        /// </summary>
        public WalConfig()
        {
        }

    }
}