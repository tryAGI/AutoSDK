//HintName: G.Models.MetricParam.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricParam
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement_threshold")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string AgreementThreshold { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed")]
        public string Allowed { get; set; } = default!;

        /// <summary>
        /// Maximum number of additional annotators that can be assigned to a low agreement task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_additional_annotators_assignable")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxAdditionalAnnotatorsAssignable { get; set; }

        /// <summary>
        /// Evaluation metric chosen for this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_name")]
        public string? MetricName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_params")]
        public object? MetricParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricParam" /> class.
        /// </summary>
        /// <param name="metricName">
        /// Evaluation metric chosen for this project
        /// </param>
        /// <param name="metricParams"></param>
        /// <param name="allowed">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricParam(
            string? metricName,
            object? metricParams,
            string allowed = default!)
        {
            this.Allowed = allowed;
            this.MetricName = metricName;
            this.MetricParams = metricParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricParam" /> class.
        /// </summary>
        public MetricParam()
        {
        }
    }
}