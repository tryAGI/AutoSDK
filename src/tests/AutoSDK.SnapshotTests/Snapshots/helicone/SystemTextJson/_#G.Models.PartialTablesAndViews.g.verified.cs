//HintName: G.Models.PartialTablesAndViews.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialTablesAndViews
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_metrics")]
        public global::G.PartialUserMetricsToOperators? UserMetrics { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_api_keys")]
        public global::G.PartialUserApiKeysTableToOperators? UserApiKeys { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.PartialResponseTableToOperators? Response { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::G.PartialRequestTableToOperators? Request { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public global::G.PartialFeedbackTableToOperators? Feedback { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties_table")]
        public global::G.PartialPropertiesTableToOperators? PropertiesTable { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_v2")]
        public global::G.PartialPromptToOperators? PromptV2 { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts_versions")]
        public global::G.PartialPromptVersionsToOperators? PromptsVersions { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment")]
        public global::G.PartialExperimentToOperators? Experiment { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_hypothesis_run")]
        public global::G.PartialExperimentHypothesisRunToOperator? ExperimentHypothesisRun { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_value")]
        public global::G.PartialScoreValueToOperator? ScoreValue { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_response_log")]
        public global::G.PartialRequestResponseLogToOperators? RequestResponseLog { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_response_rmt")]
        public global::G.PartialRequestResponseRMTToOperators? RequestResponseRmt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions_request_response_rmt")]
        public global::G.PartialSessionsRequestResponseRMTToOperators? SessionsRequestResponseRmt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_view")]
        public global::G.PartialUserViewToOperators? UsersView { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties_v3")]
        public global::G.PartialPropertiesV3ToOperators? PropertiesV3 { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_with_response_v1")]
        public global::G.PartialPropertyWithResponseV1ToOperators? PropertyWithResponseV1 { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public global::G.PartialJobToOperators? Job { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_node")]
        public global::G.PartialNodesToOperators? JobNode { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_metrics")]
        public global::G.PartialCacheMetricsTableToOperators? CacheMetrics { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit_log")]
        public global::G.PartialRateLimitTableToOperators? RateLimitLog { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_properties")]
        public global::G.PartialOrganizationPropertiesToOperators? OrganizationProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTablesAndViews" /> class.
        /// </summary>
        /// <param name="userMetrics">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userApiKeys">
        /// Make all properties in T optional
        /// </param>
        /// <param name="response">
        /// Make all properties in T optional
        /// </param>
        /// <param name="request">
        /// Make all properties in T optional
        /// </param>
        /// <param name="feedback">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertiesTable">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptV2">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptsVersions">
        /// Make all properties in T optional
        /// </param>
        /// <param name="experiment">
        /// Make all properties in T optional
        /// </param>
        /// <param name="experimentHypothesisRun">
        /// Make all properties in T optional
        /// </param>
        /// <param name="scoreValue">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestResponseLog">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="sessionsRequestResponseRmt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="usersView">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertiesV3">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertyWithResponseV1">
        /// Make all properties in T optional
        /// </param>
        /// <param name="job">
        /// Make all properties in T optional
        /// </param>
        /// <param name="jobNode">
        /// Make all properties in T optional
        /// </param>
        /// <param name="cacheMetrics">
        /// Make all properties in T optional
        /// </param>
        /// <param name="rateLimitLog">
        /// Make all properties in T optional
        /// </param>
        /// <param name="organizationProperties">
        /// Make all properties in T optional
        /// </param>
        /// <param name="properties"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialTablesAndViews(
            global::G.PartialUserMetricsToOperators? userMetrics,
            global::G.PartialUserApiKeysTableToOperators? userApiKeys,
            global::G.PartialResponseTableToOperators? response,
            global::G.PartialRequestTableToOperators? request,
            global::G.PartialFeedbackTableToOperators? feedback,
            global::G.PartialPropertiesTableToOperators? propertiesTable,
            global::G.PartialPromptToOperators? promptV2,
            global::G.PartialPromptVersionsToOperators? promptsVersions,
            global::G.PartialExperimentToOperators? experiment,
            global::G.PartialExperimentHypothesisRunToOperator? experimentHypothesisRun,
            global::G.PartialScoreValueToOperator? scoreValue,
            global::G.PartialRequestResponseLogToOperators? requestResponseLog,
            global::G.PartialRequestResponseRMTToOperators? requestResponseRmt,
            global::G.PartialSessionsRequestResponseRMTToOperators? sessionsRequestResponseRmt,
            global::G.PartialUserViewToOperators? usersView,
            global::G.PartialPropertiesV3ToOperators? propertiesV3,
            global::G.PartialPropertyWithResponseV1ToOperators? propertyWithResponseV1,
            global::G.PartialJobToOperators? job,
            global::G.PartialNodesToOperators? jobNode,
            global::G.PartialCacheMetricsTableToOperators? cacheMetrics,
            global::G.PartialRateLimitTableToOperators? rateLimitLog,
            global::G.PartialOrganizationPropertiesToOperators? organizationProperties,
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? properties,
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? values)
        {
            this.UserMetrics = userMetrics;
            this.UserApiKeys = userApiKeys;
            this.Response = response;
            this.Request = request;
            this.Feedback = feedback;
            this.PropertiesTable = propertiesTable;
            this.PromptV2 = promptV2;
            this.PromptsVersions = promptsVersions;
            this.Experiment = experiment;
            this.ExperimentHypothesisRun = experimentHypothesisRun;
            this.ScoreValue = scoreValue;
            this.RequestResponseLog = requestResponseLog;
            this.RequestResponseRmt = requestResponseRmt;
            this.SessionsRequestResponseRmt = sessionsRequestResponseRmt;
            this.UsersView = usersView;
            this.PropertiesV3 = propertiesV3;
            this.PropertyWithResponseV1 = propertyWithResponseV1;
            this.Job = job;
            this.JobNode = jobNode;
            this.CacheMetrics = cacheMetrics;
            this.RateLimitLog = rateLimitLog;
            this.OrganizationProperties = organizationProperties;
            this.Properties = properties;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTablesAndViews" /> class.
        /// </summary>
        public PartialTablesAndViews()
        {
        }
    }
}