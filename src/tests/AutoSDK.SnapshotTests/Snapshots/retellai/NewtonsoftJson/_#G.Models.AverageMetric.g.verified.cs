//HintName: G.Models.AverageMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AverageMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_averages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> TimeAverages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall_average", Required = global::Newtonsoft.Json.Required.Always)]
        public double OverallAverage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numerator")]
        public double? Numerator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("denominator")]
        public double? Denominator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AverageMetric" /> class.
        /// </summary>
        /// <param name="timeAverages"></param>
        /// <param name="overallAverage"></param>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        public AverageMetric(
            global::System.Collections.Generic.IList<double> timeAverages,
            double overallAverage,
            double? numerator,
            double? denominator)
        {
            this.TimeAverages = timeAverages ?? throw new global::System.ArgumentNullException(nameof(timeAverages));
            this.OverallAverage = overallAverage;
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AverageMetric" /> class.
        /// </summary>
        public AverageMetric()
        {
        }
    }
}