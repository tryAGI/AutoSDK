//HintName: G.Models.ImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageRequest
    {
        /// <summary>
        /// The prompt to use to generate the image.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </summary>
        /// <example>A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// (Cannot be used in conjunction with resolution) The aspect ratio to use for image generation, which determines the image's resolution. Defaults to ASPECT_1_1.<br/>
        /// Example: ASPECT_10_16
        /// </summary>
        /// <example>ASPECT_10_16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AspectRatioJsonConverter))]
        public global::G.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The model used to generate. Defaults to V_2.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </summary>
        /// <example>V_2_TURBO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelEnumJsonConverter))]
        public global::G.ModelEnum? Model { get; set; }

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not<br/>
        /// Default Value: AUTO<br/>
        /// Example: ON
        /// </summary>
        /// <example>ON</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::G.MagicPromptOption? MagicPromptOption { get; set; }

        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The style type to generate with; this is only applicable for models V_2 and above and should not be specified for model versions V_1.<br/>
        /// Example: REALISTIC
        /// </summary>
        /// <example>REALISTIC</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StyleTypeJsonConverter))]
        public global::G.StyleType? StyleType { get; set; }

        /// <summary>
        /// Description of what to exclude from an image. Descriptions in the prompt take precedence to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </summary>
        /// <example>brush strokes, painting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// (For model_version for 2.0 only, cannot be used in conjunction with aspect_ratio) The resolution to use for image generation, represented in width x height. If not specified, defaults to using aspect_ratio.<br/>
        /// Example: RESOLUTION_1024_1024
        /// </summary>
        /// <example>RESOLUTION_1024_1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResolutionJsonConverter))]
        public global::G.Resolution? Resolution { get; set; }

        /// <summary>
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter))]
        public global::G.ColorPaletteWithPresetNameOrMembers? ColorPalette { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use to generate the image.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </param>
        /// <param name="aspectRatio">
        /// (Cannot be used in conjunction with resolution) The aspect ratio to use for image generation, which determines the image's resolution. Defaults to ASPECT_1_1.<br/>
        /// Example: ASPECT_10_16
        /// </param>
        /// <param name="model">
        /// The model used to generate. Defaults to V_2.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not<br/>
        /// Default Value: AUTO<br/>
        /// Example: ON
        /// </param>
        /// <param name="seed">
        /// Example: 12345
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with; this is only applicable for models V_2 and above and should not be specified for model versions V_1.<br/>
        /// Example: REALISTIC
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from an image. Descriptions in the prompt take precedence to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </param>
        /// <param name="resolution">
        /// (For model_version for 2.0 only, cannot be used in conjunction with aspect_ratio) The resolution to use for image generation, represented in width x height. If not specified, defaults to using aspect_ratio.<br/>
        /// Example: RESOLUTION_1024_1024
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageRequest(
            string prompt,
            global::G.AspectRatio? aspectRatio,
            global::G.ModelEnum? model,
            global::G.MagicPromptOption? magicPromptOption,
            int? seed,
            global::G.StyleType? styleType,
            string? negativePrompt,
            global::G.Resolution? resolution,
            global::G.ColorPaletteWithPresetNameOrMembers? colorPalette)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Model = model;
            this.MagicPromptOption = magicPromptOption;
            this.Seed = seed;
            this.StyleType = styleType;
            this.NegativePrompt = negativePrompt;
            this.Resolution = resolution;
            this.ColorPalette = colorPalette;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRequest" /> class.
        /// </summary>
        public ImageRequest()
        {
        }
    }
}