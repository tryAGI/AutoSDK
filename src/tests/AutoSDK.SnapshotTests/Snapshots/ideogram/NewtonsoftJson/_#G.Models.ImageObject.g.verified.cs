//HintName: G.Models.ImageObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"seed":12345,"prompt":"A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there\u0027s an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.","resolution":"1024x1024","url":"https://ideogram.ai/api/images/direct/8YEpFzHuS-S6xXEGmCsf7g","is_image_safe":true}
    /// </summary>
    public sealed partial class ImageObject
    {
        /// <summary>
        /// The direct link to the image generated.<br/>
        /// Example: https://ideogram.ai/api/images/direct/8YEpFzHuS-S6xXEGmCsf7g
        /// </summary>
        /// <example>https://ideogram.ai/api/images/direct/8YEpFzHuS-S6xXEGmCsf7g</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The prompt used for the generation. This may be different from the original prompt.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there's an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </summary>
        /// <example>A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there's an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.</example>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The resolution of the final image.<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::Newtonsoft.Json.JsonProperty("resolution", Required = global::Newtonsoft.Json.Required.Always)]
        public string Resolution { get; set; } = default!;

        /// <summary>
        /// Whether this request passes safety checks. If false, the url field will be empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_image_safe", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsImageSafe { get; set; } = default!;

        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::Newtonsoft.Json.JsonProperty("seed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Seed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageObject" /> class.
        /// </summary>
        /// <param name="url">
        /// The direct link to the image generated.<br/>
        /// Example: https://ideogram.ai/api/images/direct/8YEpFzHuS-S6xXEGmCsf7g
        /// </param>
        /// <param name="prompt">
        /// The prompt used for the generation. This may be different from the original prompt.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there's an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </param>
        /// <param name="resolution">
        /// The resolution of the final image.<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="isImageSafe">
        /// Whether this request passes safety checks. If false, the url field will be empty.
        /// </param>
        /// <param name="seed">
        /// Example: 12345
        /// </param>
        public ImageObject(
            string prompt,
            string resolution,
            bool isImageSafe,
            int seed,
            string? url)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageObject" /> class.
        /// </summary>
        public ImageObject()
        {
        }
    }
}