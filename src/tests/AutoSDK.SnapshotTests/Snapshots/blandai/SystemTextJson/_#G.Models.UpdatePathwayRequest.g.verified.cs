//HintName: G.Models.UpdatePathwayRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePathwayRequest
    {
        /// <summary>
        /// Name of the pathway
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the pathway
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Array of node objects in the conversation flow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::G.PathwayNode>? Nodes { get; set; }

        /// <summary>
        /// Array of edge objects connecting nodes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::G.PathwayEdge>? Edges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePathwayRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the pathway
        /// </param>
        /// <param name="description">
        /// Description of the pathway
        /// </param>
        /// <param name="nodes">
        /// Array of node objects in the conversation flow
        /// </param>
        /// <param name="edges">
        /// Array of edge objects connecting nodes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePathwayRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::G.PathwayNode>? nodes,
            global::System.Collections.Generic.IList<global::G.PathwayEdge>? edges)
        {
            this.Name = name;
            this.Description = description;
            this.Nodes = nodes;
            this.Edges = edges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePathwayRequest" /> class.
        /// </summary>
        public UpdatePathwayRequest()
        {
        }
    }
}