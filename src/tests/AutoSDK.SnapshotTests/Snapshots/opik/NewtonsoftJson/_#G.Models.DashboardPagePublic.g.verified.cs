//HintName: G.Models.DashboardPagePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DashboardPagePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.DashboardPublic>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public long? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sortable_by")]
        public global::System.Collections.Generic.IList<string>? SortableBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardPagePublic" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="total"></param>
        /// <param name="sortableBy"></param>
        public DashboardPagePublic(
            global::System.Collections.Generic.IList<global::G.DashboardPublic>? content,
            int? page,
            int? size,
            long? total,
            global::System.Collections.Generic.IList<string>? sortableBy)
        {
            this.Content = content;
            this.Page = page;
            this.Size = size;
            this.Total = total;
            this.SortableBy = sortableBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardPagePublic" /> class.
        /// </summary>
        public DashboardPagePublic()
        {
        }
    }
}