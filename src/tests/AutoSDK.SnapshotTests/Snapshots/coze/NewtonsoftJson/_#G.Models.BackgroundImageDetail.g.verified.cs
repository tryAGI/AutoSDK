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
        [global::Newtonsoft.Json.JsonProperty("canvas_position")]
        public global::G.CanvasPosition1? CanvasPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gradient_position")]
        public global::G.GradientPosition1? GradientPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("theme_color")]
        public string? ThemeColor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundImageDetail" /> class.
        /// </summary>
        /// <param name="canvasPosition"></param>
        /// <param name="gradientPosition"></param>
        /// <param name="imageUrl"></param>
        /// <param name="themeColor"></param>
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