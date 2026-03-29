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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the prompt is created at workspace level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public string? Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.JsonNodeWrite? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_description")]
        public string? ChangeDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptWriteTypeJsonConverter))]
        public global::G.PromptWriteType? Type { get; set; }

        /// <summary>
        /// Template structure type: 'text' or 'chat'. Immutable after creation.<br/>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_structure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptWriteTemplateStructureJsonConverter))]
        public global::G.PromptWriteTemplateStructure? TemplateStructure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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