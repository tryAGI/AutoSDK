//HintName: G.Models.ChatCompletionMessageReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Note: This is not part of the OpenAI API spec, but we added it for interoperability with multiple reasoning models.
    /// </summary>
    public sealed partial class ChatCompletionMessageReasoning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageReasoning" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="content"></param>
        public ChatCompletionMessageReasoning(
            string? id,
            string? content)
        {
            this.Id = id;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageReasoning" /> class.
        /// </summary>
        public ChatCompletionMessageReasoning()
        {
        }
    }
}