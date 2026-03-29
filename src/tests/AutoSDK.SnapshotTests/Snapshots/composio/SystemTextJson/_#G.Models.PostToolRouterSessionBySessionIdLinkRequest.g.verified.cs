//HintName: G.Models.PostToolRouterSessionBySessionIdLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdLinkRequest
    {
        /// <summary>
        /// The unique slug identifier of the toolkit to connect<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Toolkit { get; set; }

        /// <summary>
        /// URL where users will be redirected after completing auth<br/>
        /// Example: https://myapp.com/callback
        /// </summary>
        /// <example>https://myapp.com/callback</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkRequest" /> class.
        /// </summary>
        /// <param name="toolkit">
        /// The unique slug identifier of the toolkit to connect<br/>
        /// Example: github
        /// </param>
        /// <param name="callbackUrl">
        /// URL where users will be redirected after completing auth<br/>
        /// Example: https://myapp.com/callback
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdLinkRequest(
            string toolkit,
            string? callbackUrl)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdLinkRequest()
        {
        }
    }
}