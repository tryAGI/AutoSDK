//HintName: G.Models.SessionLiveUrlsPage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionLiveUrlsPage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("faviconUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string FaviconUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debuggerUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string DebuggerUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("debuggerFullscreenUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string DebuggerFullscreenUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLiveUrlsPage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="faviconUrl"></param>
        /// <param name="title"></param>
        /// <param name="debuggerUrl"></param>
        /// <param name="debuggerFullscreenUrl"></param>
        public SessionLiveUrlsPage(
            string id,
            string url,
            string faviconUrl,
            string title,
            string debuggerUrl,
            string debuggerFullscreenUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.FaviconUrl = faviconUrl ?? throw new global::System.ArgumentNullException(nameof(faviconUrl));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.DebuggerUrl = debuggerUrl ?? throw new global::System.ArgumentNullException(nameof(debuggerUrl));
            this.DebuggerFullscreenUrl = debuggerFullscreenUrl ?? throw new global::System.ArgumentNullException(nameof(debuggerFullscreenUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLiveUrlsPage" /> class.
        /// </summary>
        public SessionLiveUrlsPage()
        {
        }
    }
}