//HintName: G.Models.OcrWordBoundingBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bounding box coordinates for this word.
    /// </summary>
    public sealed partial class OcrWordBoundingBox
    {
        /// <summary>
        /// Left X coordinate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        public double? X { get; set; }

        /// <summary>
        /// Top Y coordinate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        public double? Y { get; set; }

        /// <summary>
        /// Width of the bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Height of the bounding box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrWordBoundingBox" /> class.
        /// </summary>
        /// <param name="x">
        /// Left X coordinate.
        /// </param>
        /// <param name="y">
        /// Top Y coordinate.
        /// </param>
        /// <param name="width">
        /// Width of the bounding box.
        /// </param>
        /// <param name="height">
        /// Height of the bounding box.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrWordBoundingBox(
            double? x,
            double? y,
            double? width,
            double? height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrWordBoundingBox" /> class.
        /// </summary>
        public OcrWordBoundingBox()
        {
        }
    }
}