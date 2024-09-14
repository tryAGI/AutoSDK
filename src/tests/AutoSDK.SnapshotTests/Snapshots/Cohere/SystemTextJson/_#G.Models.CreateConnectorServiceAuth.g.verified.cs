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
        /// The token_type specifies the way the token is passed in the Authorization header. Valid values are "bearer", "basic", and "noscheme".<br/>
        /// Default Value: noscheme
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthTokenTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthTokenType Type { get; set; }

        /// <summary>
        /// The token that will be used in the HTTP Authorization header when making requests to the connector. This field is encrypted at rest and never returned in a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}