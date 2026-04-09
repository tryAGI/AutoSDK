//HintName: G.Models.ChatCompletionMessageParamFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageParamFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageParamFunctionRoleJsonConverter))]
        public global::G.ChatCompletionMessageParamFunctionRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamFunction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="role"></param>
        public ChatCompletionMessageParamFunction(
            string name,
            string? content,
            global::G.ChatCompletionMessageParamFunctionRole role)
        {
            this.Content = content;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamFunction" /> class.
        /// </summary>
        public ChatCompletionMessageParamFunction()
        {
        }
    }
}