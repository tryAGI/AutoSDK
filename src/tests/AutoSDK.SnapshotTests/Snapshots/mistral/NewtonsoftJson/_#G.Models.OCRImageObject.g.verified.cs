//HintName: G.Models.OCRImageObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRImageObject
    {
        /// <summary>
        /// X coordinate of bottom-right corner of the extracted image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bottom_right_x", Required = global::Newtonsoft.Json.Required.Always)]
        public int? BottomRightX { get; set; } = default!;

        /// <summary>
        /// Y coordinate of bottom-right corner of the extracted image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bottom_right_y", Required = global::Newtonsoft.Json.Required.Always)]
        public int? BottomRightY { get; set; } = default!;

        /// <summary>
        /// Image ID for extracted image in a page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Base64 string of the extracted image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_base64")]
        public string? ImageBase64 { get; set; }

        /// <summary>
        /// X coordinate of top-left corner of the extracted image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_left_x", Required = global::Newtonsoft.Json.Required.Always)]
        public int? TopLeftX { get; set; } = default!;

        /// <summary>
        /// Y coordinate of top-left corner of the extracted image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_left_y", Required = global::Newtonsoft.Json.Required.Always)]
        public int? TopLeftY { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRImageObject" /> class.
        /// </summary>
        /// <param name="bottomRightX">
        /// X coordinate of bottom-right corner of the extracted image
        /// </param>
        /// <param name="bottomRightY">
        /// Y coordinate of bottom-right corner of the extracted image
        /// </param>
        /// <param name="id">
        /// Image ID for extracted image in a page
        /// </param>
        /// <param name="imageBase64">
        /// Base64 string of the extracted image
        /// </param>
        /// <param name="topLeftX">
        /// X coordinate of top-left corner of the extracted image
        /// </param>
        /// <param name="topLeftY">
        /// Y coordinate of top-left corner of the extracted image
        /// </param>
        public OCRImageObject(
            int? bottomRightX,
            int? bottomRightY,
            string id,
            int? topLeftX,
            int? topLeftY,
            string? imageBase64)
        {
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.ImageBase64 = imageBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRImageObject" /> class.
        /// </summary>
        public OCRImageObject()
        {
        }
    }
}