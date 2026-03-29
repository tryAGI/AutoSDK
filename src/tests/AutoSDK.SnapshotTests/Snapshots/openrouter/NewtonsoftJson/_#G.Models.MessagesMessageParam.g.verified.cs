//HintName: G.Models.MessagesMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Anthropic message with OpenRouter extensions
    /// </summary>
    public sealed partial class MessagesMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessagesMessageParamRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessagesMessageParamContent Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParam" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        public MessagesMessageParam(
            global::G.MessagesMessageParamRole role,
            global::G.MessagesMessageParamContent content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParam" /> class.
        /// </summary>
        public MessagesMessageParam()
        {
        }
    }
}