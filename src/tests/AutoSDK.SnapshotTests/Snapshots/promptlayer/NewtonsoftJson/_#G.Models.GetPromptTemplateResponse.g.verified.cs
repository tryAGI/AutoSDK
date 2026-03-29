//HintName: G.Models.GetPromptTemplateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPromptTemplateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptTemplate PromptTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// When you optionally specify `provider` in the body, `llm_kwargs` will be returned for that specific provider and you can pass these kwargs to the provider's API directly. **Important:** This object's structure is provider-specific and may change without notice as LLM providers update their APIs. For stable, provider-agnostic prompt data, use `prompt_template` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_kwargs")]
        public object? LlmKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptName"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="metadata"></param>
        /// <param name="commitMessage"></param>
        /// <param name="llmKwargs">
        /// When you optionally specify `provider` in the body, `llm_kwargs` will be returned for that specific provider and you can pass these kwargs to the provider's API directly. **Important:** This object's structure is provider-specific and may change without notice as LLM providers update their APIs. For stable, provider-agnostic prompt data, use `prompt_template` instead.
        /// </param>
        /// <param name="version"></param>
        public GetPromptTemplateResponse(
            int id,
            string promptName,
            global::G.PromptTemplate promptTemplate,
            global::G.Metadata? metadata,
            string? commitMessage,
            object? llmKwargs,
            int? version)
        {
            this.Id = id;
            this.PromptName = promptName ?? throw new global::System.ArgumentNullException(nameof(promptName));
            this.PromptTemplate = promptTemplate;
            this.Metadata = metadata;
            this.CommitMessage = commitMessage;
            this.LlmKwargs = llmKwargs;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPromptTemplateResponse" /> class.
        /// </summary>
        public GetPromptTemplateResponse()
        {
        }
    }
}