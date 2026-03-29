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
        [global::System.Text.Json.Serialization.JsonPropertyName("connectUrl")]
        public string? ConnectUrl { get; set; }

        /// <summary>
        /// HTTP URL to connect to the Session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seleniumRemoteUrl")]
        public string? SeleniumRemoteUrl { get; set; }

        /// <summary>
        /// Signing key to use when connecting to the Session via HTTP.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signingKey")]
        public string? SigningKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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