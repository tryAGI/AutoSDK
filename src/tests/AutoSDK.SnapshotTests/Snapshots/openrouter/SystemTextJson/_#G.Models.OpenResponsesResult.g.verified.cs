//HintName: G.Models.OpenResponsesResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Complete non-streaming response from the Responses API
    /// </summary>
    public sealed partial class OpenResponsesResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseResponsesResultObjectJsonConverter))]
        public global::G.BaseResponsesResultObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIResponsesResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIResponsesResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OutputItems> Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text")]
        public string? OutputText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// Error information returned from the API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponsesErrorField Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incomplete_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IncompleteDetails IncompleteDetails { get; set; }

        /// <summary>
        /// Token usage information for the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tool_calls")]
        public double? MaxToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public double? TopLogprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public double? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseInputsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseInputs Instructions { get; set; }

        /// <summary>
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BaseResponsesResultToolsItems> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIResponsesToolChoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAIResponsesToolChoice ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::G.StoredPromptTemplate? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::G.BaseReasoningConfig? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TruncationEnumJsonConverter))]
        public global::G.TruncationEnum? Truncation { get; set; }

        /// <summary>
        /// Text output configuration including format and verbosity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::G.TextConfig? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="model"></param>
        /// <param name="status"></param>
        /// <param name="output"></param>
        /// <param name="error">
        /// Error information returned from the API
        /// </param>
        /// <param name="incompleteDetails"></param>
        /// <param name="instructions"></param>
        /// <param name="metadata">
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="object"></param>
        /// <param name="completedAt"></param>
        /// <param name="user"></param>
        /// <param name="outputText"></param>
        /// <param name="promptCacheKey"></param>
        /// <param name="safetyIdentifier"></param>
        /// <param name="usage">
        /// Token usage information for the response
        /// </param>
        /// <param name="maxToolCalls"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="prompt"></param>
        /// <param name="background"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="reasoning"></param>
        /// <param name="serviceTier"></param>
        /// <param name="store"></param>
        /// <param name="truncation"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenResponsesResult(
            string id,
            double createdAt,
            string model,
            global::G.OpenAIResponsesResponseStatus status,
            global::System.Collections.Generic.IList<global::G.OutputItems> output,
            global::G.ResponsesErrorField error,
            global::G.IncompleteDetails incompleteDetails,
            global::G.BaseInputs instructions,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.Collections.Generic.IList<global::G.BaseResponsesResultToolsItems> tools,
            global::G.OpenAIResponsesToolChoice toolChoice,
            bool parallelToolCalls,
            global::G.BaseResponsesResultObject @object,
            double? completedAt,
            string? user,
            string? outputText,
            string? promptCacheKey,
            string? safetyIdentifier,
            global::G.Usage? usage,
            double? maxToolCalls,
            double? topLogprobs,
            double? maxOutputTokens,
            double? temperature,
            double? topP,
            double? presencePenalty,
            double? frequencyPenalty,
            global::G.StoredPromptTemplate? prompt,
            bool? background,
            string? previousResponseId,
            global::G.BaseReasoningConfig? reasoning,
            string? serviceTier,
            bool? store,
            global::G.TruncationEnum? truncation,
            global::G.TextConfig? text)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Status = status;
            this.CompletedAt = completedAt;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.User = user;
            this.OutputText = outputText;
            this.PromptCacheKey = promptCacheKey;
            this.SafetyIdentifier = safetyIdentifier;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.IncompleteDetails = incompleteDetails ?? throw new global::System.ArgumentNullException(nameof(incompleteDetails));
            this.Usage = usage;
            this.MaxToolCalls = maxToolCalls;
            this.TopLogprobs = topLogprobs;
            this.MaxOutputTokens = maxOutputTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.Instructions = instructions;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.ToolChoice = toolChoice;
            this.ParallelToolCalls = parallelToolCalls;
            this.Prompt = prompt;
            this.Background = background;
            this.PreviousResponseId = previousResponseId;
            this.Reasoning = reasoning;
            this.ServiceTier = serviceTier;
            this.Store = store;
            this.Truncation = truncation;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesResult" /> class.
        /// </summary>
        public OpenResponsesResult()
        {
        }
    }
}