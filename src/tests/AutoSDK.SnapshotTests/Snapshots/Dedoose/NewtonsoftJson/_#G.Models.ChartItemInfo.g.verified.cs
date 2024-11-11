//HintName: G.Models.ChartItemInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChartItemInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartItemInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="value"></param>
        public ChartItemInfo(
            string? title,
            double? value)
        {
            this.Title = title;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartItemInfo" /> class.
        /// </summary>
        public ChartItemInfo()
        {
        }
    }
}