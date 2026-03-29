//HintName: G.Models.ChatCompletionUserMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Messages sent by an end user, containing prompts or additional context<br/>
    /// information.
    /// </summary>
    public sealed partial class ChatCompletionUserMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartImageParam, global::G.ChatCompletionContentPartInputAudioParam, global::G.File>>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string Role { get; set; } = "user";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        public ChatCompletionUserMessageParam(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartImageParam, global::G.ChatCompletionContentPartInputAudioParam, global::G.File>>> content,
            string? name,
            string role = "user")
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParam" /> class.
        /// </summary>
        public ChatCompletionUserMessageParam()
        {
        }
    }
}