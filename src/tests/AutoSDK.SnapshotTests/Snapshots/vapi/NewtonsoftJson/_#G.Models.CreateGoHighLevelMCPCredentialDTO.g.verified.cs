//HintName: G.Models.CreateGoHighLevelMCPCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGoHighLevelMCPCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateGoHighLevelMCPCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the authentication session for the credential.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationSession", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Oauth2AuthenticationSession AuthenticationSession { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateGoHighLevelMCPCredentialDTO" /> class.
        /// </summary>
        /// <param name="authenticationSession">
        /// This is the authentication session for the credential.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateGoHighLevelMCPCredentialDTO(
            global::G.Oauth2AuthenticationSession authenticationSession,
            global::G.CreateGoHighLevelMCPCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.AuthenticationSession = authenticationSession ?? throw new global::System.ArgumentNullException(nameof(authenticationSession));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGoHighLevelMCPCredentialDTO" /> class.
        /// </summary>
        public CreateGoHighLevelMCPCredentialDTO()
        {
        }
    }
}