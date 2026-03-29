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
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_created_at")]
        public string? ResponseCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_body")]
        public object? ResponseBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_model")]
        public string? ResponseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object RequestBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_user_id")]
        public string? RequestUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_properties")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestProperties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_model")]
        public string? RequestModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_override")]
        public string? ModelOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("helicone_user")]
        public string? HeliconeUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Provider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay_ms")]
        public double? DelayMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_to_first_token")]
        public double? TimeToFirstToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public double? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public double? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_write_tokens")]
        public double? PromptCacheWriteTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_read_tokens")]
        public double? PromptCacheReadTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public double? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_audio_tokens")]
        public double? PromptAudioTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_audio_tokens")]
        public double? CompletionAudioTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public string? PromptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        public string? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_created_at")]
        public string? FeedbackCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_id")]
        public string? FeedbackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_rating")]
        public bool? FeedbackRating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_body_url")]
        public string? SignedBodyUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmSchema")]
        public global::G.LlmSchema? LlmSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_ids")]
        public global::System.Collections.Generic.IList<string>? AssetIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_urls")]
        public global::System.Collections.Generic.Dictionary<string, string>? AssetUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.Dictionary<string, double>? Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costUSD")]
        public double? CostUSD { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Assets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_reference_id")]
        public string? CacheReferenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CacheEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_referrer")]
        public string? RequestReferrer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_gateway_body_mapping")]
        public string? AiGatewayBodyMapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_location")]
        public string? StorageLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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