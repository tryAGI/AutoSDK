//HintName: G.Models.OCRPageDimensions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRPageDimensions
    {
        /// <summary>
        /// Dots per inch of the page-image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dpi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Dpi { get; set; }

        /// <summary>
        /// Height of the image in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Width of the image in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageDimensions" /> class.
        /// </summary>
        /// <param name="dpi">
        /// Dots per inch of the page-image
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
        public OCRPageDimensions(
            int dpi,
            int height,
            int width)
        {
            this.Dpi = dpi;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageDimensions" /> class.
        /// </summary>
        public OCRPageDimensions()
        {
        }
    }
}