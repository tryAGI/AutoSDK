//HintName: G.Models.Pagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Pagination
    {
        /// <summary>
        /// 列表类型采集的最大条数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_row_count")]
        public string? MaxRowCount { get; set; }

        /// <summary>
        /// 当类型为 2 时，需要存储用户标记的下一页按钮
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_xpath")]
        public string? NextPageXpath { get; set; }

        /// <summary>
        /// 分页方式：0-不分页 1-滚动加载 2-下一页按钮
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        /// <param name="maxRowCount">
        /// 列表类型采集的最大条数
        /// </param>
        /// <param name="nextPageXpath">
        /// 当类型为 2 时，需要存储用户标记的下一页按钮
        /// </param>
        /// <param name="type">
        /// 分页方式：0-不分页 1-滚动加载 2-下一页按钮
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pagination(
            string? maxRowCount,
            string? nextPageXpath,
            string? type)
        {
            this.MaxRowCount = maxRowCount;
            this.NextPageXpath = nextPageXpath;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        public Pagination()
        {
        }
    }
}