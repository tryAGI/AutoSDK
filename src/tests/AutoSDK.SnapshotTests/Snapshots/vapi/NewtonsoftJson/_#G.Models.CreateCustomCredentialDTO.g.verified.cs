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
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateCustomCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationPlan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthenticationPlan6 AuthenticationPlan { get; set; } = default!;

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