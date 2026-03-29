//HintName: G.Models.TraceWithFullDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceWithFullDetails
    {
        /// <summary>
        /// Path of trace in Langfuse UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("htmlPath", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlPath { get; set; } = default!;

        /// <summary>
        /// Latency of trace in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Cost of trace in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalCost")]
        public double? TotalCost { get; set; }

        /// <summary>
        /// List of observations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("observations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ObservationsView> Observations { get; set; } = default!;

        /// <summary>
        /// List of scores
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ScoreV1> Scores { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWithFullDetails" /> class.
        /// </summary>
        /// <param name="htmlPath">
        /// Path of trace in Langfuse UI
        /// </param>
        /// <param name="observations">
        /// List of observations
        /// </param>
        /// <param name="scores">
        /// List of scores
        /// </param>
        /// <param name="latency">
        /// Latency of trace in seconds
        /// </param>
        /// <param name="totalCost">
        /// Cost of trace in USD
        /// </param>
        public TraceWithFullDetails(
            string htmlPath,
            global::System.Collections.Generic.IList<global::G.ObservationsView> observations,
            global::System.Collections.Generic.IList<global::G.ScoreV1> scores,
            double? latency,
            double? totalCost)
        {
            this.HtmlPath = htmlPath ?? throw new global::System.ArgumentNullException(nameof(htmlPath));
            this.Latency = latency;
            this.TotalCost = totalCost;
            this.Observations = observations ?? throw new global::System.ArgumentNullException(nameof(observations));
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWithFullDetails" /> class.
        /// </summary>
        public TraceWithFullDetails()
        {
        }
    }
}