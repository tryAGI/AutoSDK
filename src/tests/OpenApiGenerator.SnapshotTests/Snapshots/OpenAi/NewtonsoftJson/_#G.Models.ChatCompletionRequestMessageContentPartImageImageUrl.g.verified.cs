//HintName: G.Models.ChatCompletionRequestMessageContentPartImageImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartImageImageUrl
    {
        /// <summary>
        /// Either a URL of the image or the base64 encoded image data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Specifies the detail level of the image. Learn more in the [Vision guide](/docs/guides/vision/low-or-high-fidelity-image-understanding).
        /// <br/>Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.ChatCompletionRequestMessageContentPartImageImageUrlDetail? Detail { get; set; } = global::G.ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}