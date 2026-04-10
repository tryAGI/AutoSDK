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
        [global::Newtonsoft.Json.JsonProperty("direction")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter))]
        public global::G.WhatsAppConversationInfoDirection? Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whatsapp_phone_number_id")]
        public string? WhatsappPhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("whatsapp_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WhatsappUserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("awaiting_first_user_message")]
        public bool? AwaitingFirstUserMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppConversationInfo" /> class.
        /// </summary>
        /// <param name="whatsappUserId"></param>
        /// <param name="direction">
        /// Default Value: unknown
        /// </param>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="awaitingFirstUserMessage"></param>
        public WhatsAppConversationInfo(
            string whatsappUserId,
            global::G.WhatsAppConversationInfoDirection? direction,
            string? whatsappPhoneNumberId,
            bool? awaitingFirstUserMessage)
        {
            this.Direction = direction;
            this.WhatsappPhoneNumberId = whatsappPhoneNumberId;
            this.WhatsappUserId = whatsappUserId ?? throw new global::System.ArgumentNullException(nameof(whatsappUserId));
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