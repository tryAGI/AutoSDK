//HintName: G.Models.CrawlContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlContent
    {
        /// <summary>
        /// 抓取到的完整信息
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Content { get; set; }

        /// <summary>
        /// 表头
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<string>? Headers { get; set; }

        /// <summary>
        /// 抓取信息的 XPATH
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marks")]
        public global::System.Collections.Generic.Dictionary<string, string>? Marks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.Pagination? Pagination { get; set; }

        /// <summary>
        /// 子页面抓取信息的 XPATH, key 对应于 marks 中的 key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_marks")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? SubMarks { get; set; }

        /// <summary>
        /// 存储标记的类型，类型是 Array&lt;'text' | 'image' | 'link'&gt;，与 headers 一一对应
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 抓取页面的 URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlContent" /> class.
        /// </summary>
        /// <param name="content">
        /// 抓取到的完整信息
        /// </param>
        /// <param name="headers">
        /// 表头
        /// </param>
        /// <param name="marks">
        /// 抓取信息的 XPATH
        /// </param>
        /// <param name="pagination"></param>
        /// <param name="subMarks">
        /// 子页面抓取信息的 XPATH, key 对应于 marks 中的 key
        /// </param>
        /// <param name="tags">
        /// 存储标记的类型，类型是 Array&lt;'text' | 'image' | 'link'&gt;，与 headers 一一对应
        /// </param>
        /// <param name="title">
        /// 标题
        /// </param>
        /// <param name="url">
        /// 抓取页面的 URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrawlContent(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? content,
            global::System.Collections.Generic.IList<string>? headers,
            global::System.Collections.Generic.Dictionary<string, string>? marks,
            global::G.Pagination? pagination,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? subMarks,
            global::System.Collections.Generic.IList<string>? tags,
            string? title,
            string? url)
        {
            this.Content = content;
            this.Headers = headers;
            this.Marks = marks;
            this.Pagination = pagination;
            this.SubMarks = subMarks;
            this.Tags = tags;
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlContent" /> class.
        /// </summary>
        public CrawlContent()
        {
        }
    }
}