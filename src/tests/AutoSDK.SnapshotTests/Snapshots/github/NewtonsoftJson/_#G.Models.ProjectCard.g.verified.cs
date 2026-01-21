//HintName: G.Models.ProjectCard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project cards represent a scope of work.
    /// </summary>
    public sealed partial class ProjectCard
    {
        /// <summary>
        /// Example: https://api.github.com/projects/columns/cards/1478
        /// </summary>
        /// <example>https://api.github.com/projects/columns/cards/1478</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The project card's ID<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDExOlByb2plY3RDYXJkMTQ3OA==
        /// </summary>
        /// <example>MDExOlByb2plY3RDYXJkMTQ3OA==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: Add payload for delete Project column
        /// </summary>
        /// <example>Add payload for delete Project column</example>
        [global::Newtonsoft.Json.JsonProperty("note", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Note { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Creator { get; set; } = default!;

        /// <summary>
        /// Example: 2016-09-05T14:21:06Z
        /// </summary>
        /// <example>2016-09-05T14:21:06Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 2016-09-05T14:20:22Z
        /// </summary>
        /// <example>2016-09-05T14:20:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_name")]
        public string? ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/projects/columns/367
        /// </summary>
        /// <example>https://api.github.com/projects/columns/367</example>
        [global::Newtonsoft.Json.JsonProperty("column_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/api-playground/projects-test/issues/3
        /// </summary>
        /// <example>https://api.github.com/repos/api-playground/projects-test/issues/3</example>
        [global::Newtonsoft.Json.JsonProperty("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/projects/120
        /// </summary>
        /// <example>https://api.github.com/projects/120</example>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCard" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/projects/columns/cards/1478
        /// </param>
        /// <param name="id">
        /// The project card's ID<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId">
        /// Example: MDExOlByb2plY3RDYXJkMTQ3OA==
        /// </param>
        /// <param name="note">
        /// Example: Add payload for delete Project column
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// Example: 2016-09-05T14:21:06Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2016-09-05T14:20:22Z
        /// </param>
        /// <param name="archived">
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </param>
        /// <param name="columnName"></param>
        /// <param name="projectId"></param>
        /// <param name="columnUrl">
        /// Example: https://api.github.com/projects/columns/367
        /// </param>
        /// <param name="contentUrl">
        /// Example: https://api.github.com/repos/api-playground/projects-test/issues/3
        /// </param>
        /// <param name="projectUrl">
        /// Example: https://api.github.com/projects/120
        /// </param>
        public ProjectCard(
            string url,
            long id,
            string nodeId,
            string? note,
            global::G.NullableSimpleUser? creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string columnUrl,
            string projectUrl,
            bool? archived,
            string? columnName,
            string? projectId,
            string? contentUrl)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ColumnUrl = columnUrl ?? throw new global::System.ArgumentNullException(nameof(columnUrl));
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.Archived = archived;
            this.ColumnName = columnName;
            this.ProjectId = projectId;
            this.ContentUrl = contentUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCard" /> class.
        /// </summary>
        public ProjectCard()
        {
        }
    }
}