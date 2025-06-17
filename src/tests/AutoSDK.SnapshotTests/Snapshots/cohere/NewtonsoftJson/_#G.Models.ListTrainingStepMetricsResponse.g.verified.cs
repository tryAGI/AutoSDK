//HintName: G.Models.ListTrainingStepMetricsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to a request to list training-step metrics of a fine-tuned model.
    /// </summary>
    public sealed partial class ListTrainingStepMetricsResponse
    {
        /// <summary>
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The metrics for each step the evaluation was run on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_metrics")]
        public global::System.Collections.Generic.IList<global::G.TrainingStepMetrics>? StepMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingStepMetricsResponse" /> class.
        /// </summary>
        /// <param name="nextPageToken">
        /// Pagination token to retrieve the next page of results. If the value is "",<br/>
        /// it means no further results for the request.
        /// </param>
        /// <param name="stepMetrics">
        /// The metrics for each step the evaluation was run on.
        /// </param>
        public ListTrainingStepMetricsResponse(
            string? nextPageToken,
            global::System.Collections.Generic.IList<global::G.TrainingStepMetrics>? stepMetrics)
        {
            this.NextPageToken = nextPageToken;
            this.StepMetrics = stepMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingStepMetricsResponse" /> class.
        /// </summary>
        public ListTrainingStepMetricsResponse()
        {
        }
    }
}