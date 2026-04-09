//HintName: G.Models.UpdateAuthSecretRequestDtoBasicAuthentication.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAuthSecretRequestDtoBasicAuthentication
    {
        /// <summary>
        /// The authentication type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateAuthSecretRequestDtoBasicAuthenticationTypeJsonConverter))]
        public global::G.UpdateAuthSecretRequestDtoBasicAuthenticationType? Type { get; set; }

        /// <summary>
        /// Custom header name for authentication.<br/>
        /// Example: X-Custom-Auth
        /// </summary>
        /// <example>X-Custom-Auth</example>
        [global::Newtonsoft.Json.JsonProperty("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// The provider/credential name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// The username for basic authentication.<br/>
        /// Example: myuser
        /// </summary>
        /// <example>myuser</example>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The password for basic authentication.<br/>
        /// Example: my-secure-password
        /// </summary>
        /// <example>my-secure-password</example>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthSecretRequestDtoBasicAuthentication" /> class.
        /// </summary>
        /// <param name="type">
        /// The authentication type.
        /// </param>
        /// <param name="headerName">
        /// Custom header name for authentication.<br/>
        /// Example: X-Custom-Auth
        /// </param>
        /// <param name="provider">
        /// The provider/credential name.
        /// </param>
        /// <param name="username">
        /// The username for basic authentication.<br/>
        /// Example: myuser
        /// </param>
        /// <param name="password">
        /// The password for basic authentication.<br/>
        /// Example: my-secure-password
        /// </param>
        public UpdateAuthSecretRequestDtoBasicAuthentication(
            global::G.UpdateAuthSecretRequestDtoBasicAuthenticationType? type,
            string? headerName,
            string? provider,
            string? username,
            string? password)
        {
            this.Type = type;
            this.HeaderName = headerName;
            this.Provider = provider;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthSecretRequestDtoBasicAuthentication" /> class.
        /// </summary>
        public UpdateAuthSecretRequestDtoBasicAuthentication()
        {
        }
    }
}