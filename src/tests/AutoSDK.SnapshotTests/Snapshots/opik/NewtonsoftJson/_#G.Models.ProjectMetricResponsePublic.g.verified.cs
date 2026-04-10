//HintName: G.Models.ProjectMetricResponsePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectMetricResponsePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProjectMetricResponsePublicMetricTypeJsonConverter))]
        public global::G.ProjectMetricResponsePublicMetricType? MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProjectMetricResponsePublicIntervalJsonConverter))]
        public global::G.ProjectMetricResponsePublicInterval? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.ResultsNumberPublic>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetricResponsePublic" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="metricType"></param>
        /// <param name="interval"></param>
        /// <param name="results"></param>
        public ProjectMetricResponsePublic(
            global::System.Guid? projectId,
            global::G.ProjectMetricResponsePublicMetricType? metricType,
            global::G.ProjectMetricResponsePublicInterval? interval,
            global::System.Collections.Generic.IList<global::G.ResultsNumberPublic>? results)
        {
            this.ProjectId = projectId;
            this.MetricType = metricType;
            this.Interval = interval;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetricResponsePublic" /> class.
        /// </summary>
        public ProjectMetricResponsePublic()
        {
        }
    }
}