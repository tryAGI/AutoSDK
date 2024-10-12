//HintName: G.Models.Request2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request2
    {
        /// <summary>
        /// Height of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; } = 1024;

        /// <summary>
        /// The model to use for image generation.<br/>
        /// Default Value: stabilityai/stable-diffusion-xl-base-1.0<br/>
        /// Example: stabilityai/stable-diffusion-xl-base-1.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Number of image results to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; } = 1;

        /// <summary>
        /// The prompt or prompts not to guide the image generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// A description of the desired images. Maximum length varies by model.<br/>
        /// Default Value: cat floating in space, cinematic<br/>
        /// Example: cat floating in space, cinematic
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Seed used for generation. Can be used to reproduce image generations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of generation steps.<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public int? Steps { get; set; } = 20;

        /// <summary>
        /// Width of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; } = 1024;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}