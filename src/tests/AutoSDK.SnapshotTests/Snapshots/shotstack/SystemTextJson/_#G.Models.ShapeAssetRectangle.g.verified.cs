//HintName: G.Models.ShapeAssetRectangle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration settings for the rectangle shape. Required when `shape` is set to `rectangle`.
    /// </summary>
    public sealed partial class ShapeAssetRectangle
    {
        /// <summary>
        /// Set the width of the rectangle shape in pixels.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Set the height of the rectangle shape in pixels.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Set the corner radius of the rectangle shape.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cornerRadius")]
        public int? CornerRadius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetRectangle" /> class.
        /// </summary>
        /// <param name="width">
        /// Set the width of the rectangle shape in pixels.<br/>
        /// Example: 800
        /// </param>
        /// <param name="height">
        /// Set the height of the rectangle shape in pixels.<br/>
        /// Example: 800
        /// </param>
        /// <param name="cornerRadius">
        /// Set the corner radius of the rectangle shape.<br/>
        /// Example: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShapeAssetRectangle(
            int width,
            int height,
            int? cornerRadius)
        {
            this.Width = width;
            this.Height = height;
            this.CornerRadius = cornerRadius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetRectangle" /> class.
        /// </summary>
        public ShapeAssetRectangle()
        {
        }
    }
}