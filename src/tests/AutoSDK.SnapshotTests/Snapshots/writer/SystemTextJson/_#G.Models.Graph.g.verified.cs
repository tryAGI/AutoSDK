//HintName: G.Models.Graph.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Graph
    {
        /// <summary>
        /// The unique identifier of the Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The timestamp when the Knowledge Graph was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The name of the Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraphFileStatus FileStatus { get; set; }

        /// <summary>
        /// The type of Knowledge Graph:<br/>
        /// - `manual`: files are uploaded via UI or API<br/>
        /// - `connector`: files are uploaded via a data connector such as Google Drive or Confluence<br/>
        /// - `web`: URLs are connected to the Knowledge Graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraphTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GraphType Type { get; set; }

        /// <summary>
        /// An array of web connector URLs associated with this Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<global::G.WebConnectorUrl>? Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the Knowledge Graph.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the Knowledge Graph was created.
        /// </param>
        /// <param name="name">
        /// The name of the Knowledge Graph.
        /// </param>
        /// <param name="fileStatus"></param>
        /// <param name="type">
        /// The type of Knowledge Graph:<br/>
        /// - `manual`: files are uploaded via UI or API<br/>
        /// - `connector`: files are uploaded via a data connector such as Google Drive or Confluence<br/>
        /// - `web`: URLs are connected to the Knowledge Graph
        /// </param>
        /// <param name="description">
        /// A description of the Knowledge Graph.
        /// </param>
        /// <param name="urls">
        /// An array of web connector URLs associated with this Knowledge Graph.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Graph(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string name,
            global::G.GraphFileStatus fileStatus,
            global::G.GraphType type,
            string? description,
            global::System.Collections.Generic.IList<global::G.WebConnectorUrl>? urls)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.FileStatus = fileStatus ?? throw new global::System.ArgumentNullException(nameof(fileStatus));
            this.Type = type;
            this.Urls = urls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph" /> class.
        /// </summary>
        public Graph()
        {
        }
    }
}