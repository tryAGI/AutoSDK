//HintName: G.Models.ChartHierarchicalItemInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChartHierarchicalItemInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children")]
        public global::System.Collections.Generic.IList<global::G.ChartItemInfo>? Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartHierarchicalItemInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="children"></param>
        public ChartHierarchicalItemInfo(
            string? title,
            global::System.Collections.Generic.IList<global::G.ChartItemInfo>? children)
        {
            this.Title = title;
            this.Children = children;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartHierarchicalItemInfo" /> class.
        /// </summary>
        public ChartHierarchicalItemInfo()
        {
        }
    }
}