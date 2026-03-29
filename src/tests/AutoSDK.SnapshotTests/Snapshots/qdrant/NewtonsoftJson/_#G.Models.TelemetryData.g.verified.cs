//HintName: G.Models.TelemetryData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelemetryData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app")]
        public global::G.AppBuildTelemetry? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collections", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CollectionsTelemetry Collections { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cluster")]
        public global::G.ClusterTelemetry? Cluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests")]
        public global::G.RequestsTelemetry? Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory")]
        public global::G.MemoryTelemetry? Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hardware")]
        public global::G.HardwareTelemetry? Hardware { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collections"></param>
        /// <param name="app"></param>
        /// <param name="cluster"></param>
        /// <param name="requests"></param>
        /// <param name="memory"></param>
        /// <param name="hardware"></param>
        public TelemetryData(
            string id,
            global::G.CollectionsTelemetry collections,
            global::G.AppBuildTelemetry? app,
            global::G.ClusterTelemetry? cluster,
            global::G.RequestsTelemetry? requests,
            global::G.MemoryTelemetry? memory,
            global::G.HardwareTelemetry? hardware)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.App = app;
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
            this.Cluster = cluster;
            this.Requests = requests;
            this.Memory = memory;
            this.Hardware = hardware;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryData" /> class.
        /// </summary>
        public TelemetryData()
        {
        }
    }
}