//HintName: G.Models.GraphEdgeSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphEdgeSource
    {
        /// <summary>
        /// The id of the node in the graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Node { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Variable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphEdgeSource" /> class.
        /// </summary>
        /// <param name="node">
        /// The id of the node in the graph
        /// </param>
        /// <param name="variable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphEdgeSource(
            string node,
            string variable)
        {
            this.Node = node ?? throw new global::System.ArgumentNullException(nameof(node));
            this.Variable = variable ?? throw new global::System.ArgumentNullException(nameof(variable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphEdgeSource" /> class.
        /// </summary>
        public GraphEdgeSource()
        {
        }
    }
}