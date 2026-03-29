//HintName: G.Models.ShapeAssetLine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration settings for the line shape. Required when `shape` is set to `line`.
    /// </summary>
    public sealed partial class ShapeAssetLine
    {
        /// <summary>
        /// Set the length of the line shape in pixels.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Length { get; set; }

        /// <summary>
        /// Set the thickness of the line in pixels.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thickness")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Thickness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetLine" /> class.
        /// </summary>
        /// <param name="length">
        /// Set the length of the line shape in pixels.<br/>
        /// Example: 100
        /// </param>
        /// <param name="thickness">
        /// Set the thickness of the line in pixels.<br/>
        /// Example: 4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShapeAssetLine(
            int length,
            int thickness)
        {
            this.Length = length;
            this.Thickness = thickness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeAssetLine" /> class.
        /// </summary>
        public ShapeAssetLine()
        {
        }
    }
}