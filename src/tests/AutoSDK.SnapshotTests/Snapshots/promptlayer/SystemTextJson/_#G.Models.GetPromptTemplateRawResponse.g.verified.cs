//HintName: G.Models.GetPromptTemplateRawResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPromptTemplateRawResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The prompt template ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptName { get; set; }

        /// <summary>
        /// The version number of the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// The workspace this prompt template belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// The prompt template content. When resolve_snippets is true (default), snippets are expanded. When false, raw @@@snippet@@@ references are preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptTemplate2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptTemplate2 PromptTemplate { get; set; }

        /// <summary>
        /// Model configuration including provider, model name, and parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// The commit message for this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Tags associated with the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Timestamp when this version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// List of snippet references used in this template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SnippetReference> Snippets { get; set; }

        /// <summary>
        /// Provider-specific LLM arguments. Only present when include_llm_kwargs=true. Structure is provider-specific and may change without notice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_kwargs")]
        public object? LlmKwargs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateRawResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="id">
        /// The prompt template ID.
        /// </param>
        /// <param name="promptName">
        /// The name of the prompt template.
        /// </param>
        /// <param name="version">
        /// The version number of the prompt template.
        /// </param>
        /// <param name="workspaceId">
        /// The workspace this prompt template belongs to.
        /// </param>
        /// <param name="promptTemplate">
        /// The prompt template content. When resolve_snippets is true (default), snippets are expanded. When false, raw @@@snippet@@@ references are preserved.
        /// </param>
        /// <param name="snippets">
        /// List of snippet references used in this template.
        /// </param>
        /// <param name="metadata">
        /// Model configuration including provider, model name, and parameters.
        /// </param>
        /// <param name="commitMessage">
        /// The commit message for this version.
        /// </param>
        /// <param name="tags">
        /// Tags associated with the prompt template.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when this version was created.
        /// </param>
        /// <param name="llmKwargs">
        /// Provider-specific LLM arguments. Only present when include_llm_kwargs=true. Structure is provider-specific and may change without notice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPromptTemplateRawResponse(
            bool success,
            int id,
            string promptName,
            int version,
            int workspaceId,
            global::G.PromptTemplate2 promptTemplate,
            global::System.Collections.Generic.IList<global::G.SnippetReference> snippets,
            global::G.Metadata? metadata,
            string? commitMessage,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.DateTime? createdAt,
            object? llmKwargs)
        {
            this.Success = success;
            this.Id = id;
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.Version = version;
            this.WorkspaceId = workspaceId;
            this.PromptTemplate = promptTemplate;
            this.Metadata = metadata;
            this.CommitMessage = commitMessage;
            this.Tags = tags;
            this.CreatedAt = createdAt;
            this.Snippets = snippets ?? throw new global::System.ArgumentNullException(nameof(snippets));
            this.LlmKwargs = llmKwargs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateRawResponse" /> class.
        /// </summary>
        public GetPromptTemplateRawResponse()
        {
        }
    }
}