//HintName: G.Models.Thumbnail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Thumbnail image information.
    /// </summary>
    public sealed partial class Thumbnail
    {
        /// <summary>
        /// URL of the thumbnail image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// URL of the original image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original")]
        public string? Original { get; set; }

        /// <summary>
        /// Whether the thumbnail is a logo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        public bool? Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail" /> class.
        /// </summary>
        /// <param name="src">
        /// URL of the thumbnail image.
        /// </param>
        /// <param name="original">
        /// URL of the original image.
        /// </param>
        /// <param name="logo">
        /// Whether the thumbnail is a logo.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Thumbnail(
            string? src,
            string? original,
            bool? logo)
        {
            this.Src = src;
            this.Original = original;
            this.Logo = logo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail" /> class.
        /// </summary>
        public Thumbnail()
        {
        }
    }
}