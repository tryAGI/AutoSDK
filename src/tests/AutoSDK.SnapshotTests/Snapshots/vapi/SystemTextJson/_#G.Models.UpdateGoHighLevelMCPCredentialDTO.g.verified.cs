//HintName: G.Models.UpdateGoHighLevelMCPCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGoHighLevelMCPCredentialDTO
    {
        /// <summary>
        /// This is the authentication session for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationSession")]
        public global::G.Oauth2AuthenticationSession? AuthenticationSession { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateGoHighLevelMCPCredentialDTO" /> class.
        /// </summary>
        /// <param name="authenticationSession">
        /// This is the authentication session for the credential.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGoHighLevelMCPCredentialDTO(
            global::G.Oauth2AuthenticationSession? authenticationSession,
            string? name)
        {
            this.AuthenticationSession = authenticationSession;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGoHighLevelMCPCredentialDTO" /> class.
        /// </summary>
        public UpdateGoHighLevelMCPCredentialDTO()
        {
        }
    }
}