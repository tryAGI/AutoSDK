//HintName: G.Models.CreateImageRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageRequest
    {
        /// <summary>
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.<br/>
        /// Example: A cute baby sea otter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model to use for image generation.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: dall-e-3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::System.AnyOf<string?, global::G.CreateImageRequestModel?>? Model { get; set; } = global::G.CreateImageRequestModel.DallE2;

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; } = 1;

        /// <summary>
        /// The quality of the image that will be generated. `hd` creates images with finer details and greater consistency across the image. This param is only supported for `dall-e-3`.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CreateImageRequestQualityJsonConverter))]
        public global::G.CreateImageRequestQuality? Quality { get; set; } = global::G.CreateImageRequestQuality.Standard;

        /// <summary>
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CreateImageRequestResponseFormatJsonConverter))]
        public global::G.CreateImageRequestResponseFormat? ResponseFormat { get; set; } = global::G.CreateImageRequestResponseFormat.Url;

        /// <summary>
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CreateImageRequestSizeJsonConverter))]
        public global::G.CreateImageRequestSize? Size { get; set; } = global::G.CreateImageRequestSize._1024x1024;

        /// <summary>
        /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.<br/>
        /// Default Value: vivid<br/>
        /// Example: vivid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CreateImageRequestStyleJsonConverter))]
        public global::G.CreateImageRequestStyle? Style { get; set; } = global::G.CreateImageRequestStyle.Vivid;

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).<br/>
        /// Example: user-1234
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}