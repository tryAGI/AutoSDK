//HintName: G.Models.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGoogleCalendarOAuth2AuthorizationCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// The authorization ID for the OAuth2 authorization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorizationId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AuthorizationId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateGoogleCalendarOAuth2AuthorizationCredentialDTO" /> class.
        /// </summary>
        /// <param name="authorizationId">
        /// The authorization ID for the OAuth2 authorization
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateGoogleCalendarOAuth2AuthorizationCredentialDTO(
            string authorizationId,
            global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.AuthorizationId = authorizationId ?? throw new global::System.ArgumentNullException(nameof(authorizationId));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGoogleCalendarOAuth2AuthorizationCredentialDTO" /> class.
        /// </summary>
        public CreateGoogleCalendarOAuth2AuthorizationCredentialDTO()
        {
        }
    }
}