//HintName: G.Models.EvalStatusPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A public eval status page that displays aggregate experiment results
    /// </summary>
    public sealed partial class EvalStatusPage
    {
        /// <summary>
        /// Unique identifier for the eval status page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the project that the eval status page belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Identifies the user who created the eval status page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of eval status page creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date of eval status page deletion, or null if the eval status page is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Name of the eval status page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the eval status page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the logo to display on the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// The theme for the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("theme", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalStatusPageTheme Theme { get; set; } = default!;

        /// <summary>
        /// Configuration for what data to display
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalStatusPageConfig Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStatusPage" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the eval status page
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the eval status page belongs under
        /// </param>
        /// <param name="name">
        /// Name of the eval status page
        /// </param>
        /// <param name="theme">
        /// The theme for the page
        /// </param>
        /// <param name="config">
        /// Configuration for what data to display
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the eval status page
        /// </param>
        /// <param name="created">
        /// Date of eval status page creation
        /// </param>
        /// <param name="deletedAt">
        /// Date of eval status page deletion, or null if the eval status page is still active
        /// </param>
        /// <param name="description">
        /// Textual description of the eval status page
        /// </param>
        /// <param name="logoUrl">
        /// URL of the logo to display on the page
        /// </param>
        public EvalStatusPage(
            global::System.Guid id,
            global::System.Guid projectId,
            string name,
            global::G.EvalStatusPageTheme theme,
            global::G.EvalStatusPageConfig config,
            global::System.Guid? userId,
            global::System.DateTime? created,
            global::System.DateTime? deletedAt,
            string? description,
            string? logoUrl)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Created = created;
            this.DeletedAt = deletedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.LogoUrl = logoUrl;
            this.Theme = theme;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStatusPage" /> class.
        /// </summary>
        public EvalStatusPage()
        {
        }
    }
}