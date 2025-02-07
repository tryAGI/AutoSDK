//HintName: G.Models.SSOEmailVerificationSendRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOEmailVerificationSendRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SamlProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOEmailVerificationSendRequest" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="samlProviderId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSOEmailVerificationSendRequest(
            string email,
            global::System.Guid samlProviderId)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.SamlProviderId = samlProviderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOEmailVerificationSendRequest" /> class.
        /// </summary>
        public SSOEmailVerificationSendRequest()
        {
        }
    }
}