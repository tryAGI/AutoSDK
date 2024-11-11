//HintName: G.Models.NodePoolAutoscaling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class NodePoolAutoscaling
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CurrentNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePoolAutoscaling" /> class.
        /// </summary>
        /// <param name="minNodes"></param>
        /// <param name="maxNodes"></param>
        /// <param name="currentNodes"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public NodePoolAutoscaling(
            int minNodes,
            int maxNodes,
            int currentNodes)
        {
            this.MinNodes = minNodes;
            this.MaxNodes = maxNodes;
            this.CurrentNodes = currentNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodePoolAutoscaling" /> class.
        /// </summary>
        public NodePoolAutoscaling()
        {
        }
    }
}