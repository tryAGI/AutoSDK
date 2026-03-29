//HintName: G.Models.UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO
    {
        /// <summary>
        /// The authorization ID for the OAuth2 authorization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationId")]
        public string? AuthorizationId { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO" /> class.
        /// </summary>
        /// <param name="authorizationId">
        /// The authorization ID for the OAuth2 authorization
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO(
            string? authorizationId,
            string? name)
        {
            this.AuthorizationId = authorizationId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO" /> class.
        /// </summary>
        public UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO()
        {
        }
    }
}