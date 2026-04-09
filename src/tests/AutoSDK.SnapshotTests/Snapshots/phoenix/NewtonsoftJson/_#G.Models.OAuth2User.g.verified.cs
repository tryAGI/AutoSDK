//HintName: G.Models.OAuth2User.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuth2User
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OAuth2UserRoleJsonConverter))]
        public global::G.OAuth2UserRole Role { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_picture_url")]
        public string? ProfilePictureUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2User" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="oauth2ClientId"></param>
        /// <param name="oauth2UserId"></param>
        /// <param name="profilePictureUrl"></param>
        /// <param name="authMethod"></param>
        public OAuth2User(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string email,
            string username,
            global::G.OAuth2UserRole role,
            string? oauth2ClientId,
            string? oauth2UserId,
            string? profilePictureUrl,
            string authMethod = "OAUTH2")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Role = role;
            this.AuthMethod = authMethod;
            this.Oauth2ClientId = oauth2ClientId;
            this.Oauth2UserId = oauth2UserId;
            this.ProfilePictureUrl = profilePictureUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2User" /> class.
        /// </summary>
        public OAuth2User()
        {
        }
    }
}