//HintName: G.Models.ProjectTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A project tag is a user-configured tag for tracking and filtering your experiments, logs, and other data
    /// </summary>
    public sealed partial class ProjectTag
    {
        /// <summary>
        /// Unique identifier for the project tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the project that the project tag belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// Date of project tag creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the project tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the project tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color of the tag for the UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// An optional LexoRank-based string that sets the sort position for the tag in the UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public string? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTag" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the project tag
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the project tag belongs under
        /// </param>
        /// <param name="userId"></param>
        /// <param name="name">
        /// Name of the project tag
        /// </param>
        /// <param name="created">
        /// Date of project tag creation
        /// </param>
        /// <param name="description">
        /// Textual description of the project tag
        /// </param>
        /// <param name="color">
        /// Color of the tag for the UI
        /// </param>
        /// <param name="position">
        /// An optional LexoRank-based string that sets the sort position for the tag in the UI
        /// </param>
        public ProjectTag(
            global::System.Guid id,
            global::System.Guid projectId,
            global::System.Guid userId,
            string name,
            global::System.DateTime? created,
            string? description,
            string? color,
            string? position)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Color = color;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTag" /> class.
        /// </summary>
        public ProjectTag()
        {
        }
    }
}