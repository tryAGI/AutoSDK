//HintName: G.Models.CreateBasicAuthSecretRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBasicAuthSecretRequestDto
    {
        /// <summary>
        /// The authentication type for the secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateBasicAuthSecretRequestDtoTypeJsonConverter))]
        public global::G.CreateBasicAuthSecretRequestDtoType Type { get; set; }

        /// <summary>
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </summary>
        /// <example>My Production API Key</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// The username for basic authentication.<br/>
        /// Example: myuser
        /// </summary>
        /// <example>myuser</example>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateBasicAuthSecretRequestDto" /> class.
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
        public CreateBasicAuthSecretRequestDto(
            string provider,
            string username,
            global::G.CreateBasicAuthSecretRequestDtoType type,
            string? password)
        {
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBasicAuthSecretRequestDto" /> class.
        /// </summary>
        public CreateBasicAuthSecretRequestDto()
        {
        }
    }
}