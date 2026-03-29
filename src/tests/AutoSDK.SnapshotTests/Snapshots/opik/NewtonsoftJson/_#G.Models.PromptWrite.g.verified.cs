//HintName: G.Models.PromptWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the prompt is created at workspace level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public string? Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.JsonNodeWrite? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("change_description")]
        public string? ChangeDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PromptWriteType? Type { get; set; }

        /// <summary>
        /// Template structure type: 'text' or 'chat'. Immutable after creation.<br/>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_structure")]
        public global::G.PromptWriteTemplateStructure? TemplateStructure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWrite" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the prompt is created at workspace level.
        /// </param>
        /// <param name="description"></param>
        /// <param name="template"></param>
        /// <param name="metadata"></param>
        /// <param name="changeDescription"></param>
        /// <param name="type"></param>
        /// <param name="templateStructure">
        /// Template structure type: 'text' or 'chat'. Immutable after creation.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="tags"></param>
        public PromptWrite(
            string name,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? projectName,
            string? description,
            string? template,
            global::G.JsonNodeWrite? metadata,
            string? changeDescription,
            global::G.PromptWriteType? type,
            global::G.PromptWriteTemplateStructure? templateStructure,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Description = description;
            this.Template = template;
            this.Metadata = metadata;
            this.ChangeDescription = changeDescription;
            this.Type = type;
            this.TemplateStructure = templateStructure;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptWrite" /> class.
        /// </summary>
        public PromptWrite()
        {
        }
    }
}