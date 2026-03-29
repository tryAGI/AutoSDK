//HintName: G.Models.SessionsGetResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionsGetResponse2
    {
        /// <summary>
        /// WebSocket URL to connect to the Session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectUrl")]
        public string? ConnectUrl { get; set; }

        /// <summary>
        /// HTTP URL to connect to the Session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seleniumRemoteUrl")]
        public string? SeleniumRemoteUrl { get; set; }

        /// <summary>
        /// Signing key to use when connecting to the Session via HTTP.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signingKey")]
        public string? SigningKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsGetResponse2" /> class.
        /// </summary>
        /// <param name="connectUrl">
        /// WebSocket URL to connect to the Session.
        /// </param>
        /// <param name="seleniumRemoteUrl">
        /// HTTP URL to connect to the Session.
        /// </param>
        /// <param name="signingKey">
        /// Signing key to use when connecting to the Session via HTTP.
        /// </param>
        public SessionsGetResponse2(
            string? connectUrl,
            string? seleniumRemoteUrl,
            string? signingKey)
        {
            this.ConnectUrl = connectUrl;
            this.SeleniumRemoteUrl = seleniumRemoteUrl;
            this.SigningKey = signingKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsGetResponse2" /> class.
        /// </summary>
        public SessionsGetResponse2()
        {
        }
    }
}