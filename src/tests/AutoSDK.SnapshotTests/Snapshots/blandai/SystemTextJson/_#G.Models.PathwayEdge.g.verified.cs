//HintName: G.Models.PathwayEdge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PathwayEdge
    {
        /// <summary>
        /// Source node ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Target node ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.PathwayEdgeData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PathwayEdge" /> class.
        /// </summary>
        /// <param name="source">
        /// Source node ID
        /// </param>
        /// <param name="target">
        /// Target node ID
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PathwayEdge(
            string? source,
            string? target,
            global::G.PathwayEdgeData? data)
        {
            this.Source = source;
            this.Target = target;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PathwayEdge" /> class.
        /// </summary>
        public PathwayEdge()
        {
        }
    }
}