//HintName: G.Models.Prompt2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prompt2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        public global::System.Guid? CollectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string")]
        public string? String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        public double? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        public global::System.Guid? PromptVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptPromptVersionStatusJsonConverter))]
        public global::G.PromptPromptVersionStatus? PromptVersionStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_description")]
        public string? PromptVersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_label_id")]
        public global::System.Guid? PromptVersionLabelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtual_key")]
        public string? VirtualKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.IList<object>? Functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public object? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_metadata")]
        public object? TemplateMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_raw_template")]
        public bool? IsRawTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="collectionId"></param>
        /// <param name="string"></param>
        /// <param name="parameters"></param>
        /// <param name="promptVersion"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptVersionStatus"></param>
        /// <param name="promptVersionDescription"></param>
        /// <param name="promptVersionLabelId"></param>
        /// <param name="virtualKey"></param>
        /// <param name="model"></param>
        /// <param name="functions"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="templateMetadata"></param>
        /// <param name="isRawTemplate"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prompt2(
            global::System.Guid? id,
            string? slug,
            string? name,
            global::System.Guid? collectionId,
            string? @string,
            object? parameters,
            double? promptVersion,
            global::System.Guid? promptVersionId,
            global::G.PromptPromptVersionStatus? promptVersionStatus,
            string? promptVersionDescription,
            global::System.Guid? promptVersionLabelId,
            string? virtualKey,
            string? model,
            global::System.Collections.Generic.IList<object>? functions,
            global::System.Collections.Generic.IList<object>? tools,
            object? toolChoice,
            object? templateMetadata,
            bool? isRawTemplate,
            string? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt)
        {
            this.Id = id;
            this.Slug = slug;
            this.Name = name;
            this.CollectionId = collectionId;
            this.String = @string;
            this.Parameters = parameters;
            this.PromptVersion = promptVersion;
            this.PromptVersionId = promptVersionId;
            this.PromptVersionStatus = promptVersionStatus;
            this.PromptVersionDescription = promptVersionDescription;
            this.PromptVersionLabelId = promptVersionLabelId;
            this.VirtualKey = virtualKey;
            this.Model = model;
            this.Functions = functions;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.TemplateMetadata = templateMetadata;
            this.IsRawTemplate = isRawTemplate;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prompt2" /> class.
        /// </summary>
        public Prompt2()
        {
        }
    }
}