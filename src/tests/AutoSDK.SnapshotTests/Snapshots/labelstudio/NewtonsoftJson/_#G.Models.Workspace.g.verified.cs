//HintName: G.Models.Workspace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class Workspace
    {
        /// <summary>
        /// Color
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public int CreatedBy { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_by_user")]
        public string CreatedByUser { get; set; } = default!;

        /// <summary>
        /// Workspace description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Workspace is archived
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Workspace is a personal user workspace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_personal")]
        public bool? IsPersonal { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("membership")]
        public string Membership { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects_count")]
        public int? ProjectsCount { get; set; }

        /// <summary>
        /// Workspace Name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        /// <param name="title">
        /// Workspace Name
        /// </param>
        /// <param name="color">
        /// Color
        /// </param>
        /// <param name="description">
        /// Workspace description
        /// </param>
        /// <param name="isArchived">
        /// Workspace is archived
        /// </param>
        /// <param name="isPersonal">
        /// Workspace is a personal user workspace
        /// </param>
        /// <param name="projectsCount">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="createdByUser">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="membership">
        /// Included only in responses
        /// </param>
        public Workspace(
            string title,
            string? color,
            string? description,
            bool? isArchived,
            bool? isPersonal,
            int? projectsCount,
            int createdBy = default!,
            string createdByUser = default!,
            int id = default!,
            string membership = default!)
        {
            this.Color = color;
            this.CreatedBy = createdBy;
            this.CreatedByUser = createdByUser;
            this.Description = description;
            this.Id = id;
            this.IsArchived = isArchived;
            this.IsPersonal = isPersonal;
            this.Membership = membership;
            this.ProjectsCount = projectsCount;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workspace" /> class.
        /// </summary>
        public Workspace()
        {
        }
    }
}