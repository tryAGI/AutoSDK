//HintName: G.Models.Crop.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
    /// </summary>
    public sealed partial class Crop
    {
        /// <summary>
        /// Crop from the top of the asset<br/>
        /// Example: 0.15F
        /// </summary>
        /// <example>0.15F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        public float? Top { get; set; }

        /// <summary>
        /// Crop from the bottom of the asset<br/>
        /// Example: 0.15F
        /// </summary>
        /// <example>0.15F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom")]
        public float? Bottom { get; set; }

        /// <summary>
        /// Crop from the left of the asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left")]
        public float? Left { get; set; }

        /// <summary>
        /// Crop from the left of the asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right")]
        public float? Right { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Crop" /> class.
        /// </summary>
        /// <param name="top">
        /// Crop from the top of the asset<br/>
        /// Example: 0.15F
        /// </param>
        /// <param name="bottom">
        /// Crop from the bottom of the asset<br/>
        /// Example: 0.15F
        /// </param>
        /// <param name="left">
        /// Crop from the left of the asset
        /// </param>
        /// <param name="right">
        /// Crop from the left of the asset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Crop(
            float? top,
            float? bottom,
            float? left,
            float? right)
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crop" /> class.
        /// </summary>
        public Crop()
        {
        }
    }
}