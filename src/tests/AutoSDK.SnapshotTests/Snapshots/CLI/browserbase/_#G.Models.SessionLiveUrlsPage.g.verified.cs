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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faviconUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FaviconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debuggerUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DebuggerUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debuggerFullscreenUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DebuggerFullscreenUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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