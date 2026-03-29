//HintName: G.Models.PromptPartialVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptPartialVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_partial_id")]
        public global::System.Guid? PromptPartialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_partial_version_id")]
        public global::System.Guid? PromptPartialVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string")]
        public string? String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptPartialVersionPromptVersionStatusJsonConverter))]
        public global::G.PromptPartialVersionPromptVersionStatus? PromptVersionStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptPartialVersionObjectJsonConverter))]
        public global::G.PromptPartialVersionObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPartialVersion" /> class.
        /// </summary>
        /// <param name="promptPartialId"></param>
        /// <param name="promptPartialVersionId"></param>
        /// <param name="slug"></param>
        /// <param name="version"></param>
        /// <param name="string"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="promptVersionStatus"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptPartialVersion(
            global::System.Guid? promptPartialId,
            global::System.Guid? promptPartialVersionId,
            string? slug,
            string? version,
            string? @string,
            string? description,
            global::System.DateTime? createdAt,
            global::G.PromptPartialVersionPromptVersionStatus? promptVersionStatus,
            global::G.PromptPartialVersionObject? @object)
        {
            this.PromptPartialId = promptPartialId;
            this.PromptPartialVersionId = promptPartialVersionId;
            this.Slug = slug;
            this.Version = version;
            this.String = @string;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.PromptVersionStatus = promptVersionStatus;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptPartialVersion" /> class.
        /// </summary>
        public PromptPartialVersion()
        {
        }
    }
}