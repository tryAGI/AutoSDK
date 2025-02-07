//HintName: G.Models.NodesStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of all of the Weaviate nodes
    /// </summary>
    public sealed partial class NodesStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::G.NodeStatus>? Nodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodesStatusResponse" /> class.
        /// </summary>
        /// <param name="nodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodesStatusResponse(
            global::System.Collections.Generic.IList<global::G.NodeStatus>? nodes)
        {
            this.Nodes = nodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodesStatusResponse" /> class.
        /// </summary>
        public NodesStatusResponse()
        {
        }
    }
}