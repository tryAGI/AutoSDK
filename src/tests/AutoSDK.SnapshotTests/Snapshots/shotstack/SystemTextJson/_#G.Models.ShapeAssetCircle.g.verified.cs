//HintName: G.Models.ShapeAssetCircle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration settings for the circle shape. Required when `shape` is set to `circle`.
    /// </summary>
    public sealed partial class ShapeAssetCircle
    {
        /// <summary>
        /// Set the radius of the circle shape in pixels.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("radius")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Radius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetCircle" /> class.
        /// </summary>
        /// <param name="radius">
        /// Set the radius of the circle shape in pixels.<br/>
        /// Example: 800
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShapeAssetCircle(
            int radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetCircle" /> class.
        /// </summary>
        public ShapeAssetCircle()
        {
        }
    }
}