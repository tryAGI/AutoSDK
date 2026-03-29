//HintName: G.Models.UpdateCustomCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomCredentialDTO
    {
        /// <summary>
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationPlan")]
        public global::G.AuthenticationPlan9? AuthenticationPlan { get; set; }

        /// <summary>
        /// This is the encryption plan for encrypting sensitive data. Currently supports public-key encryption.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encryptionPlan")]
        public global::G.PublicKeyEncryptionPlan? EncryptionPlan { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomCredentialDTO" /> class.
        /// </summary>
        /// <param name="authenticationPlan">
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </param>
        /// <param name="encryptionPlan">
        /// This is the encryption plan for encrypting sensitive data. Currently supports public-key encryption.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public UpdateCustomCredentialDTO(
            global::G.AuthenticationPlan9? authenticationPlan,
            global::G.PublicKeyEncryptionPlan? encryptionPlan,
            string? name)
        {
            this.AuthenticationPlan = authenticationPlan;
            this.EncryptionPlan = encryptionPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomCredentialDTO" /> class.
        /// </summary>
        public UpdateCustomCredentialDTO()
        {
        }
    }
}