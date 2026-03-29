//HintName: G.Models.UsageMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API boundary representation of a usage metric.
    /// </summary>
    public sealed partial class UsageMetric
    {
        /// <summary>
        /// The system-generated UUID for the metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The ID of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The event type that is emitted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsageMetricEventType EventType { get; set; } = default!;

        /// <summary>
        /// The project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// The organization ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// The unit measurement associated with the event type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public int Value { get; set; } = default!;

        /// <summary>
        /// Properties associated with the metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// The day the metric was emitted [UTC], in the format 'YYYY-MM-DD'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("day", Required = global::Newtonsoft.Json.Required.Always)]
        public string Day { get; set; } = default!;

        /// <summary>
        /// The source job identifier, i.e. job_id or file_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_aggregation_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventAggregationKey { get; set; } = default!;

        /// <summary>
        /// The source job aggregation type, i.e. pdf
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_aggregation_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventAggregationType { get; set; } = default!;

        /// <summary>
        /// The number of credits consumed by this metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetric" /> class.
        /// </summary>
        /// <param name="id">
        /// The system-generated UUID for the metric
        /// </param>
        /// <param name="userId">
        /// The ID of the user
        /// </param>
        /// <param name="eventType">
        /// The event type that is emitted
        /// </param>
        /// <param name="projectId">
        /// The project ID
        /// </param>
        /// <param name="organizationId">
        /// The organization ID
        /// </param>
        /// <param name="value">
        /// The unit measurement associated with the event type
        /// </param>
        /// <param name="day">
        /// The day the metric was emitted [UTC], in the format 'YYYY-MM-DD'
        /// </param>
        /// <param name="eventAggregationKey">
        /// The source job identifier, i.e. job_id or file_id
        /// </param>
        /// <param name="eventAggregationType">
        /// The source job aggregation type, i.e. pdf
        /// </param>
        /// <param name="properties">
        /// Properties associated with the metric
        /// </param>
        /// <param name="credits">
        /// The number of credits consumed by this metric
        /// </param>
        public UsageMetric(
            global::System.Guid id,
            string userId,
            global::G.UsageMetricEventType eventType,
            string projectId,
            string organizationId,
            int value,
            string day,
            string eventAggregationKey,
            string eventAggregationType,
            object? properties,
            double? credits)
        {
            this.Id = id;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.EventType = eventType;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Value = value;
            this.Properties = properties;
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.EventAggregationKey = eventAggregationKey ?? throw new global::System.ArgumentNullException(nameof(eventAggregationKey));
            this.EventAggregationType = eventAggregationType ?? throw new global::System.ArgumentNullException(nameof(eventAggregationType));
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetric" /> class.
        /// </summary>
        public UsageMetric()
        {
        }
    }
}