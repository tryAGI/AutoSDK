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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// The prompt template ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the prompt template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptName { get; set; } = default!;

        /// <summary>
        /// The version number of the prompt template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// The workspace this prompt template belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkspaceId { get; set; } = default!;

        /// <summary>
        /// The prompt template content. When resolve_snippets is true (default), snippets are expanded. When false, raw @@@snippet@@@ references are preserved.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptTemplate2 PromptTemplate { get; set; } = default!;

        /// <summary>
        /// Model configuration including provider, model name, and parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// The commit message for this version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Tags associated with the prompt template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Timestamp when this version was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// List of snippet references used in this template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snippets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SnippetReference> Snippets { get; set; } = default!;

        /// <summary>
        /// Provider-specific LLM arguments. Only present when include_llm_kwargs=true. Structure is provider-specific and may change without notice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_kwargs")]
        public object? LlmKwargs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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