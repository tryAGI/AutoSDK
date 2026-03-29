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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The ID of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The event type that is emitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageMetricEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UsageMetricEventType EventType { get; set; }

        /// <summary>
        /// The project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The organization ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// The unit measurement associated with the event type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Properties associated with the metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// The day the metric was emitted [UTC], in the format 'YYYY-MM-DD'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// The source job identifier, i.e. job_id or file_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_aggregation_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventAggregationKey { get; set; }

        /// <summary>
        /// The source job aggregation type, i.e. pdf
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_aggregation_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventAggregationType { get; set; }

        /// <summary>
        /// The number of credits consumed by this metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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