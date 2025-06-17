//HintName: G.Models.CreateConnectorServiceAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorServiceAuth
    {
        /// <summary>
        /// The token that will be used in the HTTP Authorization header when making requests to the connector. This field is encrypted at rest and never returned in a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// The token_type specifies the way the token is passed in the Authorization header. Valid values are "bearer", "basic", and "noscheme".<br/>
        /// Default Value: noscheme
        /// </summary>
        /// <default>global::G.AuthTokenType.Noscheme</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthTokenTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthTokenType Type { get; set; } = global::G.AuthTokenType.Noscheme;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorServiceAuth" /> class.
        /// </summary>
        /// <param name="token">
        /// The token that will be used in the HTTP Authorization header when making requests to the connector. This field is encrypted at rest and never returned in a response.
        /// </param>
        /// <param name="type">
        /// The token_type specifies the way the token is passed in the Authorization header. Valid values are "bearer", "basic", and "noscheme".<br/>
        /// Default Value: noscheme
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectorServiceAuth(
            string token,
            global::G.AuthTokenType type)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorServiceAuth" /> class.
        /// </summary>
        public CreateConnectorServiceAuth()
        {
        }
    }
}