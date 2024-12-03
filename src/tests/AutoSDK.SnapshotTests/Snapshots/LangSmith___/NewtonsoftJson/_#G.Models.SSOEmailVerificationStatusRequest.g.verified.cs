//HintName: G.Models.SSOEmailVerificationStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOEmailVerificationStatusRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("saml_provider_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SamlProviderId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOEmailVerificationStatusRequest" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="samlProviderId"></param>
        public SSOEmailVerificationStatusRequest(
            string email,
            global::System.Guid samlProviderId)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.SamlProviderId = samlProviderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOEmailVerificationStatusRequest" /> class.
        /// </summary>
        public SSOEmailVerificationStatusRequest()
        {
        }
    }
}