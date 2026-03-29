//HintName: G.Models.LettaImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaImage
    {
        /// <summary>
        /// The source type for the image.<br/>
        /// Default Value: letta
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The unique identifier of the image file persisted in storage.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The media type for the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// The base64 encoded image data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// What level of detail to use when processing and understanding the image (low, high, or auto to let the model decide)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaImage" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier of the image file persisted in storage.
        /// </param>
        /// <param name="type">
        /// The source type for the image.<br/>
        /// Default Value: letta
        /// </param>
        /// <param name="mediaType">
        /// The media type for the image.
        /// </param>
        /// <param name="data">
        /// The base64 encoded image data.
        /// </param>
        /// <param name="detail">
        /// What level of detail to use when processing and understanding the image (low, high, or auto to let the model decide)
        /// </param>
        public LettaImage(
            string fileId,
            string? type,
            string? mediaType,
            string? data,
            string? detail)
        {
            this.Type = type;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.MediaType = mediaType;
            this.Data = data;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaImage" /> class.
        /// </summary>
        public LettaImage()
        {
        }
    }
}