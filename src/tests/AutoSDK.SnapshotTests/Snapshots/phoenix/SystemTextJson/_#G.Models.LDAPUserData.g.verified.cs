//HintName: G.Models.LDAPUserData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LDAPUserData
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LDAPUserDataRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LDAPUserDataRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"LDAP"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        public string AuthMethod { get; set; } = "LDAP";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPUserData" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="authMethod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LDAPUserData(
            string email,
            string username,
            global::G.LDAPUserDataRole role,
            string authMethod = "LDAP")
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Role = role;
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LDAPUserData" /> class.
        /// </summary>
        public LDAPUserData()
        {
        }
    }
}