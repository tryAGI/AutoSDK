//HintName: G.Models.VlmConvertOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for VLM-based document conversion.<br/>
    /// This stage uses vision-language models to convert document pages to<br/>
    /// structured formats (DocTags, Markdown, etc.). Supports preset-based<br/>
    /// configuration via StagePresetMixin.<br/>
    /// Examples:<br/>
    ///     # Use preset with default runtime<br/>
    ///     options = VlmConvertOptions.from_preset("smoldocling")<br/>
    ///     # Use preset with runtime override<br/>
    ///     from docling.datamodel.vlm_engine_options import ApiVlmEngineOptions, VlmEngineType<br/>
    ///     options = VlmConvertOptions.from_preset(<br/>
    ///         "smoldocling",<br/>
    ///         engine_options=ApiVlmEngineOptions(engine_type=VlmEngineType.API_OLLAMA)<br/>
    ///     )
    /// </summary>
    public sealed partial class VlmConvertOptions
    {
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
        /// Image scaling factor for preprocessing<br/>
        /// Default Value: 2F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale")]
        public double? Scale { get; set; }

        /// <summary>
        /// Maximum image dimension (width or height)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_size")]
        public int? MaxSize { get; set; }

        /// <summary>
        /// Batch size for processing multiple pages<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Force use of backend text extraction instead of VLM<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("force_backend_text")]
        public bool? ForceBackendText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VlmConvertOptions" /> class.
        /// </summary>
        /// <param name="engineOptions">
        /// Runtime configuration (transformers, mlx, api, etc.)
        /// </param>
        /// <param name="modelSpec">
        /// Model specification with runtime-specific overrides
        /// </param>
        /// <param name="scale">
        /// Image scaling factor for preprocessing<br/>
        /// Default Value: 2F
        /// </param>
        /// <param name="maxSize">
        /// Maximum image dimension (width or height)
        /// </param>
        /// <param name="batchSize">
        /// Batch size for processing multiple pages<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="forceBackendText">
        /// Force use of backend text extraction instead of VLM<br/>
        /// Default Value: false
        /// </param>
        public VlmConvertOptions(
            global::G.BaseVlmEngineOptions engineOptions,
            global::G.VlmModelSpec modelSpec,
            double? scale,
            int? maxSize,
            int? batchSize,
            bool? forceBackendText)
        {
            this.EngineOptions = engineOptions ?? throw new global::System.ArgumentNullException(nameof(engineOptions));
            this.ModelSpec = modelSpec ?? throw new global::System.ArgumentNullException(nameof(modelSpec));
            this.Scale = scale;
            this.MaxSize = maxSize;
            this.BatchSize = batchSize;
            this.ForceBackendText = forceBackendText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VlmConvertOptions" /> class.
        /// </summary>
        public VlmConvertOptions()
        {
        }
    }
}