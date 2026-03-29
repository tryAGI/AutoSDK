//HintName: G.Models.WebSearchDataSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchDataSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_content")]
        public string? RawContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchDataSource" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="rawContent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchDataSource(
            string? url,
            string? rawContent)
        {
            this.Url = url;
            this.RawContent = rawContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchDataSource" /> class.
        /// </summary>
        public WebSearchDataSource()
        {
        }
    }
}