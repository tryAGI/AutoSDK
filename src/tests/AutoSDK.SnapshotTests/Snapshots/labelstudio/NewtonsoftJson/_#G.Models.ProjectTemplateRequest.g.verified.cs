//HintName: G.Models.ProjectTemplateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectTemplateRequest
    {
        /// <summary>
        /// general dict serialized assignment settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignment_settings")]
        public object? AssignmentSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// custom script (Plugin) for projects created from this template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_script")]
        public string? CustomScript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// general dict serialized project settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_settings")]
        public object? ProjectSettings { get; set; }

        /// <summary>
        /// flag to require comment on skip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_comment_on_skip")]
        public bool? RequireCommentOnSkip { get; set; }

        /// <summary>
        /// general dict serialized review settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_settings")]
        public object? ReviewSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_unused_data_columns_to_annotators")]
        public bool? ShowUnusedDataColumnsToAnnotators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplateRequest" /> class.
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
        /// <param name="projectId">
        /// Included only in requests
        /// </param>
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
        public ProjectTemplateRequest(
            string name,
            object? assignmentSettings,
            int? createdBy,
            string? customScript,
            string? description,
            int? organization,
            int? projectId,
            object? projectSettings,
            bool? requireCommentOnSkip,
            object? reviewSettings,
            bool? showUnusedDataColumnsToAnnotators,
            object? tags)
        {
            this.AssignmentSettings = assignmentSettings;
            this.CreatedBy = createdBy;
            this.CustomScript = customScript;
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Organization = organization;
            this.ProjectId = projectId;
            this.ProjectSettings = projectSettings;
            this.RequireCommentOnSkip = requireCommentOnSkip;
            this.ReviewSettings = reviewSettings;
            this.ShowUnusedDataColumnsToAnnotators = showUnusedDataColumnsToAnnotators;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplateRequest" /> class.
        /// </summary>
        public ProjectTemplateRequest()
        {
        }
    }
}