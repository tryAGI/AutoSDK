//HintName: G.Models.NodeStatusChange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeStatusChange
    {
        /// <summary>
        /// Identifier of the cluster
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clusterID")]
        public global::System.Guid? ClusterID { get; set; }

        /// <summary>
        /// Status of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NodeStatusJsonConverter))]
        public global::G.NodeStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusChange" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the node
        /// </param>
        /// <param name="clusterID">
        /// Identifier of the cluster
        /// </param>
        public NodeStatusChange(
            global::G.NodeStatus status,
            global::System.Guid? clusterID)
        {
            this.ClusterID = clusterID;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusChange" /> class.
        /// </summary>
        public NodeStatusChange()
        {
        }
    }
}