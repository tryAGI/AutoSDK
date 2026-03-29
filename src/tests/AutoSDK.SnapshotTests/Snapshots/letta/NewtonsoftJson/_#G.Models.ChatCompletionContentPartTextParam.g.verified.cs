//HintName: G.Models.ChatCompletionContentPartTextParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Learn about [text inputs](https://platform.openai.com/docs/guides/text-generation).
    /// </summary>
    public sealed partial class ChatCompletionContentPartTextParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"text"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "text";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartTextParam" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        public ChatCompletionContentPartTextParam(
            string text,
            string type = "text")
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartTextParam" /> class.
        /// </summary>
        public ChatCompletionContentPartTextParam()
        {
        }
    }
}