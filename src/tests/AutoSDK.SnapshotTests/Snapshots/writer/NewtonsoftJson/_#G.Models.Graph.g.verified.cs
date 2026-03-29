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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The timestamp when the Knowledge Graph was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the Knowledge Graph.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of the Knowledge Graph.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GraphFileStatus FileStatus { get; set; } = default!;

        /// <summary>
        /// The type of Knowledge Graph:<br/>
        /// - `manual`: files are uploaded via UI or API<br/>
        /// - `connector`: files are uploaded via a data connector such as Google Drive or Confluence<br/>
        /// - `web`: URLs are connected to the Knowledge Graph
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GraphType Type { get; set; } = default!;

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