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
        [global::Newtonsoft.Json.JsonProperty("collections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.DistributedCollectionTelemetry> Collections { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cluster")]
        public global::G.DistributedClusterTelemetry? Cluster { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedTelemetryData" /> class.
        /// </summary>
        /// <param name="collections"></param>
        /// <param name="cluster"></param>
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