//HintName: G.Models.ChatModerationRequestInputVariant2ItemItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatModerationRequestInputVariant2ItemItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatModerationRequestInputVariant2ItemItemDiscriminator" /> class.
        /// </summary>
        /// <param name="role"></param>
        public ChatModerationRequestInputVariant2ItemItemDiscriminator(
            global::G.ChatModerationRequestInputVariant2ItemItemDiscriminatorRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatModerationRequestInputVariant2ItemItemDiscriminator" /> class.
        /// </summary>
        public ChatModerationRequestInputVariant2ItemItemDiscriminator()
        {
        }
    }
}