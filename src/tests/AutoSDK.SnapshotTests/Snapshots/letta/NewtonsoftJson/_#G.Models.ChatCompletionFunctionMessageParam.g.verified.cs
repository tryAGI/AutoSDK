//HintName: G.Models.ChatCompletionFunctionMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionFunctionMessageParam
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
        /// <default>"function"</default>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string Role { get; set; } = "function";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFunctionMessageParam" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="role"></param>
        public ChatCompletionFunctionMessageParam(
            string name,
            string? content,
            string role = "function")
        {
            this.Content = content;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFunctionMessageParam" /> class.
        /// </summary>
        public ChatCompletionFunctionMessageParam()
        {
        }
    }
}