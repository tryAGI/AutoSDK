//HintName: G.Models.ApiToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API tokens allow users to make requests to the Instill AI API.
    /// </summary>
    public sealed partial class ApiToken
    {
        /// <summary>
        /// When users trigger a pipeline which uses an API token, the token is<br/>
        /// updated with the current time. This field is used to track the last time<br/>
        /// the token was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUseTime")]
        public global::System.DateTime? LastUseTime { get; set; }

        /// <summary>
        /// The name of the token, define by its ID.<br/>
        /// - Format: `tokens/{token.id}`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// API token UUID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// API token resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.<br/>
        /// This field can reflect the client(s) that will use the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Creation time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Update time.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// An opaque access token representing the API token string.<br/>
        /// To validate the token, the recipient of the token needs to call the server<br/>
        /// that issued the token.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// State.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiTokenStateJsonConverter))]
        public global::G.ApiTokenState? State { get; set; }

        /// <summary>
        /// Token type. Value is fixed to "Bearer".<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenType")]
        public string? TokenType { get; set; }

        /// <summary>
        /// The time-to-live in seconds for this resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// Expiration time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expireTime")]
        public global::System.DateTime? ExpireTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}