//HintName: G.Models.UpscaleInitialImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A request to upscale a provided image with the help of an optional prompt.
    /// </summary>
    public sealed partial class UpscaleInitialImageRequest
    {
        /// <summary>
        /// An optional prompt to guide the upscale<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </summary>
        /// <example>A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.</example>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("resemblance")]
        public int? Resemblance { get; set; }

        /// <summary>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public int? Detail { get; set; }

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not<br/>
        /// Default Value: AUTO<br/>
        /// Example: ON
        /// </summary>
        /// <example>ON</example>
        [global::Newtonsoft.Json.JsonProperty("magic_prompt_option")]
        public global::G.MagicPromptOption? MagicPromptOption { get; set; }

        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleInitialImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// An optional prompt to guide the upscale<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </param>
        /// <param name="resemblance">
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="detail">
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not<br/>
        /// Default Value: AUTO<br/>
        /// Example: ON
        /// </param>
        /// <param name="seed">
        /// Example: 12345
        /// </param>
        public UpscaleInitialImageRequest(
            string? prompt,
            int? resemblance,
            int? detail,
            global::G.MagicPromptOption? magicPromptOption,
            int? seed)
        {
            this.Prompt = prompt;
            this.Resemblance = resemblance;
            this.Detail = detail;
            this.MagicPromptOption = magicPromptOption;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleInitialImageRequest" /> class.
        /// </summary>
        public UpscaleInitialImageRequest()
        {
        }
    }
}