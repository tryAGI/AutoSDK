//HintName: G.Models.ChartExportInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChartExportInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seriesData")]
        public global::System.Collections.Generic.IList<global::G.ChartSeriesInfo>? SeriesData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartExportInfo" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="seriesData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartExportInfo(
            string? title,
            global::System.Collections.Generic.IList<global::G.ChartSeriesInfo>? seriesData)
        {
            this.Title = title;
            this.SeriesData = seriesData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartExportInfo" /> class.
        /// </summary>
        public ChartExportInfo()
        {
        }
    }
}