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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/projects/120
        /// </summary>
        /// <example>https://api.github.com/projects/120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/projects/columns/367/cards
        /// </summary>
        /// <example>https://api.github.com/projects/columns/367/cards</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cards_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CardsUrl { get; set; }

        /// <summary>
        /// The unique identifier of the project column<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDEzOlByb2plY3RDb2x1bW4zNjc=
        /// </summary>
        /// <example>MDEzOlByb2plY3RDb2x1bW4zNjc=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Name of the project column<br/>
        /// Example: Remaining tasks
        /// </summary>
        /// <example>Remaining tasks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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