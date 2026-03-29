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
        [global::Newtonsoft.Json.JsonProperty("debuggerFullscreenUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string DebuggerFullscreenUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debuggerUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string DebuggerUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SessionLiveUrlsPage> Pages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wsUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string WsUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLiveUrls" /> class.
        /// </summary>
        /// <param name="debuggerFullscreenUrl"></param>
        /// <param name="debuggerUrl"></param>
        /// <param name="pages"></param>
        /// <param name="wsUrl"></param>
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