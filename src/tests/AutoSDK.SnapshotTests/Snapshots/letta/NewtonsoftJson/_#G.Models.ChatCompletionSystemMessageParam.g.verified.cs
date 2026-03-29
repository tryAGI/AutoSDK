//HintName: G.Models.ChatCompletionSystemMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Developer-provided instructions that the model should follow, regardless of<br/>
    /// messages sent by the user. With o1 models and newer, use `developer` messages<br/>
    /// for this purpose instead.
    /// </summary>
    public sealed partial class ChatCompletionSystemMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"system"</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string Role { get; set; } = "system";

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
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        public ChatCompletionSystemMessageParam(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>> content,
            string? name,
            string role = "system")
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessageParam" /> class.
        /// </summary>
        public ChatCompletionSystemMessageParam()
        {
        }
    }
}