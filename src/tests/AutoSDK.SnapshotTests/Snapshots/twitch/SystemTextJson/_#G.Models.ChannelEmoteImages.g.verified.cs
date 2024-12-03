//HintName: G.Models.ChannelEmoteImages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.  <br/>
    ///   <br/>
    /// **NOTE:** You should use the templated URL in the `template` field to fetch the image instead of using these URLs.
    /// </summary>
    public sealed partial class ChannelEmoteImages
    {
        /// <summary>
        /// A URL to the small version (28px x 28px) of the emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_1x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url1x { get; set; }

        /// <summary>
        /// A URL to the medium version (56px x 56px) of the emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_2x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url2x { get; set; }

        /// <summary>
        /// A URL to the large version (112px x 112px) of the emote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_4x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url4x { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEmoteImages" /> class.
        /// </summary>
        /// <param name="url1x">
        /// A URL to the small version (28px x 28px) of the emote.
        /// </param>
        /// <param name="url2x">
        /// A URL to the medium version (56px x 56px) of the emote.
        /// </param>
        /// <param name="url4x">
        /// A URL to the large version (112px x 112px) of the emote.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChannelEmoteImages(
            string url1x,
            string url2x,
            string url4x)
        {
            this.Url1x = url1x ?? throw new global::System.ArgumentNullException(nameof(url1x));
            this.Url2x = url2x ?? throw new global::System.ArgumentNullException(nameof(url2x));
            this.Url4x = url4x ?? throw new global::System.ArgumentNullException(nameof(url4x));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelEmoteImages" /> class.
        /// </summary>
        public ChannelEmoteImages()
        {
        }
    }
}