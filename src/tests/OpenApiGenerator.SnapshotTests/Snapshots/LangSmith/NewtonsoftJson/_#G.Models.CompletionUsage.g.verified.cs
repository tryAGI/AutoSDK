//HintName: G.Models.CompletionUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionUsage
    {
        /// <summary>
        /// <br/>Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int PromptTokens { get; set; } = 0;

        /// <summary>
        /// <br/>Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int CompletionTokens { get; set; } = 0;

        /// <summary>
        /// <br/>Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int TotalTokens { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}