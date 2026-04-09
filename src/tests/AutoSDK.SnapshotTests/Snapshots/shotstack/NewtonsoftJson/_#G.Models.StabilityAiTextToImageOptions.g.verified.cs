//HintName: G.Models.StabilityAiTextToImageOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for the Stability AI text-to-image service. Set a text prompt to generate an image from plus other engine and configuration options. The output will be generated as a JPG file available at the URL returned in the response.
    /// </summary>
    public sealed partial class StabilityAiTextToImageOptions
    {
        /// <summary>
        /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
        /// Default Value: text-to-image
        /// </summary>
        /// <default>global::G.StabilityAiTextToImageOptionsType.TextToImage</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StabilityAiTextToImageOptionsTypeJsonConverter))]
        public global::G.StabilityAiTextToImageOptionsType Type { get; set; } = global::G.StabilityAiTextToImageOptionsType.TextToImage;

        /// <summary>
        /// The text prompt to generate an image from.<br/>
        /// Example: A detailed photograph of Mars, showcasing its orange-red surface
        /// </summary>
        /// <example>A detailed photograph of Mars, showcasing its orange-red surface</example>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The engine (model) to use for generating the image. Select from the list of available engines: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-xl-1024-v0-9`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-xl-1024-v1-0`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-v1-6`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-512-v2-1`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-xl-beta-v2-2-2`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: stable-diffusion-xl-1024-v1-0<br/>
        /// Example: stable-diffusion-xl-1024-v1-0
        /// </summary>
        /// <example>stable-diffusion-xl-1024-v1-0</example>
        [global::Newtonsoft.Json.JsonProperty("engine")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StabilityAiTextToImageOptionsEngineJsonConverter))]
        public global::G.StabilityAiTextToImageOptionsEngine? Engine { get; set; }

        /// <summary>
        /// The width of the image in pixels. Must be divisible by 64.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public int Width { get; set; } = default!;

        /// <summary>
        /// The height of the image in pixels. Must be divisible by 64.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// The number of iterative diffusion steps to run. A number between 10 and 50.<br/>
        /// Default Value: 30<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Using the same seed can help you create images that look similar. Set to 0 for a random seed. A number between 0 and 4294967295.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Determines how closely the generated image will match the prompt. Lower numbers allow for more creative freedom. A number between 0 and 35.<br/>
        /// Default Value: 7<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::Newtonsoft.Json.JsonProperty("cfgScale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// Apply a preset to generate an image in a particular style. Select from the list of available presets: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`3d-model`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`analog-film`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`anime`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`cinematic`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`comic-book`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`digital-art`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`enhance`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fantasy-art`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`isometric`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`line-art`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`low-poly`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`modeling-compound`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`neon-punk`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`origami`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`photographic`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`pixel-art`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`tile-texture`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: photographic
        /// </summary>
        /// <example>photographic</example>
        [global::Newtonsoft.Json.JsonProperty("stylePreset")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StabilityAiTextToImageOptionsStylePresetJsonConverter))]
        public global::G.StabilityAiTextToImageOptionsStylePreset? StylePreset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StabilityAiTextToImageOptions" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt to generate an image from.<br/>
        /// Example: A detailed photograph of Mars, showcasing its orange-red surface
        /// </param>
        /// <param name="width">
        /// The width of the image in pixels. Must be divisible by 64.<br/>
        /// Example: 512
        /// </param>
        /// <param name="height">
        /// The height of the image in pixels. Must be divisible by 64.<br/>
        /// Example: 512
        /// </param>
        /// <param name="engine">
        /// The engine (model) to use for generating the image. Select from the list of available engines: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-xl-1024-v0-9`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-xl-1024-v1-0`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-v1-6`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-512-v2-1`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`stable-diffusion-xl-beta-v2-2-2`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Default Value: stable-diffusion-xl-1024-v1-0<br/>
        /// Example: stable-diffusion-xl-1024-v1-0
        /// </param>
        /// <param name="steps">
        /// The number of iterative diffusion steps to run. A number between 10 and 50.<br/>
        /// Default Value: 30<br/>
        /// Example: 30
        /// </param>
        /// <param name="seed">
        /// Using the same seed can help you create images that look similar. Set to 0 for a random seed. A number between 0 and 4294967295.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="cfgScale">
        /// Determines how closely the generated image will match the prompt. Lower numbers allow for more creative freedom. A number between 0 and 35.<br/>
        /// Default Value: 7<br/>
        /// Example: 7
        /// </param>
        /// <param name="stylePreset">
        /// Apply a preset to generate an image in a particular style. Select from the list of available presets: &lt;ul&gt;<br/>
        ///   &lt;li&gt;`3d-model`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`analog-film`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`anime`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`cinematic`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`comic-book`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`digital-art`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`enhance`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`fantasy-art`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`isometric`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`line-art`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`low-poly`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`modeling-compound`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`neon-punk`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`origami`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`photographic`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`pixel-art`&lt;/li&gt;<br/>
        ///   &lt;li&gt;`tile-texture`&lt;/li&gt;<br/>
        /// &lt;/ul&gt;<br/>
        /// Example: photographic
        /// </param>
        /// <param name="type">
        /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
        /// Default Value: text-to-image
        /// </param>
        public StabilityAiTextToImageOptions(
            string prompt,
            int width,
            int height,
            global::G.StabilityAiTextToImageOptionsEngine? engine,
            int? steps,
            int? seed,
            double? cfgScale,
            global::G.StabilityAiTextToImageOptionsStylePreset? stylePreset,
            global::G.StabilityAiTextToImageOptionsType type = global::G.StabilityAiTextToImageOptionsType.TextToImage)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Engine = engine;
            this.Width = width;
            this.Height = height;
            this.Steps = steps;
            this.Seed = seed;
            this.CfgScale = cfgScale;
            this.StylePreset = stylePreset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StabilityAiTextToImageOptions" /> class.
        /// </summary>
        public StabilityAiTextToImageOptions()
        {
        }
    }
}