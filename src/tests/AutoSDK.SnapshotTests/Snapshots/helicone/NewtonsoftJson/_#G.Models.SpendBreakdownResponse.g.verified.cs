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
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelSpend> Models { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalCost", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeRange", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpendBreakdownResponseTimeRange TimeRange { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBreakdownResponse" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="totalCost"></param>
        /// <param name="timeRange"></param>
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