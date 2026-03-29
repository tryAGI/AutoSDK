//HintName: G.Models.ModelStatsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelStatsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelStatsTimeSeriesDataPoint> TimeSeries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatsResponse" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="totalTokens"></param>
        /// <param name="timeSeries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelStatsResponse(
            string model,
            double totalTokens,
            global::System.Collections.Generic.IList<global::G.ModelStatsTimeSeriesDataPoint> timeSeries)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TotalTokens = totalTokens;
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatsResponse" /> class.
        /// </summary>
        public ModelStatsResponse()
        {
        }
    }
}