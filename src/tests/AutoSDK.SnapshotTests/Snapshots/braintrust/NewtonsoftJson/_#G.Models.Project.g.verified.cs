//HintName: G.Models.Project.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// Unique identifier for the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique id for the organization that the project belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrgId { get; set; } = default!;

        /// <summary>
        /// Name of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date of project creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date of project deletion, or null if the project is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Identifies the user who created the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public global::G.ProjectSettings? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the project
        /// </param>
        /// <param name="orgId">
        /// Unique id for the organization that the project belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Textual description of the project
        /// </param>
        /// <param name="created">
        /// Date of project creation
        /// </param>
        /// <param name="deletedAt">
        /// Date of project deletion, or null if the project is still active
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the project
        /// </param>
        /// <param name="settings"></param>
        public Project(
            global::System.Guid id,
            global::System.Guid orgId,
            string name,
            string? description,
            global::System.DateTime? created,
            global::System.DateTime? deletedAt,
            global::System.Guid? userId,
            global::G.ProjectSettings? settings)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Created = created;
            this.DeletedAt = deletedAt;
            this.UserId = userId;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}