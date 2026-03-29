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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProviderJsonConverter))]
        public global::G.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// The authorization ID for the OAuth2 authorization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorizationId { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateGoogleCalendarOAuth2AuthorizationCredentialDTO" /> class.
        /// </summary>
        /// <param name="authorizationId">
        /// The authorization ID for the OAuth2 authorization
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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