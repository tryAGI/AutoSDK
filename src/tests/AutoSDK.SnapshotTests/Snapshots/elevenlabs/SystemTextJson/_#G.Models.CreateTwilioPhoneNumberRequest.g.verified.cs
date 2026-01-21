//HintName: G.Models.CreateTwilioPhoneNumberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTwilioPhoneNumberRequest
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
        /// Default Value: twilio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Twilio Account SID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sid { get; set; }

        /// <summary>
        /// Twilio Auth Token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioPhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="provider">
        /// Default Value: twilio
        /// </param>
        /// <param name="sid">
        /// Twilio Account SID
        /// </param>
        /// <param name="token">
        /// Twilio Auth Token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTwilioPhoneNumberRequest(
            string phoneNumber,
            string label,
            string sid,
            string token,
            string? provider)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Sid = sid ?? throw new global::System.ArgumentNullException(nameof(sid));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioPhoneNumberRequest" /> class.
        /// </summary>
        public CreateTwilioPhoneNumberRequest()
        {
        }
    }
}