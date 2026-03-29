//HintName: G.Models.ResearchTaskCompletedSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchTaskCompletedSource
    {
        /// <summary>
        /// Title or name of the source.<br/>
        /// Example: Latest AI Developments
        /// </summary>
        /// <example>Latest AI Developments</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the source.<br/>
        /// Example: https://example.com/ai-news
        /// </summary>
        /// <example>https://example.com/ai-news</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// URL to the source's favicon.<br/>
        /// Example: https://example.com/favicon.ico
        /// </summary>
        /// <example>https://example.com/favicon.ico</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTaskCompletedSource" /> class.
        /// </summary>
        /// <param name="title">
        /// Title or name of the source.<br/>
        /// Example: Latest AI Developments
        /// </param>
        /// <param name="url">
        /// URL of the source.<br/>
        /// Example: https://example.com/ai-news
        /// </param>
        /// <param name="favicon">
        /// URL to the source's favicon.<br/>
        /// Example: https://example.com/favicon.ico
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchTaskCompletedSource(
            string? title,
            string? url,
            string? favicon)
        {
            this.Title = title;
            this.Url = url;
            this.Favicon = favicon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTaskCompletedSource" /> class.
        /// </summary>
        public ResearchTaskCompletedSource()
        {
        }
    }
}