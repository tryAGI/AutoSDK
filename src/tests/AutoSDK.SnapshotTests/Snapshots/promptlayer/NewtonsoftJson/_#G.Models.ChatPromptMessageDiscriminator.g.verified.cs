//HintName: G.Models.ChatPromptMessageDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatPromptMessageDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatPromptMessageDiscriminatorRoleJsonConverter))]
        public global::G.ChatPromptMessageDiscriminatorRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatPromptMessageDiscriminator" /> class.
        /// </summary>
        /// <param name="role"></param>
        public ChatPromptMessageDiscriminator(
            global::G.ChatPromptMessageDiscriminatorRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatPromptMessageDiscriminator" /> class.
        /// </summary>
        public ChatPromptMessageDiscriminator()
        {
        }
    }
}