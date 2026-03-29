//HintName: G.Models.CodeFormulaVlmOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for VLM-based code and formula extraction.<br/>
    /// This stage uses vision-language models to extract code blocks and<br/>
    /// mathematical formulas from document images. Supports preset-based<br/>
    /// configuration via StagePresetMixin.<br/>
    /// Examples:<br/>
    ///     # Use CodeFormulaV2 preset<br/>
    ///     options = CodeFormulaVlmOptions.from_preset("codeformulav2")<br/>
    ///     # Use Granite Docling preset<br/>
    ///     options = CodeFormulaVlmOptions.from_preset("granite_docling")
    /// </summary>
    public sealed partial class CodeFormulaVlmOptions
    {
        /// <summary>
        /// Runtime configuration (transformers, mlx, api, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BaseVlmEngineOptions EngineOptions { get; set; }

        /// <summary>
        /// Model specification with runtime-specific overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VlmModelSpec ModelSpec { get; set; }

        /// <summary>
        /// Image scaling factor for preprocessing<br/>
        /// Default Value: 2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        public double? Scale { get; set; }

        /// <summary>
        /// Maximum image dimension (width or height)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_size")]
        public int? MaxSize { get; set; }

        /// <summary>
        /// Extract code blocks<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_code")]
        public bool? ExtractCode { get; set; }

        /// <summary>
        /// Extract mathematical formulas<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_formulas")]
        public bool? ExtractFormulas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeFormulaVlmOptions" /> class.
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
        /// <param name="extractCode">
        /// Extract code blocks<br/>
        /// Default Value: true
        /// </param>
        /// <param name="extractFormulas">
        /// Extract mathematical formulas<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeFormulaVlmOptions(
            global::G.BaseVlmEngineOptions engineOptions,
            global::G.VlmModelSpec modelSpec,
            double? scale,
            int? maxSize,
            bool? extractCode,
            bool? extractFormulas)
        {
            this.EngineOptions = engineOptions ?? throw new global::System.ArgumentNullException(nameof(engineOptions));
            this.ModelSpec = modelSpec ?? throw new global::System.ArgumentNullException(nameof(modelSpec));
            this.Scale = scale;
            this.MaxSize = maxSize;
            this.ExtractCode = extractCode;
            this.ExtractFormulas = extractFormulas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeFormulaVlmOptions" /> class.
        /// </summary>
        public CodeFormulaVlmOptions()
        {
        }
    }
}