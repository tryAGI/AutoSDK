//HintName: G.Models.GlobalEmoteImages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.  
    ///   
    /// **NOTE:** You should use the templated URL in the `template` field to fetch the image instead of using these URLs.
    /// </summary>
    public sealed partial class GlobalEmoteImages
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
    }
}