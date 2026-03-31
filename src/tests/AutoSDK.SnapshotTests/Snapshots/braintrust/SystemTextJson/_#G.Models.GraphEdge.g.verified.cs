//HintName: G.Models.GraphEdge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphEdge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraphEdgeSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraphEdgeTarget Target { get; set; }

        /// <summary>
        /// The purpose of the edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraphEdgePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraphEdgePurpose Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphEdge" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="purpose">
        /// The purpose of the edge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphEdge(
            global::G.GraphEdgeSource source,
            global::G.GraphEdgeTarget target,
            global::G.GraphEdgePurpose purpose)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphEdge" /> class.
        /// </summary>
        public GraphEdge()
        {
        }
    }
}