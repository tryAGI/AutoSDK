//HintName: G.Models.VlmModelSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for a VLM model.<br/>
    /// This defines the model configuration that is independent of the engine.<br/>
    /// It includes:<br/>
    /// - Default model repository ID<br/>
    /// - Prompt template<br/>
    /// - Response format<br/>
    /// - Engine-specific overrides
    /// </summary>
    public sealed partial class VlmModelSpec
    {
        /// <summary>
        /// Human-readable model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Default HuggingFace repository ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_repo_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultRepoId { get; set; } = default!;

        /// <summary>
        /// Default model revision<br/>
        /// Default Value: main
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// Prompt template for this model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Expected response format from the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatJsonConverter))]
        public global::G.ResponseFormat ResponseFormat { get; set; } = default!;

        /// <summary>
        /// Set of supported engines (None = all supported)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported_engines")]
        public global::System.Collections.Generic.IList<global::G.VlmEngineType>? SupportedEngines { get; set; }

        /// <summary>
        /// Engine-specific configuration overrides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("engine_overrides")]
        public global::System.Collections.Generic.Dictionary<string, global::G.EngineModelConfig>? EngineOverrides { get; set; }

        /// <summary>
        /// API-specific configuration overrides
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_overrides")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ApiModelConfig>? ApiOverrides { get; set; }

        /// <summary>
        /// Whether to trust remote code for this model<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trust_remote_code")]
        public bool? TrustRemoteCode { get; set; }

        /// <summary>
        /// Stop strings for generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_strings")]
        public global::System.Collections.Generic.IList<string>? StopStrings { get; set; }

        /// <summary>
        /// Maximum number of new tokens to generate<br/>
        /// Default Value: 4096
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_new_tokens")]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VlmModelSpec" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable model name
        /// </param>
        /// <param name="defaultRepoId">
        /// Default HuggingFace repository ID
        /// </param>
        /// <param name="prompt">
        /// Prompt template for this model
        /// </param>
        /// <param name="responseFormat">
        /// Expected response format from the model
        /// </param>
        /// <param name="revision">
        /// Default model revision<br/>
        /// Default Value: main
        /// </param>
        /// <param name="supportedEngines">
        /// Set of supported engines (None = all supported)
        /// </param>
        /// <param name="engineOverrides">
        /// Engine-specific configuration overrides
        /// </param>
        /// <param name="apiOverrides">
        /// API-specific configuration overrides
        /// </param>
        /// <param name="trustRemoteCode">
        /// Whether to trust remote code for this model<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stopStrings">
        /// Stop strings for generation
        /// </param>
        /// <param name="maxNewTokens">
        /// Maximum number of new tokens to generate<br/>
        /// Default Value: 4096
        /// </param>
        public VlmModelSpec(
            string name,
            string defaultRepoId,
            string prompt,
            global::G.ResponseFormat responseFormat,
            string? revision,
            global::System.Collections.Generic.IList<global::G.VlmEngineType>? supportedEngines,
            global::System.Collections.Generic.Dictionary<string, global::G.EngineModelConfig>? engineOverrides,
            global::System.Collections.Generic.Dictionary<string, global::G.ApiModelConfig>? apiOverrides,
            bool? trustRemoteCode,
            global::System.Collections.Generic.IList<string>? stopStrings,
            int? maxNewTokens)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DefaultRepoId = defaultRepoId ?? throw new global::System.ArgumentNullException(nameof(defaultRepoId));
            this.Revision = revision;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ResponseFormat = responseFormat;
            this.SupportedEngines = supportedEngines;
            this.EngineOverrides = engineOverrides;
            this.ApiOverrides = apiOverrides;
            this.TrustRemoteCode = trustRemoteCode;
            this.StopStrings = stopStrings;
            this.MaxNewTokens = maxNewTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VlmModelSpec" /> class.
        /// </summary>
        public VlmModelSpec()
        {
        }
    }
}