//HintName: G.Models.CreateCustomCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCustomCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateCustomCredentialDTOProviderJsonConverter))]
        public global::G.CreateCustomCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthenticationPlan6JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthenticationPlan6 AuthenticationPlan { get; set; }

        /// <summary>
        /// This is the encryption plan for encrypting sensitive data. Currently supports public-key encryption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptionPlan")]
        public global::G.PublicKeyEncryptionPlan? EncryptionPlan { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomCredentialDTO" /> class.
        /// </summary>
        /// <param name="authenticationPlan">
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="encryptionPlan">
        /// This is the encryption plan for encrypting sensitive data. Currently supports public-key encryption.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCustomCredentialDTO(
            global::G.AuthenticationPlan6 authenticationPlan,
            global::G.CreateCustomCredentialDTOProvider provider,
            global::G.PublicKeyEncryptionPlan? encryptionPlan,
            string? name)
        {
            this.Provider = provider;
            this.AuthenticationPlan = authenticationPlan;
            this.EncryptionPlan = encryptionPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomCredentialDTO" /> class.
        /// </summary>
        public CreateCustomCredentialDTO()
        {
        }
    }
}