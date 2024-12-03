//HintName: G.Models.ChatCompletionMessageParamDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageParamDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionMessageParamDiscriminatorRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamDiscriminator" /> class.
        /// </summary>
        /// <param name="role"></param>
        public ChatCompletionMessageParamDiscriminator(
            global::G.ChatCompletionMessageParamDiscriminatorRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamDiscriminator" /> class.
        /// </summary>
        public ChatCompletionMessageParamDiscriminator()
        {
        }
    }
}