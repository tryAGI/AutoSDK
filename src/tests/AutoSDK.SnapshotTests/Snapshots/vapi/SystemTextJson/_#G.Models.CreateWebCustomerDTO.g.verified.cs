//HintName: G.Models.CreateWebCustomerDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebCustomerDTO
    {
        /// <summary>
        /// This is the flag to toggle the E164 check for the `number` field. This is an advanced property which should be used if you know your use case requires it.<br/>
        /// Use cases:<br/>
        /// - `false`: To allow non-E164 numbers like `+001234567890`, `1234`, or `abc`. This is useful for dialing out to non-E164 numbers on your SIP trunks.<br/>
        /// - `true` (default): To allow only E164 numbers like `+14155551234`. This is standard for PSTN calls.<br/>
        /// If `false`, the `number` is still required to only contain alphanumeric characters (regex: `/^\+?[a-zA-Z0-9]+$/`).<br/>
        /// @default true (E164 check is enabled)<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberE164CheckEnabled")]
        public bool? NumberE164CheckEnabled { get; set; }

        /// <summary>
        /// This is the extension that will be dialed after the call is answered.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in web chat - other assistant properties cannot be overridden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::G.ChatAssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the number of the customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public string? Number { get; set; }

        /// <summary>
        /// This is the SIP URI of the customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipUri")]
        public string? SipUri { get; set; }

        /// <summary>
        /// This is the name of the customer. This is just for your own reference.<br/>
        /// For SIP inbound calls, this is extracted from the `From` SIP header with format `"Display Name" &lt;sip:username@domain&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the email of the customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// This is the external ID of the customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebCustomerDTO" /> class.
        /// </summary>
        /// <param name="numberE164CheckEnabled">
        /// This is the flag to toggle the E164 check for the `number` field. This is an advanced property which should be used if you know your use case requires it.<br/>
        /// Use cases:<br/>
        /// - `false`: To allow non-E164 numbers like `+001234567890`, `1234`, or `abc`. This is useful for dialing out to non-E164 numbers on your SIP trunks.<br/>
        /// - `true` (default): To allow only E164 numbers like `+14155551234`. This is standard for PSTN calls.<br/>
        /// If `false`, the `number` is still required to only contain alphanumeric characters (regex: `/^\+?[a-zA-Z0-9]+$/`).<br/>
        /// @default true (E164 check is enabled)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="extension">
        /// This is the extension that will be dialed after the call is answered.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in web chat - other assistant properties cannot be overridden.
        /// </param>
        /// <param name="number">
        /// This is the number of the customer.
        /// </param>
        /// <param name="sipUri">
        /// This is the SIP URI of the customer.
        /// </param>
        /// <param name="name">
        /// This is the name of the customer. This is just for your own reference.<br/>
        /// For SIP inbound calls, this is extracted from the `From` SIP header with format `"Display Name" &lt;sip:username@domain&gt;`.
        /// </param>
        /// <param name="email">
        /// This is the email of the customer.
        /// </param>
        /// <param name="externalId">
        /// This is the external ID of the customer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebCustomerDTO(
            bool? numberE164CheckEnabled,
            string? extension,
            global::G.ChatAssistantOverrides? assistantOverrides,
            string? number,
            string? sipUri,
            string? name,
            string? email,
            string? externalId)
        {
            this.NumberE164CheckEnabled = numberE164CheckEnabled;
            this.Extension = extension;
            this.AssistantOverrides = assistantOverrides;
            this.Number = number;
            this.SipUri = sipUri;
            this.Name = name;
            this.Email = email;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebCustomerDTO" /> class.
        /// </summary>
        public CreateWebCustomerDTO()
        {
        }
    }
}