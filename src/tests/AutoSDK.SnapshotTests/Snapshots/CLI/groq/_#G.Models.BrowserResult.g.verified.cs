//HintName: G.Models.BrowserResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BrowserResult
    {
        /// <summary>
        /// The URL of the browser window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The title of the browser window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The live view URL for the browser window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("live_view_url")]
        public string? LiveViewUrl { get; set; }

        /// <summary>
        /// The content of the browser result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserResult" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the browser window
        /// </param>
        /// <param name="title">
        /// The title of the browser window
        /// </param>
        /// <param name="liveViewUrl">
        /// The live view URL for the browser window
        /// </param>
        /// <param name="content">
        /// The content of the browser result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserResult(
            string url,
            string title,
            string? liveViewUrl,
            string? content)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.LiveViewUrl = liveViewUrl;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserResult" /> class.
        /// </summary>
        public BrowserResult()
        {
        }
    }
}