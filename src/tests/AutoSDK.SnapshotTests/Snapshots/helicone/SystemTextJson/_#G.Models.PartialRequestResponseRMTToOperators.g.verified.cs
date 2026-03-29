//HintName: G.Models.PartialRequestResponseRMTToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialRequestResponseRMTToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public global::G.PartialTextOperators? CountryCode { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public global::G.PartialNumberOperators? Latency { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::G.PartialNumberOperators? Cost { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::G.PartialTextOperators? Provider { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_to_first_token")]
        public global::G.PartialNumberOperators? TimeToFirstToken { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::G.PartialNumberOperators? Status { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_created_at")]
        public global::G.PartialTimestampOperatorsTyped? RequestCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_created_at")]
        public global::G.PartialTimestampOperatorsTyped? ResponseCreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::G.PartialTextOperators? Model { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::G.PartialTextOperators? UserId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public global::G.PartialTextOperators? OrganizationId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public global::G.PartialTextOperators? NodeId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public global::G.PartialTextOperators? JobId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threat")]
        public global::G.PartialBooleanOperators? Threat { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public global::G.PartialTextOperators? RequestId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public global::G.PartialNumberOperators? PromptTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public global::G.PartialNumberOperators? CompletionTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_read_tokens")]
        public global::G.PartialNumberOperators? PromptCacheReadTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_write_tokens")]
        public global::G.PartialNumberOperators? PromptCacheWriteTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public global::G.PartialNumberOperators? TotalTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        public global::G.PartialTextOperators? TargetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_key")]
        public global::G.PartialRequestResponseRMTToOperatorsPropertyKey? PropertyKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? SearchProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? Scores { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores_column")]
        public global::G.PartialTextOperators? ScoresColumn { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body")]
        public global::G.PartialTextOperators? RequestBody { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_body")]
        public global::G.PartialTextOperators? ResponseBody { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_enabled")]
        public global::G.PartialBooleanOperators? CacheEnabled { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_reference_id")]
        public global::G.PartialTextOperators? CacheReferenceId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached")]
        public global::G.PartialBooleanOperators? Cached { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        public global::G.PartialTextOperators? Assets { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helicone-score-feedback")]
        public global::G.PartialBooleanOperators? HeliconeScoreFeedback { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public global::G.PartialTextOperators? PromptId { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        public global::G.PartialTextOperators? PromptVersion { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_referrer")]
        public global::G.PartialTextOperators? RequestReferrer { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_passthrough_billing")]
        public global::G.PartialBooleanOperators? IsPassthroughBilling { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseRMTToOperators" /> class.
        /// </summary>
        /// <param name="countryCode">
        /// Make all properties in T optional
        /// </param>
        /// <param name="latency">
        /// Make all properties in T optional
        /// </param>
        /// <param name="cost">
        /// Make all properties in T optional
        /// </param>
        /// <param name="provider">
        /// Make all properties in T optional
        /// </param>
        /// <param name="timeToFirstToken">
        /// Make all properties in T optional
        /// </param>
        /// <param name="status">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="responseCreatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="model">
        /// Make all properties in T optional
        /// </param>
        /// <param name="userId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="organizationId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="nodeId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="jobId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="threat">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="completionTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptCacheReadTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptCacheWriteTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="totalTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="targetUrl">
        /// Make all properties in T optional
        /// </param>
        /// <param name="propertyKey"></param>
        /// <param name="properties"></param>
        /// <param name="searchProperties"></param>
        /// <param name="scores"></param>
        /// <param name="scoresColumn">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestBody">
        /// Make all properties in T optional
        /// </param>
        /// <param name="responseBody">
        /// Make all properties in T optional
        /// </param>
        /// <param name="cacheEnabled">
        /// Make all properties in T optional
        /// </param>
        /// <param name="cacheReferenceId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="cached">
        /// Make all properties in T optional
        /// </param>
        /// <param name="assets">
        /// Make all properties in T optional
        /// </param>
        /// <param name="heliconeScoreFeedback">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptId">
        /// Make all properties in T optional
        /// </param>
        /// <param name="promptVersion">
        /// Make all properties in T optional
        /// </param>
        /// <param name="requestReferrer">
        /// Make all properties in T optional
        /// </param>
        /// <param name="isPassthroughBilling">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialRequestResponseRMTToOperators(
            global::G.PartialTextOperators? countryCode,
            global::G.PartialNumberOperators? latency,
            global::G.PartialNumberOperators? cost,
            global::G.PartialTextOperators? provider,
            global::G.PartialNumberOperators? timeToFirstToken,
            global::G.PartialNumberOperators? status,
            global::G.PartialTimestampOperatorsTyped? requestCreatedAt,
            global::G.PartialTimestampOperatorsTyped? responseCreatedAt,
            global::G.PartialTextOperators? model,
            global::G.PartialTextOperators? userId,
            global::G.PartialTextOperators? organizationId,
            global::G.PartialTextOperators? nodeId,
            global::G.PartialTextOperators? jobId,
            global::G.PartialBooleanOperators? threat,
            global::G.PartialTextOperators? requestId,
            global::G.PartialNumberOperators? promptTokens,
            global::G.PartialNumberOperators? completionTokens,
            global::G.PartialNumberOperators? promptCacheReadTokens,
            global::G.PartialNumberOperators? promptCacheWriteTokens,
            global::G.PartialNumberOperators? totalTokens,
            global::G.PartialTextOperators? targetUrl,
            global::G.PartialRequestResponseRMTToOperatorsPropertyKey? propertyKey,
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? properties,
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? searchProperties,
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? scores,
            global::G.PartialTextOperators? scoresColumn,
            global::G.PartialTextOperators? requestBody,
            global::G.PartialTextOperators? responseBody,
            global::G.PartialBooleanOperators? cacheEnabled,
            global::G.PartialTextOperators? cacheReferenceId,
            global::G.PartialBooleanOperators? cached,
            global::G.PartialTextOperators? assets,
            global::G.PartialBooleanOperators? heliconeScoreFeedback,
            global::G.PartialTextOperators? promptId,
            global::G.PartialTextOperators? promptVersion,
            global::G.PartialTextOperators? requestReferrer,
            global::G.PartialBooleanOperators? isPassthroughBilling)
        {
            this.CountryCode = countryCode;
            this.Latency = latency;
            this.Cost = cost;
            this.Provider = provider;
            this.TimeToFirstToken = timeToFirstToken;
            this.Status = status;
            this.RequestCreatedAt = requestCreatedAt;
            this.ResponseCreatedAt = responseCreatedAt;
            this.Model = model;
            this.UserId = userId;
            this.OrganizationId = organizationId;
            this.NodeId = nodeId;
            this.JobId = jobId;
            this.Threat = threat;
            this.RequestId = requestId;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.PromptCacheReadTokens = promptCacheReadTokens;
            this.PromptCacheWriteTokens = promptCacheWriteTokens;
            this.TotalTokens = totalTokens;
            this.TargetUrl = targetUrl;
            this.PropertyKey = propertyKey;
            this.Properties = properties;
            this.SearchProperties = searchProperties;
            this.Scores = scores;
            this.ScoresColumn = scoresColumn;
            this.RequestBody = requestBody;
            this.ResponseBody = responseBody;
            this.CacheEnabled = cacheEnabled;
            this.CacheReferenceId = cacheReferenceId;
            this.Cached = cached;
            this.Assets = assets;
            this.HeliconeScoreFeedback = heliconeScoreFeedback;
            this.PromptId = promptId;
            this.PromptVersion = promptVersion;
            this.RequestReferrer = requestReferrer;
            this.IsPassthroughBilling = isPassthroughBilling;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseRMTToOperators" /> class.
        /// </summary>
        public PartialRequestResponseRMTToOperators()
        {
        }
    }
}