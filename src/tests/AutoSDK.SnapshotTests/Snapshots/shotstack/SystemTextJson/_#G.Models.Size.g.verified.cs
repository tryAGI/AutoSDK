//HintName: G.Models.Size.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set a custom size for a video or image in pixels. When using a custom size omit the `resolution` and `aspectRatio`. Custom sizes must be divisible by 2 based on the encoder specifications.
    /// </summary>
    public sealed partial class Size
    {
        /// <summary>
        /// Set a custom width for the video or image file in pixels. Value must be divisible by 2. Maximum video width is 1920px, maximum image width is 4096px.<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Set a custom height for the video or image file in pixels. Value must be divisible by 2. Maximum video height is 1920px, maximum image height is 4096px.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Size" /> class.
        /// </summary>
        /// <param name="width">
        /// Set a custom width for the video or image file in pixels. Value must be divisible by 2. Maximum video width is 1920px, maximum image width is 4096px.<br/>
        /// Example: 1200
        /// </param>
        /// <param name="height">
        /// Set a custom height for the video or image file in pixels. Value must be divisible by 2. Maximum video height is 1920px, maximum image height is 4096px.<br/>
        /// Example: 800
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Size(
            int? width,
            int? height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Size" /> class.
        /// </summary>
        public Size()
        {
        }
    }
}