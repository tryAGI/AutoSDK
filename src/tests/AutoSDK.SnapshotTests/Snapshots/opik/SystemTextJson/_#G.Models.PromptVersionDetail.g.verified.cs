//HintName: G.Models.PromptVersionDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionDetail
    {
        /// <summary>
        /// version unique identifier, generated if absent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public global::System.Guid? PromptId { get; set; }

        /// <summary>
        /// version short unique identifier, generated if absent. it must be 8 characters long
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.JsonNodeDetail? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptVersionDetailTypeJsonConverter))]
        public global::G.PromptVersionDetailType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_description")]
        public string? ChangeDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<string>? Variables { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_structure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptVersionDetailTemplateStructureJsonConverter))]
        public global::G.PromptVersionDetailTemplateStructure? TemplateStructure { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionDetail" /> class.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="id">
        /// version unique identifier, generated if absent
        /// </param>
        /// <param name="promptId">
        /// Included only in responses
        /// </param>
        /// <param name="commit">
        /// version short unique identifier, generated if absent. it must be 8 characters long
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="type"></param>
        /// <param name="changeDescription"></param>
        /// <param name="tags"></param>
        /// <param name="variables">
        /// Included only in responses
        /// </param>
        /// <param name="templateStructure">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionDetail(
            string template,
            global::System.Guid? id,
            global::System.Guid? promptId,
            string? commit,
            global::G.JsonNodeDetail? metadata,
            global::G.PromptVersionDetailType? type,
            string? changeDescription,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? variables,
            global::G.PromptVersionDetailTemplateStructure? templateStructure,
            global::System.DateTime? createdAt,
            string? createdBy)
        {
            this.Id = id;
            this.PromptId = promptId;
            this.Commit = commit;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
            this.Metadata = metadata;
            this.Type = type;
            this.ChangeDescription = changeDescription;
            this.Tags = tags;
            this.Variables = variables;
            this.TemplateStructure = templateStructure;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionDetail" /> class.
        /// </summary>
        public PromptVersionDetail()
        {
        }
    }
}