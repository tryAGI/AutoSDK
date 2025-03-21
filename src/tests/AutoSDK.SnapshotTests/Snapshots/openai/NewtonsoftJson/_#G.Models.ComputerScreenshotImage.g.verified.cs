//HintName: G.Models.ComputerScreenshotImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A computer screenshot image used with the computer use tool.
    /// </summary>
    public sealed partial class ComputerScreenshotImage
    {
        /// <summary>
        /// Specifies the event type. For a computer screenshot, this property is <br/>
        /// always set to `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </summary>
        /// <default>global::G.ComputerScreenshotImageType.ComputerScreenshot</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ComputerScreenshotImageType Type { get; set; } = global::G.ComputerScreenshotImageType.ComputerScreenshot;

        /// <summary>
        /// The URL of the screenshot image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The identifier of an uploaded file that contains the screenshot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScreenshotImage" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a computer screenshot, this property is <br/>
        /// always set to `computer_screenshot`.<br/>
        /// Default Value: computer_screenshot
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the screenshot image.
        /// </param>
        /// <param name="fileId">
        /// The identifier of an uploaded file that contains the screenshot.
        /// </param>
        public ComputerScreenshotImage(
            string? imageUrl,
            string? fileId,
            global::G.ComputerScreenshotImageType type = global::G.ComputerScreenshotImageType.ComputerScreenshot)
        {
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerScreenshotImage" /> class.
        /// </summary>
        public ComputerScreenshotImage()
        {
        }
    }
}