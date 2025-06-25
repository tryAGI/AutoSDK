﻿//HintName: G.Models.CreateImageRequest.g.cs

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
        /// A text description of the desired image(s). The maximum length is 32000 characters for `gpt-image-1`, 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.<br/>
        /// Example: A cute baby sea otter
        /// </summary>
        /// <example>A cute baby sea otter</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model to use for image generation. One of `dall-e-2`, `dall-e-3`, or `gpt-image-1`. Defaults to `dall-e-2` unless a parameter specific to `gpt-image-1` is used.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: gpt-image-1
        /// </summary>
        /// <example>gpt-image-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateImageRequestModel?>))]
        public global::G.AnyOf<string, global::G.CreateImageRequestModel?>? Model { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// The quality of the image that will be generated. <br/>
        /// - `auto` (default value) will automatically select the best quality for the given model.<br/>
        /// - `high`, `medium` and `low` are supported for `gpt-image-1`.<br/>
        /// - `hd` and `standard` are supported for `dall-e-3`.<br/>
        /// - `standard` is the only option for `dall-e-2`.<br/>
        /// Default Value: auto<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageRequestQualityJsonConverter))]
        public global::G.CreateImageRequestQuality? Quality { get; set; }

        /// <summary>
        /// The format in which generated images with `dall-e-2` and `dall-e-3` are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter isn't supported for `gpt-image-1` which will always return base64-encoded images.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </summary>
        /// <example>url</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageRequestResponseFormatJsonConverter))]
        public global::G.CreateImageRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The format in which the generated images are returned. This parameter is only supported for `gpt-image-1`. Must be one of `png`, `jpeg`, or `webp`.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </summary>
        /// <example>png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageRequestOutputFormatJsonConverter))]
        public global::G.CreateImageRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The compression level (0-100%) for the generated images. This parameter is only supported for `gpt-image-1` with the `webp` or `jpeg` output formats, and defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// The size of the generated images. Must be one of `1024x1024`, `1536x1024` (landscape), `1024x1536` (portrait), or `auto` (default value) for `gpt-image-1`, one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`, and one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3`.<br/>
        /// Default Value: auto<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageRequestSizeJsonConverter))]
        public global::G.CreateImageRequestSize? Size { get; set; }

        /// <summary>
        /// Control the content-moderation level for images generated by `gpt-image-1`. Must be either `low` for less restrictive filtering or `auto` (default value).<br/>
        /// Default Value: auto<br/>
        /// Example: low
        /// </summary>
        /// <example>low</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageRequestModerationJsonConverter))]
        public global::G.CreateImageRequestModeration? Moderation { get; set; }

        /// <summary>
        /// Allows to set transparency for the background of the generated image(s). <br/>
        /// This parameter is only supported for `gpt-image-1`. Must be one of <br/>
        /// `transparent`, `opaque` or `auto` (default value). When `auto` is used, the <br/>
        /// model will automatically determine the best background for the image.<br/>
        /// If `transparent`, the output format needs to support transparency, so it <br/>
        /// should be set to either `png` (default value) or `webp`.<br/>
        /// Default Value: auto<br/>
        /// Example: transparent
        /// </summary>
        /// <example>transparent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageRequestBackgroundJsonConverter))]
        public global::G.CreateImageRequestBackground? Background { get; set; }

        /// <summary>
        /// The style of the generated images. This parameter is only supported for `dall-e-3`. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images.<br/>
        /// Default Value: vivid<br/>
        /// Example: vivid
        /// </summary>
        /// <example>vivid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageRequestStyleJsonConverter))]
        public global::G.CreateImageRequestStyle? Style { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 32000 characters for `gpt-image-1`, 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.<br/>
        /// Example: A cute baby sea otter
        /// </param>
        /// <param name="model">
        /// The model to use for image generation. One of `dall-e-2`, `dall-e-3`, or `gpt-image-1`. Defaults to `dall-e-2` unless a parameter specific to `gpt-image-1` is used.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: gpt-image-1
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated. <br/>
        /// - `auto` (default value) will automatically select the best quality for the given model.<br/>
        /// - `high`, `medium` and `low` are supported for `gpt-image-1`.<br/>
        /// - `hd` and `standard` are supported for `dall-e-3`.<br/>
        /// - `standard` is the only option for `dall-e-2`.<br/>
        /// Default Value: auto<br/>
        /// Example: medium
        /// </param>
        /// <param name="responseFormat">
        /// The format in which generated images with `dall-e-2` and `dall-e-3` are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter isn't supported for `gpt-image-1` which will always return base64-encoded images.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </param>
        /// <param name="outputFormat">
        /// The format in which the generated images are returned. This parameter is only supported for `gpt-image-1`. Must be one of `png`, `jpeg`, or `webp`.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </param>
        /// <param name="outputCompression">
        /// The compression level (0-100%) for the generated images. This parameter is only supported for `gpt-image-1` with the `webp` or `jpeg` output formats, and defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `1024x1024`, `1536x1024` (landscape), `1024x1536` (portrait), or `auto` (default value) for `gpt-image-1`, one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`, and one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3`.<br/>
        /// Default Value: auto<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="moderation">
        /// Control the content-moderation level for images generated by `gpt-image-1`. Must be either `low` for less restrictive filtering or `auto` (default value).<br/>
        /// Default Value: auto<br/>
        /// Example: low
        /// </param>
        /// <param name="background">
        /// Allows to set transparency for the background of the generated image(s). <br/>
        /// This parameter is only supported for `gpt-image-1`. Must be one of <br/>
        /// `transparent`, `opaque` or `auto` (default value). When `auto` is used, the <br/>
        /// model will automatically determine the best background for the image.<br/>
        /// If `transparent`, the output format needs to support transparency, so it <br/>
        /// should be set to either `png` (default value) or `webp`.<br/>
        /// Default Value: auto<br/>
        /// Example: transparent
        /// </param>
        /// <param name="style">
        /// The style of the generated images. This parameter is only supported for `dall-e-3`. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images.<br/>
        /// Default Value: vivid<br/>
        /// Example: vivid
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageRequest(
            string prompt,
            global::G.AnyOf<string, global::G.CreateImageRequestModel?>? model,
            int? n,
            global::G.CreateImageRequestQuality? quality,
            global::G.CreateImageRequestResponseFormat? responseFormat,
            global::G.CreateImageRequestOutputFormat? outputFormat,
            int? outputCompression,
            global::G.CreateImageRequestSize? size,
            global::G.CreateImageRequestModeration? moderation,
            global::G.CreateImageRequestBackground? background,
            global::G.CreateImageRequestStyle? style,
            string? user)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.N = n;
            this.Quality = quality;
            this.ResponseFormat = responseFormat;
            this.OutputFormat = outputFormat;
            this.OutputCompression = outputCompression;
            this.Size = size;
            this.Moderation = moderation;
            this.Background = background;
            this.Style = style;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageRequest" /> class.
        /// </summary>
        public CreateImageRequest()
        {
        }
    }
}