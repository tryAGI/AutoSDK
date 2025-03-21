//HintName: G.Models.Project.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an individual project.
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `organization.project`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ProjectObject Object { get; set; }

        /// <summary>
        /// The name of the project. This appears in reporting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the project was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) of when the project was archived or `null`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived_at")]
        public global::System.DateTimeOffset? ArchivedAt { get; set; }

        /// <summary>
        /// `active` or `archived`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.project`
        /// </param>
        /// <param name="name">
        /// The name of the project. This appears in reporting.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the project was created.
        /// </param>
        /// <param name="archivedAt">
        /// The Unix timestamp (in seconds) of when the project was archived or `null`.
        /// </param>
        /// <param name="status">
        /// `active` or `archived`
        /// </param>
        public Project(
            string id,
            string name,
            global::System.DateTimeOffset createdAt,
            global::G.ProjectStatus status,
            global::G.ProjectObject @object,
            global::System.DateTimeOffset? archivedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Object = @object;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}