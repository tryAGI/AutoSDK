//HintName: G.Models.AIModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AIModel
    {
        /// <summary>
        /// ID of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Type of generation the model applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Aspect ratios the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratios")]
        public global::System.Collections.Generic.IList<string>? AspectRatios { get; set; }

        /// <summary>
        /// Resolutions the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolutions")]
        public global::System.Collections.Generic.IList<string>? Resolutions { get; set; }

        /// <summary>
        /// Durations the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durations")]
        public global::System.Collections.Generic.IList<string>? Durations { get; set; }

        /// <summary>
        /// Whether the model is conditioned by a start frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_start_frame")]
        public bool? RequiresStartFrame { get; set; }

        /// <summary>
        /// Whether the model is conditioned by an end frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_end_frame")]
        public bool? RequiresEndFrame { get; set; }

        /// <summary>
        /// Whether the model is conditioned by audio input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_audio_input")]
        public bool? RequiresAudioInput { get; set; }

        /// <summary>
        /// Whether the model requires video input (video-to-video).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_input_video")]
        public bool? RequiresInputVideo { get; set; }

        /// <summary>
        /// Whether the model requires character orientation (motion control).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_character_orientation")]
        public bool? RequiresCharacterOrientation { get; set; }

        /// <summary>
        /// Average generation duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eta_ms")]
        public int? EtaMs { get; set; }

        /// <summary>
        /// Tags for model categorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Maximum output duration in milliseconds for video/audio models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_ms")]
        public int? MaxDurationMs { get; set; }

        /// <summary>
        /// Whether the model supports custom resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_resolution")]
        public bool? CustomResolution { get; set; }

        /// <summary>
        /// Pricing details of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AIModelPrice PriceDetails { get; set; }

        /// <summary>
        /// Extensible pricing information with dimension modifiers for resolution, audio, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::G.Pricing? Pricing { get; set; }

        /// <summary>
        /// Width and height for each aspect_ratio and resolution tuple.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.Dimension>>? Dimensions { get; set; }

        /// <summary>
        /// Minimum character count for text prompts. Null means no minimum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_prompt_length")]
        public int? MinPromptLength { get; set; }

        /// <summary>
        /// Maximum character count for text prompts. Null means no maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_length")]
        public int? MaxPromptLength { get; set; }

        /// <summary>
        /// List of input modes the model supports. Each mode groups mutually exclusive input slots. The frontend picks one mode. text_to_video (no inputs) is always implicitly available for VIDEO type models. Null means the model has no declarative input specifications (use requires_* booleans).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<global::G.InputMode>? Inputs { get; set; }

        /// <summary>
        /// URL of the model's logo in SVG format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// Whether this is a premium model.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premium")]
        public bool? Premium { get; set; }

        /// <summary>
        /// Display order for UI sorting. Lower values appear first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_order")]
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIModel" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the model
        /// </param>
        /// <param name="name">
        /// Name of the model
        /// </param>
        /// <param name="type">
        /// Type of generation the model applies to.
        /// </param>
        /// <param name="priceDetails">
        /// Pricing details of the model.
        /// </param>
        /// <param name="description">
        /// Description of the model.
        /// </param>
        /// <param name="aspectRatios">
        /// Aspect ratios the model supports.
        /// </param>
        /// <param name="resolutions">
        /// Resolutions the model supports.
        /// </param>
        /// <param name="durations">
        /// Durations the model supports.
        /// </param>
        /// <param name="requiresStartFrame">
        /// Whether the model is conditioned by a start frame.
        /// </param>
        /// <param name="requiresEndFrame">
        /// Whether the model is conditioned by an end frame.
        /// </param>
        /// <param name="requiresAudioInput">
        /// Whether the model is conditioned by audio input.
        /// </param>
        /// <param name="requiresInputVideo">
        /// Whether the model requires video input (video-to-video).
        /// </param>
        /// <param name="requiresCharacterOrientation">
        /// Whether the model requires character orientation (motion control).
        /// </param>
        /// <param name="etaMs">
        /// Average generation duration in milliseconds.
        /// </param>
        /// <param name="tags">
        /// Tags for model categorization.
        /// </param>
        /// <param name="maxDurationMs">
        /// Maximum output duration in milliseconds for video/audio models.
        /// </param>
        /// <param name="customResolution">
        /// Whether the model supports custom resolution.
        /// </param>
        /// <param name="pricing">
        /// Extensible pricing information with dimension modifiers for resolution, audio, etc.
        /// </param>
        /// <param name="dimensions">
        /// Width and height for each aspect_ratio and resolution tuple.
        /// </param>
        /// <param name="minPromptLength">
        /// Minimum character count for text prompts. Null means no minimum.
        /// </param>
        /// <param name="maxPromptLength">
        /// Maximum character count for text prompts. Null means no maximum.
        /// </param>
        /// <param name="inputs">
        /// List of input modes the model supports. Each mode groups mutually exclusive input slots. The frontend picks one mode. text_to_video (no inputs) is always implicitly available for VIDEO type models. Null means the model has no declarative input specifications (use requires_* booleans).
        /// </param>
        /// <param name="logoUrl">
        /// URL of the model's logo in SVG format.
        /// </param>
        /// <param name="premium">
        /// Whether this is a premium model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="displayOrder">
        /// Display order for UI sorting. Lower values appear first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AIModel(
            string id,
            string name,
            string type,
            global::G.AIModelPrice priceDetails,
            string? description,
            global::System.Collections.Generic.IList<string>? aspectRatios,
            global::System.Collections.Generic.IList<string>? resolutions,
            global::System.Collections.Generic.IList<string>? durations,
            bool? requiresStartFrame,
            bool? requiresEndFrame,
            bool? requiresAudioInput,
            bool? requiresInputVideo,
            bool? requiresCharacterOrientation,
            int? etaMs,
            global::System.Collections.Generic.IList<string>? tags,
            int? maxDurationMs,
            bool? customResolution,
            global::G.Pricing? pricing,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.Dimension>>? dimensions,
            int? minPromptLength,
            int? maxPromptLength,
            global::System.Collections.Generic.IList<global::G.InputMode>? inputs,
            string? logoUrl,
            bool? premium,
            int? displayOrder)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AspectRatios = aspectRatios;
            this.Resolutions = resolutions;
            this.Durations = durations;
            this.RequiresStartFrame = requiresStartFrame;
            this.RequiresEndFrame = requiresEndFrame;
            this.RequiresAudioInput = requiresAudioInput;
            this.RequiresInputVideo = requiresInputVideo;
            this.RequiresCharacterOrientation = requiresCharacterOrientation;
            this.EtaMs = etaMs;
            this.Tags = tags;
            this.MaxDurationMs = maxDurationMs;
            this.CustomResolution = customResolution;
            this.PriceDetails = priceDetails ?? throw new global::System.ArgumentNullException(nameof(priceDetails));
            this.Pricing = pricing;
            this.Dimensions = dimensions;
            this.MinPromptLength = minPromptLength;
            this.MaxPromptLength = maxPromptLength;
            this.Inputs = inputs;
            this.LogoUrl = logoUrl;
            this.Premium = premium;
            this.DisplayOrder = displayOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIModel" /> class.
        /// </summary>
        public AIModel()
        {
        }
    }
}