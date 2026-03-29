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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.BaseResponsesResultObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIResponsesResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public double? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OutputItems> Output { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_text")]
        public string? OutputText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safety_identifier")]
        public string? SafetyIdentifier { get; set; }

        /// <summary>
        /// Error information returned from the API
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponsesErrorField Error { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incomplete_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IncompleteDetails IncompleteDetails { get; set; } = default!;

        /// <summary>
        /// Token usage information for the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tool_calls")]
        public double? MaxToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_logprobs")]
        public double? TopLogprobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_output_tokens")]
        public double? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseInputs Instructions { get; set; } = default!;

        /// <summary>
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BaseResponsesResultToolsItems> Tools { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIResponsesToolChoice ToolChoice { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ParallelToolCalls { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.StoredPromptTemplate? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        public global::G.BaseReasoningConfig? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncation")]
        public global::G.TruncationEnum? Truncation { get; set; }

        /// <summary>
        /// Text output configuration including format and verbosity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public global::G.TextConfig? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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