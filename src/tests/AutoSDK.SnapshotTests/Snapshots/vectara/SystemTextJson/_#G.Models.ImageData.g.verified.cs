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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Data { get; set; }

        /// <summary>
        /// The MIME type of the image, indicating the format of the binary data (e.g., image/jpeg for JPEG images).<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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