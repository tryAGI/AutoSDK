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
        [global::Newtonsoft.Json.JsonProperty("toolkit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Toolkit { get; set; } = default!;

        /// <summary>
        /// URL where users will be redirected after completing auth<br/>
        /// Example: https://myapp.com/callback
        /// </summary>
        /// <example>https://myapp.com/callback</example>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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