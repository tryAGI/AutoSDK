//HintName: G.Models.ViewDataSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewDataSearch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::System.Collections.Generic.IList<object>? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public global::System.Collections.Generic.IList<object>? Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public global::System.Collections.Generic.IList<object>? Match { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::System.Collections.Generic.IList<object>? Sort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDataSearch" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="tag"></param>
        /// <param name="match"></param>
        /// <param name="sort"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewDataSearch(
            global::System.Collections.Generic.IList<object>? filter,
            global::System.Collections.Generic.IList<object>? tag,
            global::System.Collections.Generic.IList<object>? match,
            global::System.Collections.Generic.IList<object>? sort)
        {
            this.Filter = filter;
            this.Tag = tag;
            this.Match = match;
            this.Sort = sort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDataSearch" /> class.
        /// </summary>
        public ViewDataSearch()
        {
        }
    }
}