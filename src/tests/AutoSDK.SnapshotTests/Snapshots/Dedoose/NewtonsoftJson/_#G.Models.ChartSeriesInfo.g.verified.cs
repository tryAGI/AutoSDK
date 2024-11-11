//HintName: G.Models.ChartSeriesInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChartSeriesInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.ChartItemInfo>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeriesInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="items"></param>
        public ChartSeriesInfo(
            string? title,
            global::System.Collections.Generic.IList<global::G.ChartItemInfo>? items)
        {
            this.Title = title;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeriesInfo" /> class.
        /// </summary>
        public ChartSeriesInfo()
        {
        }
    }
}