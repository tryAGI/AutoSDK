//HintName: G.Models.ApiToken.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::Newtonsoft.Json.JsonProperty("lastUseTime")]
        public global::System.DateTime LastUseTime { get; set; }

        /// <summary>
        /// The name of the token, define by its ID.<br/>
        /// - Format: `tokens/{token.id}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// API token UUID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// API token resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.<br/>
        /// This field can reflect the client(s) that will use the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime CreateTime { get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime UpdateTime { get; set; }

        /// <summary>
        /// An opaque access token representing the API token string.<br/>
        /// To validate the token, the recipient of the token needs to call the server<br/>
        /// that issued the token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessToken")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// State.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.AllOf<global::G.ApiTokenState?>? State { get; set; }

        /// <summary>
        /// Token type. Value is fixed to "Bearer".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenType")]
        public string? TokenType { get; set; }

        /// <summary>
        /// The time-to-live in seconds for this resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl")]
        public int Ttl { get; set; }

        /// <summary>
        /// Expiration time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expireTime")]
        public global::System.DateTime ExpireTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}