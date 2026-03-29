//HintName: G.Models.ProjectTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectTemplate
    {
        /// <summary>
        /// general dict serialized assignment settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment_settings")]
        public object? AssignmentSettings { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// custom script (Plugin) for projects created from this template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_script")]
        public string? CustomScript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// general dict serialized project settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_settings")]
        public object? ProjectSettings { get; set; }

        /// <summary>
        /// flag to require comment on skip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_comment_on_skip")]
        public bool? RequireCommentOnSkip { get; set; }

        /// <summary>
        /// general dict serialized review settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_settings")]
        public object? ReviewSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_unused_data_columns_to_annotators")]
        public bool? ShowUnusedDataColumnsToAnnotators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="assignmentSettings">
        /// general dict serialized assignment settings
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="customScript">
        /// custom script (Plugin) for projects created from this template
        /// </param>
        /// <param name="description"></param>
        /// <param name="organization"></param>
        /// <param name="projectSettings">
        /// general dict serialized project settings
        /// </param>
        /// <param name="requireCommentOnSkip">
        /// flag to require comment on skip
        /// </param>
        /// <param name="reviewSettings">
        /// general dict serialized review settings
        /// </param>
        /// <param name="showUnusedDataColumnsToAnnotators"></param>
        /// <param name="tags"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTemplate(
            string name,
            object? assignmentSettings,
            int? createdBy,
            string? customScript,
            string? description,
            int? organization,
            object? projectSettings,
            bool? requireCommentOnSkip,
            object? reviewSettings,
            bool? showUnusedDataColumnsToAnnotators,
            object? tags,
            global::System.DateTime createdAt = default!,
            int id = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.AssignmentSettings = assignmentSettings;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.CustomScript = customScript;
            this.Description = description;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Organization = organization;
            this.ProjectSettings = projectSettings;
            this.RequireCommentOnSkip = requireCommentOnSkip;
            this.ReviewSettings = reviewSettings;
            this.ShowUnusedDataColumnsToAnnotators = showUnusedDataColumnsToAnnotators;
            this.Tags = tags;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplate" /> class.
        /// </summary>
        public ProjectTemplate()
        {
        }
    }
}