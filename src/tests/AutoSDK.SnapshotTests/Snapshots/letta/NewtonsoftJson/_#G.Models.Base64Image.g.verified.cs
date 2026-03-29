//HintName: G.Models.Base64Image.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Base64Image
    {
        /// <summary>
        /// The source type for the image.<br/>
        /// Default Value: base64
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The media type for the image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MediaType { get; set; } = default!;

        /// <summary>
        /// The base64 encoded image data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="Base64Image" /> class.
        /// </summary>
        /// <param name="mediaType">
        /// The media type for the image.
        /// </param>
        /// <param name="data">
        /// The base64 encoded image data.
        /// </param>
        /// <param name="type">
        /// The source type for the image.<br/>
        /// Default Value: base64
        /// </param>
        /// <param name="detail">
        /// What level of detail to use when processing and understanding the image (low, high, or auto to let the model decide)
        /// </param>
        public Base64Image(
            string mediaType,
            string data,
            string? type,
            string? detail)
        {
            this.Type = type;
            this.MediaType = mediaType ?? throw new global::System.ArgumentNullException(nameof(mediaType));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64Image" /> class.
        /// </summary>
        public Base64Image()
        {
        }
    }
}