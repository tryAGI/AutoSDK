//HintName: G.Models.DistributedTelemetryData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistributedTelemetryData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.DistributedCollectionTelemetry> Collections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public global::G.DistributedClusterTelemetry? Cluster { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedTelemetryData" /> class.
        /// </summary>
        /// <param name="collections"></param>
        /// <param name="cluster"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistributedTelemetryData(
            global::System.Collections.Generic.Dictionary<string, global::G.DistributedCollectionTelemetry> collections,
            global::G.DistributedClusterTelemetry? cluster)
        {
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
            this.Cluster = cluster;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedTelemetryData" /> class.
        /// </summary>
        public DistributedTelemetryData()
        {
        }
    }
}