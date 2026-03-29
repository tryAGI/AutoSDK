//HintName: G.Models.GraphData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GraphData.
    /// </summary>
    public sealed partial class GraphData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cells")]
        public global::System.Collections.Generic.IList<global::G.GraphCell>? Cells { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<global::G.GraphLink>? Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphData" /> class.
        /// </summary>
        /// <param name="cells"></param>
        /// <param name="links"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphData(
            global::System.Collections.Generic.IList<global::G.GraphCell>? cells,
            global::System.Collections.Generic.IList<global::G.GraphLink>? links)
        {
            this.Cells = cells;
            this.Links = links;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphData" /> class.
        /// </summary>
        public GraphData()
        {
        }
    }
}