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
        /// Image ID for extracted image in a page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        /// Base64 string of the extracted image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_base64")]
        public string? ImageBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRImageObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Image ID for extracted image in a page
        /// </param>
        /// <param name="topLeftX">
        /// X coordinate of top-left corner of the extracted image
        /// </param>
        /// <param name="topLeftY">
        /// Y coordinate of top-left corner of the extracted image
        /// </param>
        /// <param name="bottomRightX">
        /// X coordinate of bottom-right corner of the extracted image
        /// </param>
        /// <param name="bottomRightY">
        /// Y coordinate of bottom-right corner of the extracted image
        /// </param>
        /// <param name="imageBase64">
        /// Base64 string of the extracted image
        /// </param>
        public OCRImageObject(
            string id,
            int? topLeftX,
            int? topLeftY,
            int? bottomRightX,
            int? bottomRightY,
            string? imageBase64)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TopLeftX = topLeftX ?? throw new global::System.ArgumentNullException(nameof(topLeftX));
            this.TopLeftY = topLeftY ?? throw new global::System.ArgumentNullException(nameof(topLeftY));
            this.BottomRightX = bottomRightX ?? throw new global::System.ArgumentNullException(nameof(bottomRightX));
            this.BottomRightY = bottomRightY ?? throw new global::System.ArgumentNullException(nameof(bottomRightY));
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