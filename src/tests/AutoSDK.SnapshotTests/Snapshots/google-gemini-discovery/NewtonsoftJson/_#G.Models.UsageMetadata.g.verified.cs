//HintName: G.Models.UsageMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata on the generation request's token usage.
    /// </summary>
    public sealed partial class UsageMetadata
    {
        /// <summary>
        /// Number of tokens in the prompt. When `cached_content` is set, this is still the total effective prompt size meaning this includes the number of tokens in the cached content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokenCount")]
        public int? PromptTokenCount { get; set; }

        /// <summary>
        /// Number of tokens in the cached part of the prompt (the cached content)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cachedContentTokenCount")]
        public int? CachedContentTokenCount { get; set; }

        /// <summary>
        /// Total number of tokens across all the generated response candidates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidatesTokenCount")]
        public int? CandidatesTokenCount { get; set; }

        /// <summary>
        /// Output only. Number of tokens present in tool-use prompt(s).<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolUsePromptTokenCount")]
        public int? ToolUsePromptTokenCount { get; set; }

        /// <summary>
        /// Output only. Number of tokens of thoughts for thinking models.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thoughtsTokenCount")]
        public int? ThoughtsTokenCount { get; set; }

        /// <summary>
        /// Total token count for the generation request (prompt + response candidates).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokenCount")]
        public int? TotalTokenCount { get; set; }

        /// <summary>
        /// Output only. List of modalities that were processed in the request input.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokensDetails")]
        public global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? PromptTokensDetails { get; set; }

        /// <summary>
        /// Output only. List of modalities of the cached content in the request input.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheTokensDetails")]
        public global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? CacheTokensDetails { get; set; }

        /// <summary>
        /// Output only. List of modalities that were returned in the response.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidatesTokensDetails")]
        public global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? CandidatesTokensDetails { get; set; }

        /// <summary>
        /// Output only. List of modalities that were processed for tool-use request inputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolUsePromptTokensDetails")]
        public global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? ToolUsePromptTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetadata" /> class.
        /// </summary>
        /// <param name="promptTokenCount">
        /// Number of tokens in the prompt. When `cached_content` is set, this is still the total effective prompt size meaning this includes the number of tokens in the cached content.
        /// </param>
        /// <param name="cachedContentTokenCount">
        /// Number of tokens in the cached part of the prompt (the cached content)
        /// </param>
        /// <param name="candidatesTokenCount">
        /// Total number of tokens across all the generated response candidates.
        /// </param>
        /// <param name="toolUsePromptTokenCount">
        /// Output only. Number of tokens present in tool-use prompt(s).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="thoughtsTokenCount">
        /// Output only. Number of tokens of thoughts for thinking models.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalTokenCount">
        /// Total token count for the generation request (prompt + response candidates).
        /// </param>
        /// <param name="promptTokensDetails">
        /// Output only. List of modalities that were processed in the request input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cacheTokensDetails">
        /// Output only. List of modalities of the cached content in the request input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="candidatesTokensDetails">
        /// Output only. List of modalities that were returned in the response.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="toolUsePromptTokensDetails">
        /// Output only. List of modalities that were processed for tool-use request inputs.<br/>
        /// Included only in responses
        /// </param>
        public UsageMetadata(
            int? promptTokenCount,
            int? cachedContentTokenCount,
            int? candidatesTokenCount,
            int? toolUsePromptTokenCount,
            int? thoughtsTokenCount,
            int? totalTokenCount,
            global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? promptTokensDetails,
            global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? cacheTokensDetails,
            global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? candidatesTokensDetails,
            global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? toolUsePromptTokensDetails)
        {
            this.PromptTokenCount = promptTokenCount;
            this.CachedContentTokenCount = cachedContentTokenCount;
            this.CandidatesTokenCount = candidatesTokenCount;
            this.ToolUsePromptTokenCount = toolUsePromptTokenCount;
            this.ThoughtsTokenCount = thoughtsTokenCount;
            this.TotalTokenCount = totalTokenCount;
            this.PromptTokensDetails = promptTokensDetails;
            this.CacheTokensDetails = cacheTokensDetails;
            this.CandidatesTokensDetails = candidatesTokensDetails;
            this.ToolUsePromptTokensDetails = toolUsePromptTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetadata" /> class.
        /// </summary>
        public UsageMetadata()
        {
        }
    }
}