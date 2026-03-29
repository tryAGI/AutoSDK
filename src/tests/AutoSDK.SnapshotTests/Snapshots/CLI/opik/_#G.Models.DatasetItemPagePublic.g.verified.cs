//HintName: G.Models.DatasetItemPagePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItemPagePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::G.DatasetItemPublic>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public long? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<global::G.ColumnPublic>? Columns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortableBy")]
        public global::System.Collections.Generic.IList<string>? SortableBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemPagePublic" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        /// <param name="columns"></param>
        /// <param name="sortableBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemPagePublic(
            global::System.Collections.Generic.IList<global::G.DatasetItemPublic>? content,
            int? page,
            int? size,
            long? total,
            global::System.Collections.Generic.IList<global::G.ColumnPublic>? columns,
            global::System.Collections.Generic.IList<string>? sortableBy)
        {
            this.Content = content;
            this.Page = page;
            this.Size = size;
            this.Total = total;
            this.Columns = columns;
            this.SortableBy = sortableBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemPagePublic" /> class.
        /// </summary>
        public DatasetItemPagePublic()
        {
        }
    }
}