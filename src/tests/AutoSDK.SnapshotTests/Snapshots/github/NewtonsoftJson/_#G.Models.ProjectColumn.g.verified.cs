//HintName: G.Models.ProjectColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project columns contain cards of work.
    /// </summary>
    public sealed partial class ProjectColumn
    {
        /// <summary>
        /// Example: https://api.github.com/projects/columns/367
        /// </summary>
        /// <example>https://api.github.com/projects/columns/367</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/projects/120
        /// </summary>
        /// <example>https://api.github.com/projects/120</example>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/projects/columns/367/cards
        /// </summary>
        /// <example>https://api.github.com/projects/columns/367/cards</example>
        [global::Newtonsoft.Json.JsonProperty("cards_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CardsUrl { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the project column<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDEzOlByb2plY3RDb2x1bW4zNjc=
        /// </summary>
        /// <example>MDEzOlByb2plY3RDb2x1bW4zNjc=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Name of the project column<br/>
        /// Example: Remaining tasks
        /// </summary>
        /// <example>Remaining tasks</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectColumn" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/projects/columns/367
        /// </param>
        /// <param name="projectUrl">
        /// Example: https://api.github.com/projects/120
        /// </param>
        /// <param name="cardsUrl">
        /// Example: https://api.github.com/projects/columns/367/cards
        /// </param>
        /// <param name="id">
        /// The unique identifier of the project column<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEzOlByb2plY3RDb2x1bW4zNjc=
        /// </param>
        /// <param name="name">
        /// Name of the project column<br/>
        /// Example: Remaining tasks
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public ProjectColumn(
            string url,
            string projectUrl,
            string cardsUrl,
            int id,
            string nodeId,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.CardsUrl = cardsUrl ?? throw new global::System.ArgumentNullException(nameof(cardsUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectColumn" /> class.
        /// </summary>
        public ProjectColumn()
        {
        }
    }
}