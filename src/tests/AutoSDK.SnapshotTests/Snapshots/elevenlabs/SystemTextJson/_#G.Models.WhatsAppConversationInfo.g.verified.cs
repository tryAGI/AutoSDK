//HintName: G.Models.WhatsAppConversationInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppConversationInfo
    {
        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter))]
        public global::G.WhatsAppConversationInfoDirection? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_phone_number_id")]
        public string? WhatsappPhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awaiting_first_user_message")]
        public bool? AwaitingFirstUserMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppConversationInfo" /> class.
        /// </summary>
        /// <param name="direction">
        /// Default Value: unknown
        /// </param>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="whatsappUserId"></param>
        /// <param name="awaitingFirstUserMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppConversationInfo(
            string whatsappUserId,
            global::G.WhatsAppConversationInfoDirection? direction,
            string? whatsappPhoneNumberId,
            bool? awaitingFirstUserMessage)
        {
            this.WhatsappUserId = whatsappUserId ?? throw new global::System.ArgumentNullException(nameof(whatsappUserId));
            this.Direction = direction;
            this.WhatsappPhoneNumberId = whatsappPhoneNumberId;
            this.AwaitingFirstUserMessage = awaitingFirstUserMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppConversationInfo" /> class.
        /// </summary>
        public WhatsAppConversationInfo()
        {
        }
    }
}