//HintName: G.Models.Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Image
    {
        /// <summary>
        /// Bit depth of the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_depth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BitDepth { get; set; }

        /// <summary>
        /// Format of the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Format { get; set; }

        /// <summary>
        /// Height of the image in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Height { get; set; }

        /// <summary>
        /// Width of the image in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="bitDepth">
        /// Bit depth of the image
        /// </param>
        /// <param name="format">
        /// Format of the image
        /// </param>
        /// <param name="height">
        /// Height of the image in pixels
        /// </param>
        /// <param name="width">
        /// Width of the image in pixels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Image(
            double bitDepth,
            string format,
            double height,
            double width)
        {
            this.BitDepth = bitDepth;
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        public Image()
        {
        }
    }
}