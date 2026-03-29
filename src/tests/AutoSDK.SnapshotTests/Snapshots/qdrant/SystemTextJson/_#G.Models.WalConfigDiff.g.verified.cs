//HintName: G.Models.WalConfigDiff.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalConfigDiff
    {
        /// <summary>
        /// Size of a single WAL segment in MB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wal_capacity_mb")]
        public int? WalCapacityMb { get; set; }

        /// <summary>
        /// Number of WAL segments to create ahead of actually used ones
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wal_segments_ahead")]
        public int? WalSegmentsAhead { get; set; }

        /// <summary>
        /// Number of closed WAL segments to retain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wal_retain_closed")]
        public int? WalRetainClosed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalConfigDiff" /> class.
        /// </summary>
        /// <param name="walCapacityMb">
        /// Size of a single WAL segment in MB
        /// </param>
        /// <param name="walSegmentsAhead">
        /// Number of WAL segments to create ahead of actually used ones
        /// </param>
        /// <param name="walRetainClosed">
        /// Number of closed WAL segments to retain
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalConfigDiff(
            int? walCapacityMb,
            int? walSegmentsAhead,
            int? walRetainClosed)
        {
            this.WalCapacityMb = walCapacityMb;
            this.WalSegmentsAhead = walSegmentsAhead;
            this.WalRetainClosed = walRetainClosed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalConfigDiff" /> class.
        /// </summary>
        public WalConfigDiff()
        {
        }
    }
}