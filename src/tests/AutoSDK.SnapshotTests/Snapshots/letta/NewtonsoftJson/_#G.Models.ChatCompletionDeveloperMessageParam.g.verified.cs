//HintName: G.Models.ChatCompletionDeveloperMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Developer-provided instructions that the model should follow, regardless of<br/>
    /// messages sent by the user. With o1 models and newer, `developer` messages<br/>
    /// replace the previous `system` messages.
    /// </summary>
    public sealed partial class ChatCompletionDeveloperMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"developer"</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string Role { get; set; } = "developer";

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
        /// Initializes a new instance of the <see cref="ChatCompletionDeveloperMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        public ChatCompletionDeveloperMessageParam(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>> content,
            string? name,
            string role = "developer")
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDeveloperMessageParam" /> class.
        /// </summary>
        public ChatCompletionDeveloperMessageParam()
        {
        }
    }
}