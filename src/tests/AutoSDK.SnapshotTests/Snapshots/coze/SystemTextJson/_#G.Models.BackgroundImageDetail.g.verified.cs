//HintName: G.Models.BackgroundImageDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundImageDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvas_position")]
        public global::G.CanvasPosition1? CanvasPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gradient_position")]
        public global::G.GradientPosition1? GradientPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme_color")]
        public string? ThemeColor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundImageDetail" /> class.
        /// </summary>
        /// <param name="canvasPosition"></param>
        /// <param name="gradientPosition"></param>
        /// <param name="imageUrl"></param>
        /// <param name="themeColor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundImageDetail(
            global::G.CanvasPosition1? canvasPosition,
            global::G.GradientPosition1? gradientPosition,
            string? imageUrl,
            string? themeColor)
        {
            this.CanvasPosition = canvasPosition;
            this.GradientPosition = gradientPosition;
            this.ImageUrl = imageUrl;
            this.ThemeColor = themeColor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundImageDetail" /> class.
        /// </summary>
        public BackgroundImageDetail()
        {
        }
    }
}