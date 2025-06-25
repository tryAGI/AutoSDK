//HintName: G.Models.ImageObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageObject
    {
        /// <summary>
        /// The direct link to the image generated.<br/>
        /// Example: https://ideogram.ai/api/images/direct/8YEpFzHuS-S6xXEGmCsf7g
        /// </summary>
        /// <example>https://ideogram.ai/api/images/direct/8YEpFzHuS-S6xXEGmCsf7g</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The prompt used for the generation. This may be different from the original prompt.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there's an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </summary>
        /// <example>A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there's an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The resolution of the final image.<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// Whether this request passes safety checks. If false, the url field will be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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