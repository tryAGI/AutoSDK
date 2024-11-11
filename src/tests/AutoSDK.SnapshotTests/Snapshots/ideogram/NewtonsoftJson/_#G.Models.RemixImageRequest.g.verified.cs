//HintName: G.Models.RemixImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A request to generate an image from a source image and a provided caption, provided images are cropped to match the chosen output aspect ratio
    /// </summary>
    public sealed partial class RemixImageRequest
    {
        /// <summary>
        /// A request to generate a new image using a provided image and a prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InitialImageRequest ImageRequest { get; set; } = default!;

        /// <summary>
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] ImageFile { get; set; } = default!;

        /// <summary>
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageFilename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixImageRequest" /> class.
        /// </summary>
        /// <param name="imageRequest">
        /// A request to generate a new image using a provided image and a prompt.
        /// </param>
        /// <param name="imageFile">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="imageFilename">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        public RemixImageRequest(
            global::G.InitialImageRequest imageRequest,
            byte[] imageFile,
            string imageFilename)
        {
            this.ImageRequest = imageRequest ?? throw new global::System.ArgumentNullException(nameof(imageRequest));
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.ImageFilename = imageFilename ?? throw new global::System.ArgumentNullException(nameof(imageFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixImageRequest" /> class.
        /// </summary>
        public RemixImageRequest()
        {
        }
    }
}