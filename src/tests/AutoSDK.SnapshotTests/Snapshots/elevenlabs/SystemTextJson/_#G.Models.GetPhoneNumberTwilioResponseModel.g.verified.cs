//HintName: G.Models.GetPhoneNumberTwilioResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"label":"Customer Support","phone_number":"\u002B1234567890","phone_number_id":"phone_123","provider":"twilio"}
    /// </summary>
    public sealed partial class GetPhoneNumberTwilioResponseModel
    {
        /// <summary>
        /// Phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future. Whether this phone number supports inbound calls<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_inbound")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SupportsInbound { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future. Whether this phone number supports outbound calls<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_outbound")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SupportsOutbound { get; set; }

        /// <summary>
        /// The ID of the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberId { get; set; }

        /// <summary>
        /// The agent that is assigned to the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_agent")]
        public global::G.PhoneNumberAgentInfo? AssignedAgent { get; set; }

        /// <summary>
        /// Phone provider<br/>
        /// Default Value: twilio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberTwilioResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="phoneNumberId">
        /// The ID of the phone number
        /// </param>
        /// <param name="assignedAgent">
        /// The agent that is assigned to the phone number
        /// </param>
        /// <param name="provider">
        /// Phone provider<br/>
        /// Default Value: twilio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPhoneNumberTwilioResponseModel(
            string phoneNumber,
            string label,
            string phoneNumberId,
            global::G.PhoneNumberAgentInfo? assignedAgent,
            string? provider)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.AssignedAgent = assignedAgent;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberTwilioResponseModel" /> class.
        /// </summary>
        public GetPhoneNumberTwilioResponseModel()
        {
        }
    }
}