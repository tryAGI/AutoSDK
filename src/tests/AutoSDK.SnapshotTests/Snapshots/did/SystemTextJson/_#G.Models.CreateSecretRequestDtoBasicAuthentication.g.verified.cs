//HintName: G.Models.CreateSecretRequestDtoBasicAuthentication.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretRequestDtoBasicAuthentication
    {
        /// <summary>
        /// The authentication type for the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateSecretRequestDtoBasicAuthenticationTypeJsonConverter))]
        public global::G.CreateSecretRequestDtoBasicAuthenticationType Type { get; set; }

        /// <summary>
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </summary>
        /// <example>My Production API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The username for basic authentication.<br/>
        /// Example: myuser
        /// </summary>
        /// <example>myuser</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// The password for basic authentication.<br/>
        /// Example: my-secure-password
        /// </summary>
        /// <example>my-secure-password</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestDtoBasicAuthentication" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </param>
        /// <param name="username">
        /// The username for basic authentication.<br/>
        /// Example: myuser
        /// </param>
        /// <param name="type">
        /// The authentication type for the secret.
        /// </param>
        /// <param name="password">
        /// The password for basic authentication.<br/>
        /// Example: my-secure-password
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecretRequestDtoBasicAuthentication(
            string provider,
            string username,
            global::G.CreateSecretRequestDtoBasicAuthenticationType type,
            string? password)
        {
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestDtoBasicAuthentication" /> class.
        /// </summary>
        public CreateSecretRequestDtoBasicAuthentication()
        {
        }
    }
}