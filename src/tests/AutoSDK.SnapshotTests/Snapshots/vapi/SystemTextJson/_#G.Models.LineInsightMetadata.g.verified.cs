//HintName: G.Models.LineInsightMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LineInsightMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xAxisLabel")]
        public string? XAxisLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yAxisLabel")]
        public string? YAxisLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yAxisMin")]
        public double? YAxisMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yAxisMax")]
        public double? YAxisMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LineInsightMetadata" /> class.
        /// </summary>
        /// <param name="xAxisLabel"></param>
        /// <param name="yAxisLabel"></param>
        /// <param name="yAxisMin"></param>
        /// <param name="yAxisMax"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LineInsightMetadata(
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
        /// Initializes a new instance of the <see cref="LineInsightMetadata" /> class.
        /// </summary>
        public LineInsightMetadata()
        {
        }
    }
}