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
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OAuth2UserDataRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"OAUTH2"</default>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        public string AuthMethod { get; set; } = "OAUTH2";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oauth2_client_id")]
        public string? Oauth2ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oauth2_user_id")]
        public string? Oauth2UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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