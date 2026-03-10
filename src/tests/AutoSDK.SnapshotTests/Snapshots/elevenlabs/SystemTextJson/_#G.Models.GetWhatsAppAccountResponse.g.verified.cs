//HintName: G.Models.GetWhatsAppAccountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWhatsAppAccountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BusinessAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_account_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BusinessAccountName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_agent_id")]
        public string? AssignedAgentId { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_messaging")]
        public bool? EnableMessaging { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_audio_message_response")]
        public bool? EnableAudioMessageResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_agent_name")]
        public string? AssignedAgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhatsAppAccountResponse" /> class.
        /// </summary>
        /// <param name="businessAccountId"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="businessAccountName"></param>
        /// <param name="phoneNumberName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="assignedAgentId"></param>
        /// <param name="enableMessaging">
        /// Default Value: true
        /// </param>
        /// <param name="enableAudioMessageResponse">
        /// Default Value: true
        /// </param>
        /// <param name="assignedAgentName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWhatsAppAccountResponse(
            string businessAccountId,
            string phoneNumberId,
            string businessAccountName,
            string phoneNumberName,
            string phoneNumber,
            string? assignedAgentId,
            bool? enableMessaging,
            bool? enableAudioMessageResponse,
            string? assignedAgentName)
        {
            this.BusinessAccountId = businessAccountId ?? throw new global::System.ArgumentNullException(nameof(businessAccountId));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.BusinessAccountName = businessAccountName ?? throw new global::System.ArgumentNullException(nameof(businessAccountName));
            this.PhoneNumberName = phoneNumberName ?? throw new global::System.ArgumentNullException(nameof(phoneNumberName));
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.AssignedAgentId = assignedAgentId;
            this.EnableMessaging = enableMessaging;
            this.EnableAudioMessageResponse = enableAudioMessageResponse;
            this.AssignedAgentName = assignedAgentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhatsAppAccountResponse" /> class.
        /// </summary>
        public GetWhatsAppAccountResponse()
        {
        }
    }
}