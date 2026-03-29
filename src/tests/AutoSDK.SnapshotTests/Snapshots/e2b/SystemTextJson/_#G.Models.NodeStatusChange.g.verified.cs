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
        [global::System.Text.Json.Serialization.JsonPropertyName("clusterID")]
        public global::System.Guid? ClusterID { get; set; }

        /// <summary>
        /// Status of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NodeStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NodeStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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