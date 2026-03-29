//HintName: G.Models.Pathway.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Pathway
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes")]
        public global::System.Collections.Generic.IList<global::G.PathwayNode>? Nodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges")]
        public global::System.Collections.Generic.IList<global::G.PathwayEdge>? Edges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pathway" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
        public Pathway(
            string? id,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::G.PathwayNode>? nodes,
            global::System.Collections.Generic.IList<global::G.PathwayEdge>? edges)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Nodes = nodes;
            this.Edges = edges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pathway" /> class.
        /// </summary>
        public Pathway()
        {
        }
    }
}