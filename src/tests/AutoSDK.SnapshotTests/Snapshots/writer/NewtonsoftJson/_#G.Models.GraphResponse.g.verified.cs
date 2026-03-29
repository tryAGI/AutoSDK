//HintName: G.Models.GraphResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphResponse
    {
        /// <summary>
        /// A unique identifier of the Knowledge Graph.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The timestamp when the Knowledge Graph was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the Knowledge Graph (max 255 characters).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of the Knowledge Graph (max 255 characters).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An array of web connector URLs associated with this Knowledge Graph.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls")]
        public global::System.Collections.Generic.IList<global::G.WebConnectorUrl>? Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier of the Knowledge Graph.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the Knowledge Graph was created.
        /// </param>
        /// <param name="name">
        /// The name of the Knowledge Graph (max 255 characters).
        /// </param>
        /// <param name="description">
        /// A description of the Knowledge Graph (max 255 characters).
        /// </param>
        /// <param name="urls">
        /// An array of web connector URLs associated with this Knowledge Graph.
        /// </param>
        public GraphResponse(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string name,
            string? description,
            global::System.Collections.Generic.IList<global::G.WebConnectorUrl>? urls)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphResponse" /> class.
        /// </summary>
        public GraphResponse()
        {
        }
    }
}