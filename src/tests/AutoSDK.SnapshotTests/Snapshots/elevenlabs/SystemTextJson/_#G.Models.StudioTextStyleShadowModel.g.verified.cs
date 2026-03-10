//HintName: G.Models.StudioTextStyleShadowModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioTextStyleShadowModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Opacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blur")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Blur { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OffsetX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OffsetY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioTextStyleShadowModel" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="color"></param>
        /// <param name="opacity"></param>
        /// <param name="blur"></param>
        /// <param name="offsetX"></param>
        /// <param name="offsetY"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StudioTextStyleShadowModel(
            bool enabled,
            string color,
            double opacity,
            double blur,
            double offsetX,
            double offsetY)
        {
            this.Enabled = enabled;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.Opacity = opacity;
            this.Blur = blur;
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioTextStyleShadowModel" /> class.
        /// </summary>
        public StudioTextStyleShadowModel()
        {
        }
    }
}