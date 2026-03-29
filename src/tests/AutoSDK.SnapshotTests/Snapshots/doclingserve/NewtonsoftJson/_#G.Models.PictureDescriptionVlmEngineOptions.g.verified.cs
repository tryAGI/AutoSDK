//HintName: G.Models.PictureDescriptionVlmEngineOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for VLM runtime-based picture description.<br/>
    /// This is the new implementation that uses the pluggable runtime system with preset support.<br/>
    /// Supports all runtime types (Transformers, MLX, API, etc.) through the unified runtime interface.<br/>
    /// Use `from_preset()` to create instances from registered presets.<br/>
    /// Examples:<br/>
    ///     # Use preset with default runtime<br/>
    ///     options = PictureDescriptionVlmEngineOptions.from_preset("smolvlm")<br/>
    ///     # Use preset with runtime override<br/>
    ///     from docling.datamodel.vlm_engine_options import MlxVlmEngineOptions, VlmEngineType<br/>
    ///     options = PictureDescriptionVlmEngineOptions.from_preset(<br/>
    ///         "smolvlm",<br/>
    ///         engine_options=MlxVlmEngineOptions(engine_type=VlmEngineType.MLX)<br/>
    ///     )
    /// </summary>
    public sealed partial class PictureDescriptionVlmEngineOptions
    {
        /// <summary>
        /// Number of images to process in a single batch during picture description. Higher values improve throughput but increase memory usage. Adjust based on available GPU/CPU memory.<br/>
        /// Default Value: 8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for image resolution before processing. Higher values (e.g., 2.0) provide more detail for the vision model but increase processing time and memory. Range: 0.5-4.0 typical.<br/>
        /// Default Value: 2F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale")]
        public double? Scale { get; set; }

        /// <summary>
        /// Minimum picture area as fraction of page area (0.0-1.0) to trigger description. Pictures smaller than this threshold are skipped. Use lower values (e.g., 0.01) to describe small images.<br/>
        /// Default Value: 0.05F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("picture_area_threshold")]
        public double? PictureAreaThreshold { get; set; }

        /// <summary>
        /// List of picture classification labels to allow for description. Only pictures classified with these labels will be processed. If None, all picture types are allowed unless explicitly denied. Use to focus description on specific image types (e.g., diagrams, charts).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_allow")]
        public global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? ClassificationAllow { get; set; }

        /// <summary>
        /// List of picture classification labels to exclude from description. Pictures classified with these labels will be skipped. If None, no picture types are denied unless not in allow list. Use to exclude unwanted image types (e.g., decorative images, logos).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_deny")]
        public global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? ClassificationDeny { get; set; }

        /// <summary>
        /// Minimum classification confidence score (0.0-1.0) required for a picture to be processed. Pictures with classification confidence below this threshold are skipped. Higher values ensure only confidently classified images are described. Range: 0.0 (no filtering) to 1.0 (maximum confidence).<br/>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_min_confidence")]
        public double? ClassificationMinConfidence { get; set; }

        /// <summary>
        /// Runtime configuration (transformers, mlx, api, etc.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engine_options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseVlmEngineOptions EngineOptions { get; set; } = default!;

        /// <summary>
        /// Model specification with runtime-specific overrides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_spec", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VlmModelSpec ModelSpec { get; set; } = default!;

        /// <summary>
        /// Prompt template for the vision model. Customize to control description style, detail level, or focus.<br/>
        /// Default Value: Describe this image in a few sentences.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Generation configuration for text generation. Controls output length, sampling strategy, temperature, etc.<br/>
        /// Default Value: {"max_new_tokens":200,"do_sample":false}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_config")]
        public object? GenerationConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureDescriptionVlmEngineOptions" /> class.
        /// </summary>
        /// <param name="engineOptions">
        /// Runtime configuration (transformers, mlx, api, etc.)
        /// </param>
        /// <param name="modelSpec">
        /// Model specification with runtime-specific overrides
        /// </param>
        /// <param name="batchSize">
        /// Number of images to process in a single batch during picture description. Higher values improve throughput but increase memory usage. Adjust based on available GPU/CPU memory.<br/>
        /// Default Value: 8
        /// </param>
        /// <param name="scale">
        /// Scaling factor for image resolution before processing. Higher values (e.g., 2.0) provide more detail for the vision model but increase processing time and memory. Range: 0.5-4.0 typical.<br/>
        /// Default Value: 2F
        /// </param>
        /// <param name="pictureAreaThreshold">
        /// Minimum picture area as fraction of page area (0.0-1.0) to trigger description. Pictures smaller than this threshold are skipped. Use lower values (e.g., 0.01) to describe small images.<br/>
        /// Default Value: 0.05F
        /// </param>
        /// <param name="classificationAllow">
        /// List of picture classification labels to allow for description. Only pictures classified with these labels will be processed. If None, all picture types are allowed unless explicitly denied. Use to focus description on specific image types (e.g., diagrams, charts).
        /// </param>
        /// <param name="classificationDeny">
        /// List of picture classification labels to exclude from description. Pictures classified with these labels will be skipped. If None, no picture types are denied unless not in allow list. Use to exclude unwanted image types (e.g., decorative images, logos).
        /// </param>
        /// <param name="classificationMinConfidence">
        /// Minimum classification confidence score (0.0-1.0) required for a picture to be processed. Pictures with classification confidence below this threshold are skipped. Higher values ensure only confidently classified images are described. Range: 0.0 (no filtering) to 1.0 (maximum confidence).<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="prompt">
        /// Prompt template for the vision model. Customize to control description style, detail level, or focus.<br/>
        /// Default Value: Describe this image in a few sentences.
        /// </param>
        /// <param name="generationConfig">
        /// Generation configuration for text generation. Controls output length, sampling strategy, temperature, etc.<br/>
        /// Default Value: {"max_new_tokens":200,"do_sample":false}
        /// </param>
        public PictureDescriptionVlmEngineOptions(
            global::G.BaseVlmEngineOptions engineOptions,
            global::G.VlmModelSpec modelSpec,
            int? batchSize,
            double? scale,
            double? pictureAreaThreshold,
            global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? classificationAllow,
            global::System.Collections.Generic.IList<global::G.PictureClassificationLabel>? classificationDeny,
            double? classificationMinConfidence,
            string? prompt,
            object? generationConfig)
        {
            this.BatchSize = batchSize;
            this.Scale = scale;
            this.PictureAreaThreshold = pictureAreaThreshold;
            this.ClassificationAllow = classificationAllow;
            this.ClassificationDeny = classificationDeny;
            this.ClassificationMinConfidence = classificationMinConfidence;
            this.EngineOptions = engineOptions ?? throw new global::System.ArgumentNullException(nameof(engineOptions));
            this.ModelSpec = modelSpec ?? throw new global::System.ArgumentNullException(nameof(modelSpec));
            this.Prompt = prompt;
            this.GenerationConfig = generationConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PictureDescriptionVlmEngineOptions" /> class.
        /// </summary>
        public PictureDescriptionVlmEngineOptions()
        {
        }
    }
}