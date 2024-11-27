//HintName: G.Models.ChartHierarchicalExportInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChartHierarchicalExportInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parentItems")]
        public global::System.Collections.Generic.IList<global::G.ChartHierarchicalItemInfo>? ParentItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartHierarchicalExportInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="parentItems"></param>
        public ChartHierarchicalExportInfo(
            string? title,
            global::System.Collections.Generic.IList<global::G.ChartHierarchicalItemInfo>? parentItems)
        {
            this.Title = title;
            this.ParentItems = parentItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartHierarchicalExportInfo" /> class.
        /// </summary>
        public ChartHierarchicalExportInfo()
        {
        }
    }
}