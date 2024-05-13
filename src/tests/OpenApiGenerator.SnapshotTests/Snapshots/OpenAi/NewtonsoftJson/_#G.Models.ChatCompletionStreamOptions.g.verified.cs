//HintName: G.Models.ChatCompletionStreamOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for streaming response. Only set this when you set `stream: true`.
    /// <br/>Default Value: 
    /// </summary>
    public sealed partial class ChatCompletionStreamOptions
    {
        /// <summary>
        /// If set, an additional chunk will be streamed before the `data: [DONE]` message. The `usage` field on this chunk shows the token usage statistics for the entire request, and the `choices` field will always be an empty array. All other chunks will also include a `usage` field, but with a null value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_usage")]
        public bool IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}