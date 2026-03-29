//HintName: G.Models.CreatePromptVersionDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptVersionDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptVersionDetail Version { get; set; } = default!;

        /// <summary>
        /// Template structure for the prompt: 'text' or 'chat'. Note: This field is only used when creating a new prompt. If a prompt with the given name already exists, this field is ignored and the existing prompt's template structure is used. Template structure is immutable after prompt creation.<br/>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_structure")]
        public global::G.CreatePromptVersionDetailTemplateStructure? TemplateStructure { get; set; }

        /// <summary>
        /// Optional set of project IDs to exclude from automatic blueprint creation when this prompt version is committed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_blueprint_update_for_projects")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExcludeBlueprintUpdateForProjects { get; set; }

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// If provided, scopes the prompt to the specified project. Ignored when project_id is provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptVersionDetail" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="templateStructure">
        /// Template structure for the prompt: 'text' or 'chat'. Note: This field is only used when creating a new prompt. If a prompt with the given name already exists, this field is ignored and the existing prompt's template structure is used. Template structure is immutable after prompt creation.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="excludeBlueprintUpdateForProjects">
        /// Optional set of project IDs to exclude from automatic blueprint creation when this prompt version is committed.
        /// </param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// If provided, scopes the prompt to the specified project. Ignored when project_id is provided.
        /// </param>
        public CreatePromptVersionDetail(
            string name,
            global::G.PromptVersionDetail version,
            global::G.CreatePromptVersionDetailTemplateStructure? templateStructure,
            global::System.Collections.Generic.IList<global::System.Guid>? excludeBlueprintUpdateForProjects,
            global::System.Guid? projectId,
            string? projectName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.TemplateStructure = templateStructure;
            this.ExcludeBlueprintUpdateForProjects = excludeBlueprintUpdateForProjects;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptVersionDetail" /> class.
        /// </summary>
        public CreatePromptVersionDetail()
        {
        }
    }
}