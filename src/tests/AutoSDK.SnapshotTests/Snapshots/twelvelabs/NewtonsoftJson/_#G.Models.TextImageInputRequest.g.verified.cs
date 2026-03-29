//HintName: G.Models.TextImageInputRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is required if the `input_type` parameter is `text_image`.
    /// </summary>
    public sealed partial class TextImageInputRequest
    {
        /// <summary>
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MediaSource MediaSource { get; set; } = default!;

        /// <summary>
        /// The text for which you wish to create an embedding. The maximul length is 500 tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string InputText { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextImageInputRequest" /> class.
        /// </summary>
        /// <param name="mediaSource">
        /// An object specifying the source of the media file. You must provide exactly one of `url`, `base64_string`, or `asset_id`.
        /// </param>
        /// <param name="inputText">
        /// The text for which you wish to create an embedding. The maximul length is 500 tokens.
        /// </param>
        public TextImageInputRequest(
            global::G.MediaSource mediaSource,
            string inputText)
        {
            this.MediaSource = mediaSource ?? throw new global::System.ArgumentNullException(nameof(mediaSource));
            this.InputText = inputText ?? throw new global::System.ArgumentNullException(nameof(inputText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextImageInputRequest" /> class.
        /// </summary>
        public TextImageInputRequest()
        {
        }
    }
}