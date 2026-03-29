//HintName: G.Models.LocalUserData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalUserData
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LocalUserDataRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LocalUserDataRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"LOCAL"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        public string AuthMethod { get; set; } = "LOCAL";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalUserData" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="password"></param>
        /// <param name="authMethod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalUserData(
            string email,
            string username,
            global::G.LocalUserDataRole role,
            string? password,
            string authMethod = "LOCAL")
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Role = role;
            this.AuthMethod = authMethod;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalUserData" /> class.
        /// </summary>
        public LocalUserData()
        {
        }
    }
}