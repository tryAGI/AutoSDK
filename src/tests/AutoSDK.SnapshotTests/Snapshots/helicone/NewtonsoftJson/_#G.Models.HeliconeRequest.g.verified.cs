//HintName: G.Models.HeliconeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeliconeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_created_at")]
        public string? ResponseCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_body")]
        public object? ResponseBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_status", Required = global::Newtonsoft.Json.Required.Always)]
        public double ResponseStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_model")]
        public string? ResponseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestCreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_body", Required = global::Newtonsoft.Json.Required.Always)]
        public object RequestBody { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestPath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_user_id")]
        public string? RequestUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_properties")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_model")]
        public string? RequestModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_override")]
        public string? ModelOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("helicone_user")]
        public string? HeliconeUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Provider Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay_ms")]
        public double? DelayMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_to_first_token")]
        public double? TimeToFirstToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public double? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public double? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cache_write_tokens")]
        public double? PromptCacheWriteTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cache_read_tokens")]
        public double? PromptCacheReadTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public double? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens")]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_audio_tokens")]
        public double? PromptAudioTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_audio_tokens")]
        public double? CompletionAudioTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_id")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version")]
        public string? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_created_at")]
        public string? FeedbackCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_id")]
        public string? FeedbackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_rating")]
        public bool? FeedbackRating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signed_body_url")]
        public string? SignedBodyUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llmSchema")]
        public global::G.LlmSchema? LlmSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_ids")]
        public global::System.Collections.Generic.IList<string>? AssetIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_urls")]
        public global::System.Collections.Generic.Dictionary<string, string>? AssetUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores")]
        public global::System.Collections.Generic.Dictionary<string, double>? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("costUSD")]
        public double? CostUSD { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Properties { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Assets { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_reference_id")]
        public string? CacheReferenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CacheEnabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_referrer")]
        public string? RequestReferrer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_gateway_body_mapping")]
        public string? AiGatewayBodyMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_location")]
        public string? StorageLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeRequest" /> class.
        /// </summary>
        /// <param name="responseStatus"></param>
        /// <param name="requestId"></param>
        /// <param name="requestCreatedAt"></param>
        /// <param name="requestBody"></param>
        /// <param name="requestPath"></param>
        /// <param name="provider"></param>
        /// <param name="properties">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="assets"></param>
        /// <param name="targetUrl"></param>
        /// <param name="model"></param>
        /// <param name="cacheEnabled"></param>
        /// <param name="responseId"></param>
        /// <param name="responseCreatedAt"></param>
        /// <param name="responseBody"></param>
        /// <param name="responseModel"></param>
        /// <param name="requestUserId"></param>
        /// <param name="requestProperties"></param>
        /// <param name="requestModel"></param>
        /// <param name="modelOverride"></param>
        /// <param name="heliconeUser"></param>
        /// <param name="delayMs"></param>
        /// <param name="timeToFirstToken"></param>
        /// <param name="totalTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="promptCacheWriteTokens"></param>
        /// <param name="promptCacheReadTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="promptAudioTokens"></param>
        /// <param name="completionAudioTokens"></param>
        /// <param name="cost"></param>
        /// <param name="promptId"></param>
        /// <param name="promptVersion"></param>
        /// <param name="feedbackCreatedAt"></param>
        /// <param name="feedbackId"></param>
        /// <param name="feedbackRating"></param>
        /// <param name="signedBodyUrl"></param>
        /// <param name="llmSchema"></param>
        /// <param name="countryCode"></param>
        /// <param name="assetIds"></param>
        /// <param name="assetUrls"></param>
        /// <param name="scores"></param>
        /// <param name="costUSD"></param>
        /// <param name="cacheReferenceId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="requestReferrer"></param>
        /// <param name="aiGatewayBodyMapping"></param>
        /// <param name="storageLocation"></param>
        public HeliconeRequest(
            double responseStatus,
            string requestId,
            string requestCreatedAt,
            object requestBody,
            string requestPath,
            global::G.Provider provider,
            global::System.Collections.Generic.Dictionary<string, string> properties,
            global::System.Collections.Generic.IList<string> assets,
            string targetUrl,
            string model,
            bool cacheEnabled,
            string? responseId,
            string? responseCreatedAt,
            object? responseBody,
            string? responseModel,
            string? requestUserId,
            global::System.Collections.Generic.Dictionary<string, string>? requestProperties,
            string? requestModel,
            string? modelOverride,
            string? heliconeUser,
            double? delayMs,
            double? timeToFirstToken,
            double? totalTokens,
            double? promptTokens,
            double? promptCacheWriteTokens,
            double? promptCacheReadTokens,
            double? completionTokens,
            double? reasoningTokens,
            double? promptAudioTokens,
            double? completionAudioTokens,
            double? cost,
            string? promptId,
            string? promptVersion,
            string? feedbackCreatedAt,
            string? feedbackId,
            bool? feedbackRating,
            string? signedBodyUrl,
            global::G.LlmSchema? llmSchema,
            string? countryCode,
            global::System.Collections.Generic.IList<string>? assetIds,
            global::System.Collections.Generic.Dictionary<string, string>? assetUrls,
            global::System.Collections.Generic.Dictionary<string, double>? scores,
            double? costUSD,
            string? cacheReferenceId,
            string? updatedAt,
            string? requestReferrer,
            string? aiGatewayBodyMapping,
            string? storageLocation)
        {
            this.ResponseId = responseId;
            this.ResponseCreatedAt = responseCreatedAt;
            this.ResponseBody = responseBody;
            this.ResponseStatus = responseStatus;
            this.ResponseModel = responseModel;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.RequestCreatedAt = requestCreatedAt ?? throw new global::System.ArgumentNullException(nameof(requestCreatedAt));
            this.RequestBody = requestBody ?? throw new global::System.ArgumentNullException(nameof(requestBody));
            this.RequestPath = requestPath ?? throw new global::System.ArgumentNullException(nameof(requestPath));
            this.RequestUserId = requestUserId;
            this.RequestProperties = requestProperties;
            this.RequestModel = requestModel;
            this.ModelOverride = modelOverride;
            this.HeliconeUser = heliconeUser;
            this.Provider = provider;
            this.DelayMs = delayMs;
            this.TimeToFirstToken = timeToFirstToken;
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
            this.PromptCacheWriteTokens = promptCacheWriteTokens;
            this.PromptCacheReadTokens = promptCacheReadTokens;
            this.CompletionTokens = completionTokens;
            this.ReasoningTokens = reasoningTokens;
            this.PromptAudioTokens = promptAudioTokens;
            this.CompletionAudioTokens = completionAudioTokens;
            this.Cost = cost;
            this.PromptId = promptId;
            this.PromptVersion = promptVersion;
            this.FeedbackCreatedAt = feedbackCreatedAt;
            this.FeedbackId = feedbackId;
            this.FeedbackRating = feedbackRating;
            this.SignedBodyUrl = signedBodyUrl;
            this.LlmSchema = llmSchema;
            this.CountryCode = countryCode;
            this.AssetIds = assetIds;
            this.AssetUrls = assetUrls;
            this.Scores = scores;
            this.CostUSD = costUSD;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.TargetUrl = targetUrl ?? throw new global::System.ArgumentNullException(nameof(targetUrl));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.CacheReferenceId = cacheReferenceId;
            this.CacheEnabled = cacheEnabled;
            this.UpdatedAt = updatedAt;
            this.RequestReferrer = requestReferrer;
            this.AiGatewayBodyMapping = aiGatewayBodyMapping;
            this.StorageLocation = storageLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeRequest" /> class.
        /// </summary>
        public HeliconeRequest()
        {
        }
    }
}