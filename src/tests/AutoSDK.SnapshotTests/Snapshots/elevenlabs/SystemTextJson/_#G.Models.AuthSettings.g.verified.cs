//HintName: G.Models.AuthSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"allowlist":[{"hostname":"https://example.com"}],"enable_auth":true,"shareable_token":"1234567890"}
    /// </summary>
    public sealed partial class AuthSettings
    {
        /// <summary>
        /// If set to true, starting a conversation with an agent will require a signed token<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_auth")]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// A list of hosts that are allowed to start conversations with the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowlist")]
        public global::System.Collections.Generic.IList<global::G.AllowlistItem>? Allowlist { get; set; }

        /// <summary>
        /// A shareable token that can be used to start a conversation with the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareable_token")]
        public string? ShareableToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSettings" /> class.
        /// </summary>
        /// <param name="enableAuth">
        /// If set to true, starting a conversation with an agent will require a signed token<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowlist">
        /// A list of hosts that are allowed to start conversations with the agent
        /// </param>
        /// <param name="shareableToken">
        /// A shareable token that can be used to start a conversation with the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthSettings(
            bool? enableAuth,
            global::System.Collections.Generic.IList<global::G.AllowlistItem>? allowlist,
            string? shareableToken)
        {
            this.EnableAuth = enableAuth;
            this.Allowlist = allowlist;
            this.ShareableToken = shareableToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSettings" /> class.
        /// </summary>
        public AuthSettings()
        {
        }
    }
}