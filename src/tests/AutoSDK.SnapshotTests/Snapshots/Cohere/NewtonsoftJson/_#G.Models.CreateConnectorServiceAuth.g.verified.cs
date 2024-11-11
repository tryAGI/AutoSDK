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
        /// <default>global::G.AuthTokenType.Noscheme</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthTokenType Type { get; set; } = default!;

        /// <summary>
        /// The token that will be used in the HTTP Authorization header when making requests to the connector. This field is encrypted at rest and never returned in a response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorServiceAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// The token_type specifies the way the token is passed in the Authorization header. Valid values are "bearer", "basic", and "noscheme".<br/>
        /// Default Value: noscheme
        /// </param>
        /// <param name="token">
        /// The token that will be used in the HTTP Authorization header when making requests to the connector. This field is encrypted at rest and never returned in a response.
        /// </param>
        public CreateConnectorServiceAuth(
            global::G.AuthTokenType type,
            string token)
        {
            this.Type = type;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorServiceAuth" /> class.
        /// </summary>
        public CreateConnectorServiceAuth()
        {
        }
    }
}