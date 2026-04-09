//HintName: G.Models.ChatCompletionMessageParamFallback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageParamFallback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageParamFallbackRoleJsonConverter))]
        public global::G.ChatCompletionMessageParamFallbackRole Role { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamFallback" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        public ChatCompletionMessageParamFallback(
            global::G.ChatCompletionMessageParamFallbackRole role,
            string? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamFallback" /> class.
        /// </summary>
        public ChatCompletionMessageParamFallback()
        {
        }
    }
}