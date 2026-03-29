//HintName: G.Models.WebRTCTURNConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebRTCTURNConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Credential { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCTURNConfig" /> class.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="username"></param>
        /// <param name="credential"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebRTCTURNConfig(
            string urls,
            string username,
            string credential)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Credential = credential ?? throw new global::System.ArgumentNullException(nameof(credential));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCTURNConfig" /> class.
        /// </summary>
        public WebRTCTURNConfig()
        {
        }
    }
}