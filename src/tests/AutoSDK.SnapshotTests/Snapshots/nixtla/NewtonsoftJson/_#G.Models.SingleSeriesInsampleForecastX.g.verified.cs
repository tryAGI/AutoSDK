//HintName: G.Models.SingleSeriesInsampleForecastX.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The exogenous variables provided as a dictionary. Each key is a timestamp (string format: YYYY-MM-DD) and the corresponding value is a list of exogenous variable values at that time point. For example: {"2021-01-01": [0.1], "2021-01-02": [0.4]}. This should also include forecasting horizon (fh) additional timestamps to calculate the future values.
    /// </summary>
    public sealed partial class SingleSeriesInsampleForecastX
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}