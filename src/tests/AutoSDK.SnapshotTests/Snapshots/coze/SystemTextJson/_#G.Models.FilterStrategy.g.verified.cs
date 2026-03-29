//HintName: G.Models.FilterStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterStrategy
    {
        /// <summary>
        /// 过滤框位置
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_box_position")]
        public global::System.Collections.Generic.IList<double>? FilterBoxPosition { get; set; }

        /// <summary>
        /// 过滤页数
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_page")]
        public global::System.Collections.Generic.IList<int>? FilterPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterStrategy" /> class.
        /// </summary>
        /// <param name="filterBoxPosition">
        /// 过滤框位置
        /// </param>
        /// <param name="filterPage">
        /// 过滤页数
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterStrategy(
            global::System.Collections.Generic.IList<double>? filterBoxPosition,
            global::System.Collections.Generic.IList<int>? filterPage)
        {
            this.FilterBoxPosition = filterBoxPosition;
            this.FilterPage = filterPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterStrategy" /> class.
        /// </summary>
        public FilterStrategy()
        {
        }
    }
}