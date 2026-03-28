//HintName: G.Models.GenerationSourceContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationSourceContext
    {
        /// <summary>
        /// Default Value: generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GenerationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_provider")]
        public string? ModelProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_session_id")]
        public string? GenerationSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_iteration_id")]
        public string? SessionIterationId { get; set; }

        /// <summary>
        /// Modified/enhanced prompt if different from original
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("altered_prompt")]
        public string? AlteredPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extend_video")]
        public global::G.ReferenceVideo? ExtendVideo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationSourceContext" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="modelId"></param>
        /// <param name="sourceType">
        /// Default Value: generation
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="modelProvider"></param>
        /// <param name="generationSessionId"></param>
        /// <param name="sessionIterationId"></param>
        /// <param name="alteredPrompt">
        /// Modified/enhanced prompt if different from original
        /// </param>
        /// <param name="modelParameters"></param>
        /// <param name="extendVideo"></param>
        public GenerationSourceContext(
            string generationId,
            string modelId,
            string? sourceType,
            string? prompt,
            string? modelProvider,
            string? generationSessionId,
            string? sessionIterationId,
            string? alteredPrompt,
            object? modelParameters,
            global::G.ReferenceVideo? extendVideo)
        {
            this.SourceType = sourceType;
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Prompt = prompt;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelProvider = modelProvider;
            this.GenerationSessionId = generationSessionId;
            this.SessionIterationId = sessionIterationId;
            this.AlteredPrompt = alteredPrompt;
            this.ModelParameters = modelParameters;
            this.ExtendVideo = extendVideo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationSourceContext" /> class.
        /// </summary>
        public GenerationSourceContext()
        {
        }
    }
}