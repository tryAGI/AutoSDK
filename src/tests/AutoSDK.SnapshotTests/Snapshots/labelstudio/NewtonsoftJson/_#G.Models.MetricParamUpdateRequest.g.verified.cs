//HintName: G.Models.MetricParamUpdateRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricParamUpdateRequest
    {
        /// <summary>
        /// Agreement metric parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_params")]
        public object? AdditionalParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agreement_threshold")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? AgreementThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_additional_annotators_assignable")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxAdditionalAnnotatorsAssignable { get; set; }

        /// <summary>
        /// Agreement metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_name")]
        public string? MetricName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricParamUpdateRequest" /> class.
        /// </summary>
        /// <param name="additionalParams">
        /// Agreement metric parameters
        /// </param>
        /// <param name="metricName">
        /// Agreement metric
        /// </param>
        public MetricParamUpdateRequest(
            object? additionalParams,
            string? metricName)
        {
            this.AdditionalParams = additionalParams;
            this.MetricName = metricName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricParamUpdateRequest" /> class.
        /// </summary>
        public MetricParamUpdateRequest()
        {
        }
    }
}