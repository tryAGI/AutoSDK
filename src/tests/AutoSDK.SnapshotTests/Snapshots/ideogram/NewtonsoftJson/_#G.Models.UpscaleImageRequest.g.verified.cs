//HintName: G.Models.UpscaleImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpscaleImageRequest
    {
        /// <summary>
        /// A request to upscale a provided image with the help of an optional prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpscaleInitialImageRequest ImageRequest { get; set; } = default!;

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
    }
}