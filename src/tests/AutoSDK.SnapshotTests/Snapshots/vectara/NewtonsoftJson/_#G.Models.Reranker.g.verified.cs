//HintName: G.Models.Reranker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reranker can be used in query or chat endpoints to reorder the search results.
    /// </summary>
    public sealed partial class Reranker
    {
        /// <summary>
        /// The ID of the reranker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the reranker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the reranker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the reranker is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reranker" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the reranker.
        /// </param>
        /// <param name="name">
        /// The name of the reranker.
        /// </param>
        /// <param name="description">
        /// The description of the reranker.
        /// </param>
        /// <param name="enabled">
        /// Whether the reranker is enabled.
        /// </param>
        public Reranker(
            string? id,
            string? name,
            string? description,
            bool? enabled)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reranker" /> class.
        /// </summary>
        public Reranker()
        {
        }
    }
}