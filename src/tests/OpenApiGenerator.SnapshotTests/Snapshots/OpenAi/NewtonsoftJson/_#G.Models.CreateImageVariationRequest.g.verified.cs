//HintName: G.Models.CreateImageVariationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageVariationRequest
    {
        /// <summary>
        /// The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB, and square.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Image { get; set; } = default!;

        /// <summary>
        /// The model to use for image generation. Only `dall-e-2` is supported at this time.
        /// <br/>Default Value: dall-e-2
        /// <br/>Example: dall-e-2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::System.AnyOf<string?, global::G.CreateImageVariationRequestModel?>? Model { get; set; } = global::G.CreateImageVariationRequestModel.DallE2;

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; } = 1;

        /// <summary>
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.
        /// <br/>Default Value: url
        /// <br/>Example: url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.CreateImageVariationRequestResponseFormat? ResponseFormat { get; set; } = global::G.CreateImageVariationRequestResponseFormat.Url;

        /// <summary>
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.
        /// <br/>Default Value: 1024x1024
        /// <br/>Example: 1024x1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public global::G.CreateImageVariationRequestSize? Size { get; set; } = global::G.CreateImageVariationRequestSize._1024x1024;

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// <br/>Example: user-1234
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}