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
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Target node ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public string? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.PathwayEdgeData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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