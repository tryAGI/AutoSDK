//HintName: G.Models.BarInsightMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BarInsightMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("xAxisLabel")]
        public string? XAxisLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("yAxisLabel")]
        public string? YAxisLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("yAxisMin")]
        public double? YAxisMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("yAxisMax")]
        public double? YAxisMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BarInsightMetadata" /> class.
        /// </summary>
        /// <param name="xAxisLabel"></param>
        /// <param name="yAxisLabel"></param>
        /// <param name="yAxisMin"></param>
        /// <param name="yAxisMax"></param>
        /// <param name="name"></param>
        public BarInsightMetadata(
            string? xAxisLabel,
            string? yAxisLabel,
            double? yAxisMin,
            double? yAxisMax,
            string? name)
        {
            this.XAxisLabel = xAxisLabel;
            this.YAxisLabel = yAxisLabel;
            this.YAxisMin = yAxisMin;
            this.YAxisMax = yAxisMax;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarInsightMetadata" /> class.
        /// </summary>
        public BarInsightMetadata()
        {
        }
    }
}