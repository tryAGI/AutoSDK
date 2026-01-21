//HintName: G.Models.ChatCompletionStreamOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for streaming response. Only set this when you set `stream: true`.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class ChatCompletionStreamOptions
    {
        /// <summary>
        /// If set, an additional chunk will be streamed before the `data: [DONE]`<br/>
        /// message. The `usage` field on this chunk shows the token usage statistics<br/>
        /// for the entire request, and the `choices` field will always be an empty<br/>
        /// array. <br/>
        /// All other chunks will also include a `usage` field, but with a null<br/>
        /// value. **NOTE:** If the stream is interrupted, you may not receive the<br/>
        /// final usage chunk which contains the total token usage for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// If set, an additional chunk will be streamed before the `data: [DONE]`<br/>
        /// message. The `usage` field on this chunk shows the token usage statistics<br/>
        /// for the entire request, and the `choices` field will always be an empty<br/>
        /// array. <br/>
        /// All other chunks will also include a `usage` field, but with a null<br/>
        /// value. **NOTE:** If the stream is interrupted, you may not receive the<br/>
        /// final usage chunk which contains the total token usage for the request.
        /// </param>
        public ChatCompletionStreamOptions(
            bool? includeUsage)
        {
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionStreamOptions" /> class.
        /// </summary>
        public ChatCompletionStreamOptions()
        {
        }
    }
}