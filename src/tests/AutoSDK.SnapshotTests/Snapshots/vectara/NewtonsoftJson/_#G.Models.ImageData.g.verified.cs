//HintName: G.Models.ImageData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing an image's binary data and format information. The image data is provided as a Base64-encoded string along with its MIME type.
    /// </summary>
    public sealed partial class ImageData
    {
        /// <summary>
        /// Base64-encoded representation of the image data.<br/>
        /// Example: iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAIAAACQd1PeAAAADElEQVR4nGP4//8/AAX+Av4N70a4AAAAAElFTkSuQmCC
        /// </summary>
        /// <example>iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAIAAACQd1PeAAAADElEQVR4nGP4//8/AAX+Av4N70a4AAAAAElFTkSuQmCC</example>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Data { get; set; } = default!;

        /// <summary>
        /// The MIME type of the image, indicating the format of the binary data (e.g., image/jpeg for JPEG images).<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded representation of the image data.<br/>
        /// Example: iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAIAAACQd1PeAAAADElEQVR4nGP4//8/AAX+Av4N70a4AAAAAElFTkSuQmCC
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the image, indicating the format of the binary data (e.g., image/jpeg for JPEG images).<br/>
        /// Example: image/png
        /// </param>
        public ImageData(
            byte[] data,
            string mimeType)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData" /> class.
        /// </summary>
        public ImageData()
        {
        }
    }
}