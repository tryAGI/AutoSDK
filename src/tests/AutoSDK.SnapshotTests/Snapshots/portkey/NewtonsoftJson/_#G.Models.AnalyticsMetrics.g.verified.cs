//HintName: G.Models.AnalyticsMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Analytics metrics extracted from the log entry
    /// </summary>
    public sealed partial class AnalyticsMetrics
    {
        /// <summary>
        /// Unique identifier for the log entry<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Organization identifier<br/>
        /// Example: org-123
        /// </summary>
        /// <example>org-123</example>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public string? OrganisationId { get; set; }

        /// <summary>
        /// Organization name<br/>
        /// Example: Acme Corp
        /// </summary>
        /// <example>Acme Corp</example>
        [global::Newtonsoft.Json.JsonProperty("organisation_name")]
        public string? OrganisationName { get; set; }

        /// <summary>
        /// Prompt identifier<br/>
        /// Example: prompt-789
        /// </summary>
        /// <example>prompt-789</example>
        [global::Newtonsoft.Json.JsonProperty("prompt_id")]
        public string? PromptId { get; set; }

        /// <summary>
        /// Prompt version identifier<br/>
        /// Example: prompt-v1
        /// </summary>
        /// <example>prompt-v1</example>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_id")]
        public string? PromptVersionId { get; set; }

        /// <summary>
        /// Configuration identifier<br/>
        /// Example: config-123
        /// </summary>
        /// <example>config-123</example>
        [global::Newtonsoft.Json.JsonProperty("config_id")]
        public string? ConfigId { get; set; }

        /// <summary>
        /// Timestamp when the log was created<br/>
        /// Example: 2024-01-15T10:30:00.000
        /// </summary>
        /// <example>2024-01-15T10:30:00.000</example>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Whether the request was successful (status code 200-299)<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_success")]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// AI provider organization (e.g., openai, anthropic)<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::Newtonsoft.Json.JsonProperty("ai_org")]
        public string? AiOrg { get; set; }

        /// <summary>
        /// AI model used<br/>
        /// Example: gpt-4o
        /// </summary>
        /// <example>gpt-4o</example>
        [global::Newtonsoft.Json.JsonProperty("ai_model")]
        public string? AiModel { get; set; }

        /// <summary>
        /// Request token units<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("req_units")]
        public float? ReqUnits { get; set; }

        /// <summary>
        /// Response token units<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("res_units")]
        public float? ResUnits { get; set; }

        /// <summary>
        /// Total token units (req_units + res_units)<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::Newtonsoft.Json.JsonProperty("total_units")]
        public float? TotalUnits { get; set; }

        /// <summary>
        /// Cost in the specified currency<br/>
        /// Example: 0.002
        /// </summary>
        /// <example>0.002</example>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public float? Cost { get; set; }

        /// <summary>
        /// Currency code for the cost<br/>
        /// Default Value: USD<br/>
        /// Example: USD
        /// </summary>
        /// <example>USD</example>
        [global::Newtonsoft.Json.JsonProperty("cost_currency")]
        public string? CostCurrency { get; set; }

        /// <summary>
        /// Sanitized request URL<br/>
        /// Example: https://api.openai.com/v1/chat/completions
        /// </summary>
        /// <example>https://api.openai.com/v1/chat/completions</example>
        [global::Newtonsoft.Json.JsonProperty("request_url")]
        public string? RequestUrl { get; set; }

        /// <summary>
        /// HTTP method<br/>
        /// Example: POST
        /// </summary>
        /// <example>POST</example>
        [global::Newtonsoft.Json.JsonProperty("request_method")]
        public string? RequestMethod { get; set; }

        /// <summary>
        /// HTTP response status code<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::Newtonsoft.Json.JsonProperty("response_status_code")]
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// Response time in milliseconds<br/>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::Newtonsoft.Json.JsonProperty("response_time")]
        public long? ResponseTime { get; set; }

        /// <summary>
        /// Whether this was a proxy call<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_proxy_call")]
        public bool? IsProxyCall { get; set; }

        /// <summary>
        /// Cache status (e.g., HIT, MISS, DISABLED, SEMANTIC HIT)<br/>
        /// Example: MISS
        /// </summary>
        /// <example>MISS</example>
        [global::Newtonsoft.Json.JsonProperty("cache_status")]
        public string? CacheStatus { get; set; }

        /// <summary>
        /// Type of cache used<br/>
        /// Example: semantic
        /// </summary>
        /// <example>semantic</example>
        [global::Newtonsoft.Json.JsonProperty("cache_type")]
        public string? CacheType { get; set; }

        /// <summary>
        /// Whether streaming was enabled (1) or not (0)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("stream_mode")]
        public int? StreamMode { get; set; }

        /// <summary>
        /// Number of successful retries<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("retry_success_count")]
        public int? RetrySuccessCount { get; set; }

        /// <summary>
        /// Distributed tracing trace ID<br/>
        /// Example: trace-123
        /// </summary>
        /// <example>trace-123</example>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Distributed tracing span ID<br/>
        /// Example: span-456
        /// </summary>
        /// <example>span-456</example>
        [global::Newtonsoft.Json.JsonProperty("span_id")]
        public string? SpanId { get; set; }

        /// <summary>
        /// Name of the span<br/>
        /// Example: llm
        /// </summary>
        /// <example>llm</example>
        [global::Newtonsoft.Json.JsonProperty("span_name")]
        public string? SpanName { get; set; }

        /// <summary>
        /// Parent span ID in distributed tracing<br/>
        /// Example: span-789
        /// </summary>
        /// <example>span-789</example>
        [global::Newtonsoft.Json.JsonProperty("parent_span_id")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// Request mode (e.g., single, loadbalance, fallback)<br/>
        /// Example: single
        /// </summary>
        /// <example>single</example>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Virtual key identifier<br/>
        /// Example: vk-123
        /// </summary>
        /// <example>vk-123</example>
        [global::Newtonsoft.Json.JsonProperty("virtual_key")]
        public string? VirtualKey { get; set; }

        /// <summary>
        /// Source of the request (e.g., rubeus, proxy)<br/>
        /// Example: rubeus
        /// </summary>
        /// <example>rubeus</example>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Runtime environment<br/>
        /// Example: node
        /// </summary>
        /// <example>node</example>
        [global::Newtonsoft.Json.JsonProperty("runtime")]
        public string? Runtime { get; set; }

        /// <summary>
        /// Runtime version<br/>
        /// Example: 18.0.0
        /// </summary>
        /// <example>18.0.0</example>
        [global::Newtonsoft.Json.JsonProperty("runtime_version")]
        public string? RuntimeVersion { get; set; }

        /// <summary>
        /// SDK version<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::Newtonsoft.Json.JsonProperty("sdk_version")]
        public string? SdkVersion { get; set; }

        /// <summary>
        /// Configuration slug or ID<br/>
        /// Example: pc-config-123
        /// </summary>
        /// <example>pc-config-123</example>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public string? Config { get; set; }

        /// <summary>
        /// Internal trace ID for gateway tracking<br/>
        /// Example: internal-trace-123
        /// </summary>
        /// <example>internal-trace-123</example>
        [global::Newtonsoft.Json.JsonProperty("internal_trace_id")]
        public string? InternalTraceId { get; set; }

        /// <summary>
        /// Index of the last used option in the config<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("last_used_option_index")]
        public int? LastUsedOptionIndex { get; set; }

        /// <summary>
        /// Configuration version identifier<br/>
        /// Example: config-v1
        /// </summary>
        /// <example>config-v1</example>
        [global::Newtonsoft.Json.JsonProperty("config_version_id")]
        public string? ConfigVersionId { get; set; }

        /// <summary>
        /// Prompt slug<br/>
        /// Example: my-prompt
        /// </summary>
        /// <example>my-prompt</example>
        [global::Newtonsoft.Json.JsonProperty("prompt_slug")]
        public string? PromptSlug { get; set; }

        /// <summary>
        /// Workspace slug<br/>
        /// Example: my-workspace
        /// </summary>
        /// <example>my-workspace</example>
        [global::Newtonsoft.Json.JsonProperty("workspace_slug")]
        public string? WorkspaceSlug { get; set; }

        /// <summary>
        /// Path format version for log storage<br/>
        /// Example: v1
        /// </summary>
        /// <example>v1</example>
        [global::Newtonsoft.Json.JsonProperty("log_store_file_path_format")]
        public string? LogStoreFilePathFormat { get; set; }

        /// <summary>
        /// Array of metadata keys<br/>
        /// Example: [key1, key2]
        /// </summary>
        /// <example>[key1, key2]</example>
        [global::Newtonsoft.Json.JsonProperty("metadata.key")]
        public global::System.Collections.Generic.IList<string>? MetadataKey { get; set; }

        /// <summary>
        /// Array of metadata values<br/>
        /// Example: [value1, value2]
        /// </summary>
        /// <example>[value1, value2]</example>
        [global::Newtonsoft.Json.JsonProperty("metadata.value")]
        public global::System.Collections.Generic.IList<string>? MetadataValue { get; set; }

        /// <summary>
        /// API key identifier<br/>
        /// Example: api-key-123
        /// </summary>
        /// <example>api-key-123</example>
        [global::Newtonsoft.Json.JsonProperty("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// Time taken to parse the request in milliseconds<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("request_parsing_time")]
        public long? RequestParsingTime { get; set; }

        /// <summary>
        /// Time taken for pre-processing in milliseconds<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("pre_processing_time")]
        public long? PreProcessingTime { get; set; }

        /// <summary>
        /// Time taken for cache processing in milliseconds<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("cache_processing_time")]
        public long? CacheProcessingTime { get; set; }

        /// <summary>
        /// Time taken to parse the response in milliseconds<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::Newtonsoft.Json.JsonProperty("response_parsing_time")]
        public long? ResponseParsingTime { get; set; }

        /// <summary>
        /// Total gateway processing time in milliseconds<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("gateway_processing_time")]
        public long? GatewayProcessingTime { get; set; }

        /// <summary>
        /// Upstream provider response time in milliseconds<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::Newtonsoft.Json.JsonProperty("upstream_response_time")]
        public long? UpstreamResponseTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetrics" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the log entry<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="organisationId">
        /// Organization identifier<br/>
        /// Example: org-123
        /// </param>
        /// <param name="organisationName">
        /// Organization name<br/>
        /// Example: Acme Corp
        /// </param>
        /// <param name="promptId">
        /// Prompt identifier<br/>
        /// Example: prompt-789
        /// </param>
        /// <param name="promptVersionId">
        /// Prompt version identifier<br/>
        /// Example: prompt-v1
        /// </param>
        /// <param name="configId">
        /// Configuration identifier<br/>
        /// Example: config-123
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the log was created<br/>
        /// Example: 2024-01-15T10:30:00.000
        /// </param>
        /// <param name="isSuccess">
        /// Whether the request was successful (status code 200-299)<br/>
        /// Example: true
        /// </param>
        /// <param name="aiOrg">
        /// AI provider organization (e.g., openai, anthropic)<br/>
        /// Example: openai
        /// </param>
        /// <param name="aiModel">
        /// AI model used<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="reqUnits">
        /// Request token units<br/>
        /// Example: 100
        /// </param>
        /// <param name="resUnits">
        /// Response token units<br/>
        /// Example: 50
        /// </param>
        /// <param name="totalUnits">
        /// Total token units (req_units + res_units)<br/>
        /// Example: 150
        /// </param>
        /// <param name="cost">
        /// Cost in the specified currency<br/>
        /// Example: 0.002
        /// </param>
        /// <param name="costCurrency">
        /// Currency code for the cost<br/>
        /// Default Value: USD<br/>
        /// Example: USD
        /// </param>
        /// <param name="requestUrl">
        /// Sanitized request URL<br/>
        /// Example: https://api.openai.com/v1/chat/completions
        /// </param>
        /// <param name="requestMethod">
        /// HTTP method<br/>
        /// Example: POST
        /// </param>
        /// <param name="responseStatusCode">
        /// HTTP response status code<br/>
        /// Example: 200
        /// </param>
        /// <param name="responseTime">
        /// Response time in milliseconds<br/>
        /// Example: 1234
        /// </param>
        /// <param name="isProxyCall">
        /// Whether this was a proxy call<br/>
        /// Example: true
        /// </param>
        /// <param name="cacheStatus">
        /// Cache status (e.g., HIT, MISS, DISABLED, SEMANTIC HIT)<br/>
        /// Example: MISS
        /// </param>
        /// <param name="cacheType">
        /// Type of cache used<br/>
        /// Example: semantic
        /// </param>
        /// <param name="streamMode">
        /// Whether streaming was enabled (1) or not (0)<br/>
        /// Example: 1
        /// </param>
        /// <param name="retrySuccessCount">
        /// Number of successful retries<br/>
        /// Example: 0
        /// </param>
        /// <param name="traceId">
        /// Distributed tracing trace ID<br/>
        /// Example: trace-123
        /// </param>
        /// <param name="spanId">
        /// Distributed tracing span ID<br/>
        /// Example: span-456
        /// </param>
        /// <param name="spanName">
        /// Name of the span<br/>
        /// Example: llm
        /// </param>
        /// <param name="parentSpanId">
        /// Parent span ID in distributed tracing<br/>
        /// Example: span-789
        /// </param>
        /// <param name="mode">
        /// Request mode (e.g., single, loadbalance, fallback)<br/>
        /// Example: single
        /// </param>
        /// <param name="virtualKey">
        /// Virtual key identifier<br/>
        /// Example: vk-123
        /// </param>
        /// <param name="source">
        /// Source of the request (e.g., rubeus, proxy)<br/>
        /// Example: rubeus
        /// </param>
        /// <param name="runtime">
        /// Runtime environment<br/>
        /// Example: node
        /// </param>
        /// <param name="runtimeVersion">
        /// Runtime version<br/>
        /// Example: 18.0.0
        /// </param>
        /// <param name="sdkVersion">
        /// SDK version<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="config">
        /// Configuration slug or ID<br/>
        /// Example: pc-config-123
        /// </param>
        /// <param name="internalTraceId">
        /// Internal trace ID for gateway tracking<br/>
        /// Example: internal-trace-123
        /// </param>
        /// <param name="lastUsedOptionIndex">
        /// Index of the last used option in the config<br/>
        /// Example: 0
        /// </param>
        /// <param name="configVersionId">
        /// Configuration version identifier<br/>
        /// Example: config-v1
        /// </param>
        /// <param name="promptSlug">
        /// Prompt slug<br/>
        /// Example: my-prompt
        /// </param>
        /// <param name="workspaceSlug">
        /// Workspace slug<br/>
        /// Example: my-workspace
        /// </param>
        /// <param name="logStoreFilePathFormat">
        /// Path format version for log storage<br/>
        /// Example: v1
        /// </param>
        /// <param name="metadataKey">
        /// Array of metadata keys<br/>
        /// Example: [key1, key2]
        /// </param>
        /// <param name="metadataValue">
        /// Array of metadata values<br/>
        /// Example: [value1, value2]
        /// </param>
        /// <param name="apiKeyId">
        /// API key identifier<br/>
        /// Example: api-key-123
        /// </param>
        /// <param name="requestParsingTime">
        /// Time taken to parse the request in milliseconds<br/>
        /// Example: 5
        /// </param>
        /// <param name="preProcessingTime">
        /// Time taken for pre-processing in milliseconds<br/>
        /// Example: 10
        /// </param>
        /// <param name="cacheProcessingTime">
        /// Time taken for cache processing in milliseconds<br/>
        /// Example: 2
        /// </param>
        /// <param name="responseParsingTime">
        /// Time taken to parse the response in milliseconds<br/>
        /// Example: 8
        /// </param>
        /// <param name="gatewayProcessingTime">
        /// Total gateway processing time in milliseconds<br/>
        /// Example: 50
        /// </param>
        /// <param name="upstreamResponseTime">
        /// Upstream provider response time in milliseconds<br/>
        /// Example: 1200
        /// </param>
        public AnalyticsMetrics(
            global::System.Guid? id,
            string? organisationId,
            string? organisationName,
            string? promptId,
            string? promptVersionId,
            string? configId,
            global::System.DateTime? createdAt,
            bool? isSuccess,
            string? aiOrg,
            string? aiModel,
            float? reqUnits,
            float? resUnits,
            float? totalUnits,
            float? cost,
            string? costCurrency,
            string? requestUrl,
            string? requestMethod,
            int? responseStatusCode,
            long? responseTime,
            bool? isProxyCall,
            string? cacheStatus,
            string? cacheType,
            int? streamMode,
            int? retrySuccessCount,
            string? traceId,
            string? spanId,
            string? spanName,
            string? parentSpanId,
            string? mode,
            string? virtualKey,
            string? source,
            string? runtime,
            string? runtimeVersion,
            string? sdkVersion,
            string? config,
            string? internalTraceId,
            int? lastUsedOptionIndex,
            string? configVersionId,
            string? promptSlug,
            string? workspaceSlug,
            string? logStoreFilePathFormat,
            global::System.Collections.Generic.IList<string>? metadataKey,
            global::System.Collections.Generic.IList<string>? metadataValue,
            string? apiKeyId,
            long? requestParsingTime,
            long? preProcessingTime,
            long? cacheProcessingTime,
            long? responseParsingTime,
            long? gatewayProcessingTime,
            long? upstreamResponseTime)
        {
            this.Id = id;
            this.OrganisationId = organisationId;
            this.OrganisationName = organisationName;
            this.PromptId = promptId;
            this.PromptVersionId = promptVersionId;
            this.ConfigId = configId;
            this.CreatedAt = createdAt;
            this.IsSuccess = isSuccess;
            this.AiOrg = aiOrg;
            this.AiModel = aiModel;
            this.ReqUnits = reqUnits;
            this.ResUnits = resUnits;
            this.TotalUnits = totalUnits;
            this.Cost = cost;
            this.CostCurrency = costCurrency;
            this.RequestUrl = requestUrl;
            this.RequestMethod = requestMethod;
            this.ResponseStatusCode = responseStatusCode;
            this.ResponseTime = responseTime;
            this.IsProxyCall = isProxyCall;
            this.CacheStatus = cacheStatus;
            this.CacheType = cacheType;
            this.StreamMode = streamMode;
            this.RetrySuccessCount = retrySuccessCount;
            this.TraceId = traceId;
            this.SpanId = spanId;
            this.SpanName = spanName;
            this.ParentSpanId = parentSpanId;
            this.Mode = mode;
            this.VirtualKey = virtualKey;
            this.Source = source;
            this.Runtime = runtime;
            this.RuntimeVersion = runtimeVersion;
            this.SdkVersion = sdkVersion;
            this.Config = config;
            this.InternalTraceId = internalTraceId;
            this.LastUsedOptionIndex = lastUsedOptionIndex;
            this.ConfigVersionId = configVersionId;
            this.PromptSlug = promptSlug;
            this.WorkspaceSlug = workspaceSlug;
            this.LogStoreFilePathFormat = logStoreFilePathFormat;
            this.MetadataKey = metadataKey;
            this.MetadataValue = metadataValue;
            this.ApiKeyId = apiKeyId;
            this.RequestParsingTime = requestParsingTime;
            this.PreProcessingTime = preProcessingTime;
            this.CacheProcessingTime = cacheProcessingTime;
            this.ResponseParsingTime = responseParsingTime;
            this.GatewayProcessingTime = gatewayProcessingTime;
            this.UpstreamResponseTime = upstreamResponseTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetrics" /> class.
        /// </summary>
        public AnalyticsMetrics()
        {
        }
    }
}