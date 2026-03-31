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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Unique identifier for the project that the eval status page belongs under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Identifies the user who created the eval status page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of eval status page creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date of eval status page deletion, or null if the eval status page is still active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Name of the eval status page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Textual description of the eval status page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// URL of the logo to display on the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// The theme for the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalStatusPageThemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalStatusPageTheme Theme { get; set; }

        /// <summary>
        /// Configuration for what data to display
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalStatusPageConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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