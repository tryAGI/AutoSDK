//HintName: G.Models.BackgroundImageDetail1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundImageDetail1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canvas_position")]
        public global::G.CanvasPosition? CanvasPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gradient_position")]
        public global::G.GradientPosition? GradientPosition { get; set; }

        /// <summary>
        /// 实际使用图片
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_uri")]
        public string? ImageUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 原始图片
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin_image_uri")]
        public string? OriginImageUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin_image_url")]
        public string? OriginImageUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="BackgroundImageDetail1" /> class.
        /// </summary>
        /// <param name="canvasPosition"></param>
        /// <param name="gradientPosition"></param>
        /// <param name="imageUri">
        /// 实际使用图片
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="originImageUri">
        /// 原始图片
        /// </param>
        /// <param name="originImageUrl"></param>
        /// <param name="themeColor"></param>
        public BackgroundImageDetail1(
            global::G.CanvasPosition? canvasPosition,
            global::G.GradientPosition? gradientPosition,
            string? imageUri,
            string? imageUrl,
            string? originImageUri,
            string? originImageUrl,
            string? themeColor)
        {
            this.CanvasPosition = canvasPosition;
            this.GradientPosition = gradientPosition;
            this.ImageUri = imageUri;
            this.ImageUrl = imageUrl;
            this.OriginImageUri = originImageUri;
            this.OriginImageUrl = originImageUrl;
            this.ThemeColor = themeColor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundImageDetail1" /> class.
        /// </summary>
        public BackgroundImageDetail1()
        {
        }
    }
}