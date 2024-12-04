//HintName: G.Models.CreateImageVariationRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        /// The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB, and square.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imagename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Imagename { get; set; } = default!;

        /// <summary>
        /// The model to use for image generation. Only `dall-e-2` is supported at this time.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: dall-e-2
        /// </summary>
        /// <example>dall-e-2</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.AnyOf<string, global::G.CreateImageVariationRequestModel?>? Model { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; }

        /// <summary>
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </summary>
        /// <example>url</example>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::G.CreateImageVariationRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public global::G.CreateImageVariationRequestSize? Size { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageVariationRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB, and square.
        /// </param>
        /// <param name="imagename">
        /// The image to use as the basis for the variation(s). Must be a valid PNG file, less than 4MB, and square.
        /// </param>
        /// <param name="model">
        /// The model to use for image generation. Only `dall-e-2` is supported at this time.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: dall-e-2
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="responseFormat">
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        public CreateImageVariationRequest(
            byte[] image,
            string imagename,
            global::G.AnyOf<string, global::G.CreateImageVariationRequestModel?>? model,
            int? n,
            global::G.CreateImageVariationRequestResponseFormat? responseFormat,
            global::G.CreateImageVariationRequestSize? size,
            string? user)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Model = model;
            this.N = n;
            this.ResponseFormat = responseFormat;
            this.Size = size;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageVariationRequest" /> class.
        /// </summary>
        public CreateImageVariationRequest()
        {
        }
    }
}