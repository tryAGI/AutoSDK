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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComputerScreenshotImageTypeJsonConverter))]
        public global::G.ComputerScreenshotImageType Type { get; set; } = global::G.ComputerScreenshotImageType.ComputerScreenshot;

        /// <summary>
        /// The URL of the screenshot image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The identifier of an uploaded file that contains the screenshot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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