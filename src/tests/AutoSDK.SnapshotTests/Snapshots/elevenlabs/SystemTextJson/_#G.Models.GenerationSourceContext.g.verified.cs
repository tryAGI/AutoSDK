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
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_provider")]
        public string? ModelProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_session_id")]
        public string? GenerationSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_iteration_id")]
        public string? SessionIterationId { get; set; }

        /// <summary>
        /// Modified/enhanced prompt if different from original
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("altered_prompt")]
        public string? AlteredPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_video")]
        public global::G.ReferenceVideo? ExtendVideo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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