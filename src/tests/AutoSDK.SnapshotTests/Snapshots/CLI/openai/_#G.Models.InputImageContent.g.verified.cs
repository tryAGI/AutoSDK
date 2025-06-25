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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputImageContentTypeJsonConverter))]
        public global::G.InputImageContentType Type { get; set; } = global::G.InputImageContentType.InputImage;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::G.AnyOf<string, object>? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, object>))]
        public global::G.AnyOf<string, object>? FileId { get; set; }

        /// <summary>
        /// The detail level of the image to be sent to the model. One of `high`, `low`, or `auto`. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputImageContentDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InputImageContentDetail Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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