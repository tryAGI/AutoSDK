//HintName: G.Models.ImageInputRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is required if the  `input_type` parameter is `image`.
    /// </summary>
    public sealed partial class ImageInputRequest
    {
        /// <summary>
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MediaSource MediaSource { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageInputRequest" /> class.
        /// </summary>
        /// <param name="mediaSource">
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </param>
        public ImageInputRequest(
            global::G.MediaSource mediaSource)
        {
            this.MediaSource = mediaSource ?? throw new global::System.ArgumentNullException(nameof(mediaSource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageInputRequest" /> class.
        /// </summary>
        public ImageInputRequest()
        {
        }
    }
}