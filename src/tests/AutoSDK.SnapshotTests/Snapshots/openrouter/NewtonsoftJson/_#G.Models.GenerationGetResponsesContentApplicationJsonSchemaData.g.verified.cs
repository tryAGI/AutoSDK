//HintName: G.Models.GenerationGetResponsesContentApplicationJsonSchemaData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation data
    /// </summary>
    public sealed partial class GenerationGetResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// Unique identifier for the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Upstream provider's identifier for this generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstream_id")]
        public string? UpstreamId { get; set; }

        /// <summary>
        /// Total cost of the generation in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCost { get; set; } = default!;

        /// <summary>
        /// Discount applied due to caching
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_discount")]
        public double? CacheDiscount { get; set; }

        /// <summary>
        /// Cost charged by the upstream provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstream_inference_cost")]
        public double? UpstreamInferenceCost { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the generation was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Model used for the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// ID of the app that made the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id")]
        public double? AppId { get; set; }

        /// <summary>
        /// Whether the response was streamed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streamed")]
        public bool? Streamed { get; set; }

        /// <summary>
        /// Whether the generation was cancelled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancelled")]
        public bool? Cancelled { get; set; }

        /// <summary>
        /// Name of the provider that served the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// Total latency in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency")]
        public double? Latency { get; set; }

        /// <summary>
        /// Moderation latency in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderation_latency")]
        public double? ModerationLatency { get; set; }

        /// <summary>
        /// Time taken for generation in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_time")]
        public double? GenerationTime { get; set; }

        /// <summary>
        /// Reason the generation finished
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens_prompt")]
        public double? TokensPrompt { get; set; }

        /// <summary>
        /// Number of tokens in the completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens_completion")]
        public double? TokensCompletion { get; set; }

        /// <summary>
        /// Native prompt tokens as reported by provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("native_tokens_prompt")]
        public double? NativeTokensPrompt { get; set; }

        /// <summary>
        /// Native completion tokens as reported by provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("native_tokens_completion")]
        public double? NativeTokensCompletion { get; set; }

        /// <summary>
        /// Native completion image tokens as reported by provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("native_tokens_completion_images")]
        public double? NativeTokensCompletionImages { get; set; }

        /// <summary>
        /// Native reasoning tokens as reported by provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("native_tokens_reasoning")]
        public double? NativeTokensReasoning { get; set; }

        /// <summary>
        /// Native cached tokens as reported by provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("native_tokens_cached")]
        public double? NativeTokensCached { get; set; }

        /// <summary>
        /// Number of media items in the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_media_prompt")]
        public double? NumMediaPrompt { get; set; }

        /// <summary>
        /// Number of audio inputs in the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_input_audio_prompt")]
        public double? NumInputAudioPrompt { get; set; }

        /// <summary>
        /// Number of media items in the completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_media_completion")]
        public double? NumMediaCompletion { get; set; }

        /// <summary>
        /// Number of search results included
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_search_results")]
        public double? NumSearchResults { get; set; }

        /// <summary>
        /// Origin URL of the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin", Required = global::Newtonsoft.Json.Required.Always)]
        public string Origin { get; set; } = default!;

        /// <summary>
        /// Usage amount in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public double Usage { get; set; } = default!;

        /// <summary>
        /// Whether this used bring-your-own-key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_byok", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsByok { get; set; } = default!;

        /// <summary>
        /// Native finish reason as reported by provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("native_finish_reason")]
        public string? NativeFinishReason { get; set; }

        /// <summary>
        /// External user identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_user")]
        public string? ExternalUser { get; set; }

        /// <summary>
        /// Type of API used for the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GenerationGetResponsesContentApplicationJsonSchemaDataApiType?, object> ApiType { get; set; } = default!;

        /// <summary>
        /// Router used for the request (e.g., openrouter/auto)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("router")]
        public string? Router { get; set; }

        /// <summary>
        /// List of provider responses for this generation, including fallback attempts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_responses")]
        public global::System.Collections.Generic.IList<global::G.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItems>? ProviderResponses { get; set; }

        /// <summary>
        /// User-Agent header from the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// Referer header from the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("http_referer")]
        public string? HttpReferer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the generation
        /// </param>
        /// <param name="totalCost">
        /// Total cost of the generation in USD
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the generation was created
        /// </param>
        /// <param name="model">
        /// Model used for the generation
        /// </param>
        /// <param name="origin">
        /// Origin URL of the request
        /// </param>
        /// <param name="usage">
        /// Usage amount in USD
        /// </param>
        /// <param name="isByok">
        /// Whether this used bring-your-own-key
        /// </param>
        /// <param name="apiType">
        /// Type of API used for the generation
        /// </param>
        /// <param name="upstreamId">
        /// Upstream provider's identifier for this generation
        /// </param>
        /// <param name="cacheDiscount">
        /// Discount applied due to caching
        /// </param>
        /// <param name="upstreamInferenceCost">
        /// Cost charged by the upstream provider
        /// </param>
        /// <param name="appId">
        /// ID of the app that made the request
        /// </param>
        /// <param name="streamed">
        /// Whether the response was streamed
        /// </param>
        /// <param name="cancelled">
        /// Whether the generation was cancelled
        /// </param>
        /// <param name="providerName">
        /// Name of the provider that served the request
        /// </param>
        /// <param name="latency">
        /// Total latency in milliseconds
        /// </param>
        /// <param name="moderationLatency">
        /// Moderation latency in milliseconds
        /// </param>
        /// <param name="generationTime">
        /// Time taken for generation in milliseconds
        /// </param>
        /// <param name="finishReason">
        /// Reason the generation finished
        /// </param>
        /// <param name="tokensPrompt">
        /// Number of tokens in the prompt
        /// </param>
        /// <param name="tokensCompletion">
        /// Number of tokens in the completion
        /// </param>
        /// <param name="nativeTokensPrompt">
        /// Native prompt tokens as reported by provider
        /// </param>
        /// <param name="nativeTokensCompletion">
        /// Native completion tokens as reported by provider
        /// </param>
        /// <param name="nativeTokensCompletionImages">
        /// Native completion image tokens as reported by provider
        /// </param>
        /// <param name="nativeTokensReasoning">
        /// Native reasoning tokens as reported by provider
        /// </param>
        /// <param name="nativeTokensCached">
        /// Native cached tokens as reported by provider
        /// </param>
        /// <param name="numMediaPrompt">
        /// Number of media items in the prompt
        /// </param>
        /// <param name="numInputAudioPrompt">
        /// Number of audio inputs in the prompt
        /// </param>
        /// <param name="numMediaCompletion">
        /// Number of media items in the completion
        /// </param>
        /// <param name="numSearchResults">
        /// Number of search results included
        /// </param>
        /// <param name="nativeFinishReason">
        /// Native finish reason as reported by provider
        /// </param>
        /// <param name="externalUser">
        /// External user identifier
        /// </param>
        /// <param name="router">
        /// Router used for the request (e.g., openrouter/auto)
        /// </param>
        /// <param name="providerResponses">
        /// List of provider responses for this generation, including fallback attempts
        /// </param>
        /// <param name="userAgent">
        /// User-Agent header from the request
        /// </param>
        /// <param name="httpReferer">
        /// Referer header from the request
        /// </param>
        public GenerationGetResponsesContentApplicationJsonSchemaData(
            string id,
            double totalCost,
            string createdAt,
            string model,
            string origin,
            double usage,
            bool isByok,
            global::G.OneOf<global::G.GenerationGetResponsesContentApplicationJsonSchemaDataApiType?, object> apiType,
            string? upstreamId,
            double? cacheDiscount,
            double? upstreamInferenceCost,
            double? appId,
            bool? streamed,
            bool? cancelled,
            string? providerName,
            double? latency,
            double? moderationLatency,
            double? generationTime,
            string? finishReason,
            double? tokensPrompt,
            double? tokensCompletion,
            double? nativeTokensPrompt,
            double? nativeTokensCompletion,
            double? nativeTokensCompletionImages,
            double? nativeTokensReasoning,
            double? nativeTokensCached,
            double? numMediaPrompt,
            double? numInputAudioPrompt,
            double? numMediaCompletion,
            double? numSearchResults,
            string? nativeFinishReason,
            string? externalUser,
            string? router,
            global::System.Collections.Generic.IList<global::G.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItems>? providerResponses,
            string? userAgent,
            string? httpReferer)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UpstreamId = upstreamId;
            this.TotalCost = totalCost;
            this.CacheDiscount = cacheDiscount;
            this.UpstreamInferenceCost = upstreamInferenceCost;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.AppId = appId;
            this.Streamed = streamed;
            this.Cancelled = cancelled;
            this.ProviderName = providerName;
            this.Latency = latency;
            this.ModerationLatency = moderationLatency;
            this.GenerationTime = generationTime;
            this.FinishReason = finishReason;
            this.TokensPrompt = tokensPrompt;
            this.TokensCompletion = tokensCompletion;
            this.NativeTokensPrompt = nativeTokensPrompt;
            this.NativeTokensCompletion = nativeTokensCompletion;
            this.NativeTokensCompletionImages = nativeTokensCompletionImages;
            this.NativeTokensReasoning = nativeTokensReasoning;
            this.NativeTokensCached = nativeTokensCached;
            this.NumMediaPrompt = numMediaPrompt;
            this.NumInputAudioPrompt = numInputAudioPrompt;
            this.NumMediaCompletion = numMediaCompletion;
            this.NumSearchResults = numSearchResults;
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
            this.Usage = usage;
            this.IsByok = isByok;
            this.NativeFinishReason = nativeFinishReason;
            this.ExternalUser = externalUser;
            this.ApiType = apiType;
            this.Router = router;
            this.ProviderResponses = providerResponses;
            this.UserAgent = userAgent;
            this.HttpReferer = httpReferer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public GenerationGetResponsesContentApplicationJsonSchemaData()
        {
        }
    }
}