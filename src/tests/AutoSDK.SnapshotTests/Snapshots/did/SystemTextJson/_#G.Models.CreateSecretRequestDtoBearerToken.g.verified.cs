//HintName: G.Models.CreateSecretRequestDtoBearerToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretRequestDtoBearerToken
    {
        /// <summary>
        /// The authentication type for the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateSecretRequestDtoBearerTokenTypeJsonConverter))]
        public global::G.CreateSecretRequestDtoBearerTokenType Type { get; set; }

        /// <summary>
        /// The provider/credential name chosen by the user<br/>
        /// Example: My Production API Key
        /// </summary>
        /// <example>My Production API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The bearer token for authentication.<br/>
        /// Example: eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestDtoBearerToken" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecretRequestDtoBearerToken(
            string provider,
            global::G.CreateSecretRequestDtoBearerTokenType type,
            string? token)
        {
            this.Type = type;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretRequestDtoBearerToken" /> class.
        /// </summary>
        public CreateSecretRequestDtoBearerToken()
        {
        }
    }
}