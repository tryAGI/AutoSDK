//HintName: G.Models.SpendBreakdownResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendBreakdownResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelSpend> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpendBreakdownResponseTimeRange TimeRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBreakdownResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="totalCost"></param>
        /// <param name="timeRange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendBreakdownResponse(
            global::System.Collections.Generic.IList<global::G.ModelSpend> models,
            double totalCost,
            global::G.SpendBreakdownResponseTimeRange timeRange)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.TotalCost = totalCost;
            this.TimeRange = timeRange ?? throw new global::System.ArgumentNullException(nameof(timeRange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBreakdownResponse" /> class.
        /// </summary>
        public SpendBreakdownResponse()
        {
        }
    }
}