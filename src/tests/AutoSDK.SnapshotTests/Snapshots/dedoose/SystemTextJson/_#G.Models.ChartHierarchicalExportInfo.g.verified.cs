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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentItems")]
        public global::System.Collections.Generic.IList<global::G.ChartHierarchicalItemInfo>? ParentItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartHierarchicalExportInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="parentItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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