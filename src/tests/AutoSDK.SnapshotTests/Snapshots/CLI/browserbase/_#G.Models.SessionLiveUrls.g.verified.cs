//HintName: G.Models.SessionLiveUrls.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionLiveUrls
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debuggerFullscreenUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DebuggerFullscreenUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debuggerUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DebuggerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SessionLiveUrlsPage> Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wsUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLiveUrls" /> class.
        /// </summary>
        /// <param name="debuggerFullscreenUrl"></param>
        /// <param name="debuggerUrl"></param>
        /// <param name="pages"></param>
        /// <param name="wsUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionLiveUrls(
            string debuggerFullscreenUrl,
            string debuggerUrl,
            global::System.Collections.Generic.IList<global::G.SessionLiveUrlsPage> pages,
            string wsUrl)
        {
            this.DebuggerFullscreenUrl = debuggerFullscreenUrl ?? throw new global::System.ArgumentNullException(nameof(debuggerFullscreenUrl));
            this.DebuggerUrl = debuggerUrl ?? throw new global::System.ArgumentNullException(nameof(debuggerUrl));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.WsUrl = wsUrl ?? throw new global::System.ArgumentNullException(nameof(wsUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLiveUrls" /> class.
        /// </summary>
        public SessionLiveUrls()
        {
        }
    }
}