//HintName: G.Models.CreateBearerAuthSecretRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBearerAuthSecretRequestDto
    {
        /// <summary>
        /// The authentication type for the secret.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateBearerAuthSecretRequestDtoType Type { get; set; }

        /// <summary>
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </summary>
        /// <example>My Production API Key</example>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// The bearer token for authentication.<br/>
        /// Example: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBearerAuthSecretRequestDto" /> class.
        /// </summary>
        /// <param name="provider">
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </param>
        /// <param name="type">
        /// The authentication type for the secret.
        /// </param>
        /// <param name="token">
        /// The bearer token for authentication.<br/>
        /// Example: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
        /// </param>
        public CreateBearerAuthSecretRequestDto(
            string provider,
            global::G.CreateBearerAuthSecretRequestDtoType type,
            string? token)
        {
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBearerAuthSecretRequestDto" /> class.
        /// </summary>
        public CreateBearerAuthSecretRequestDto()
        {
        }
    }
}