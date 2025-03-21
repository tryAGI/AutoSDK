//HintName: G.Models.InputImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
    /// </summary>
    public sealed partial class InputImage
    {
        /// <summary>
        /// The type of the input item. Always `input_image`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputImageType Type { get; set; }

        /// <summary>
        /// The URL of the image to be sent to the model. A fully qualified URL or<br/>
        /// base64 encoded image in a data URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The ID of the file to be sent to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`,<br/>
        /// `low`, or `auto`. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::G.InputImageDetail.Auto</default>
        [global::Newtonsoft.Json.JsonProperty("detail", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputImageDetail Detail { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImage" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the input item. Always `input_image`.
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the image to be sent to the model. A fully qualified URL or<br/>
        /// base64 encoded image in a data URL.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file to be sent to the model.
        /// </param>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`,<br/>
        /// `low`, or `auto`. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        public InputImage(
            global::G.InputImageDetail detail,
            global::G.InputImageType type,
            string? imageUrl,
            string? fileId)
        {
            this.Detail = detail;
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImage" /> class.
        /// </summary>
        public InputImage()
        {
        }
    }
}