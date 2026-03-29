//HintName: G.Models.OAuth2UserData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuth2UserData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OAuth2UserDataRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OAuth2UserDataRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"OAUTH2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        public string AuthMethod { get; set; } = "OAUTH2";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_client_id")]
        public string? Oauth2ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_user_id")]
        public string? Oauth2UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2UserData" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="oauth2ClientId"></param>
        /// <param name="oauth2UserId"></param>
        /// <param name="authMethod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2UserData(
            string email,
            string username,
            global::G.OAuth2UserDataRole role,
            string? oauth2ClientId,
            string? oauth2UserId,
            string authMethod = "OAUTH2")
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Role = role;
            this.AuthMethod = authMethod;
            this.Oauth2ClientId = oauth2ClientId;
            this.Oauth2UserId = oauth2UserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2UserData" /> class.
        /// </summary>
        public OAuth2UserData()
        {
        }
    }
}