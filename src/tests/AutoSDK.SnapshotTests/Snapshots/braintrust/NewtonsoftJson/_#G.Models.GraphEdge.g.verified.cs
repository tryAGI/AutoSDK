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
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GraphEdgeSource Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GraphEdgeTarget Target { get; set; } = default!;

        /// <summary>
        /// The purpose of the edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GraphEdgePurposeJsonConverter))]
        public global::G.GraphEdgePurpose Purpose { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphEdge" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="purpose">
        /// The purpose of the edge
        /// </param>
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