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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageParamDiscriminatorRoleJsonConverter))]
        public global::G.ChatCompletionMessageParamDiscriminatorRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageParamDiscriminator" /> class.
        /// </summary>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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