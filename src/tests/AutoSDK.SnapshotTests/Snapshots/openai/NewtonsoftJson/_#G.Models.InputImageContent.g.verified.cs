//HintName: G.Models.InputImageContent.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An image input to the model. Learn about [image inputs](/docs/guides/vision).
    /// </summary>
    public sealed partial class InputImageContent
    {
        /// <summary>
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </summary>
        /// <default>global::G.InputImageContentType.InputImage</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputImageContentType Type { get; set; } = global::G.InputImageContentType.InputImage;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public global::G.AnyOf<string, object>? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public global::G.AnyOf<string, object>? FileId { get; set; }

        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputImageContentDetail Detail { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the input item. Always `input_image`.<br/>
        /// Default Value: input_image
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="fileId"></param>
        /// <param name="detail">
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </param>
        public InputImageContent(
            global::G.InputImageContentDetail detail,
            global::G.AnyOf<string, object>? imageUrl,
            global::G.AnyOf<string, object>? fileId,
            global::G.InputImageContentType type = global::G.InputImageContentType.InputImage)
        {
            this.Detail = detail;
            this.Type = type;
            this.ImageUrl = imageUrl;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImageContent" /> class.
        /// </summary>
        public InputImageContent()
        {
        }
    }
}