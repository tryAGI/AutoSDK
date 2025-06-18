//HintName: G.Models.CreateImageEditRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateImageEditRequest
    {
        /// <summary>
        /// The image(s) to edit. Must be a supported image file or an array of images.<br/>
        /// For `gpt-image-1`, each image should be a `png`, `webp`, or `jpg` file less <br/>
        /// than 50MB. You can provide up to 16 images.<br/>
        /// For `dall-e-2`, you can only provide one image, and it should be a square <br/>
        /// `png` file less than 4MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<byte[], global::System.Collections.Generic.IList<byte[]>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>> Image { get; set; }

        /// <summary>
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2`, and 32000 characters for `gpt-image-1`.<br/>
        /// Example: A cute baby sea otter wearing a beret
        /// </summary>
        /// <example>A cute baby sea otter wearing a beret</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageEditRequestBackgroundJsonConverter))]
        public global::G.CreateImageEditRequestBackground? Background { get; set; }

        /// <summary>
        /// The model to use for image generation. Only `dall-e-2` and `gpt-image-1` are supported. Defaults to `dall-e-2` unless a parameter specific to `gpt-image-1` is used.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: gpt-image-1
        /// </summary>
        /// <example>gpt-image-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateImageEditRequestModel?>))]
        public global::G.AnyOf<string, global::G.CreateImageEditRequestModel?>? Model { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// The size of the generated images. Must be one of `1024x1024`, `1536x1024` (landscape), `1024x1536` (portrait), or `auto` (default value) for `gpt-image-1`, and one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageEditRequestSizeJsonConverter))]
        public global::G.CreateImageEditRequestSize? Size { get; set; }

        /// <summary>
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter is only supported for `dall-e-2`, as `gpt-image-1` will always return base64-encoded images.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </summary>
        /// <example>url</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageEditRequestResponseFormatJsonConverter))]
        public global::G.CreateImageEditRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// The format in which the generated images are returned. This parameter is<br/>
        /// only supported for `gpt-image-1`. Must be one of `png`, `jpeg`, or `webp`.<br/>
        /// The default value is `png`.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </summary>
        /// <example>png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageEditRequestOutputFormatJsonConverter))]
        public global::G.CreateImageEditRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// The compression level (0-100%) for the generated images. This parameter <br/>
        /// is only supported for `gpt-image-1` with the `webp` or `jpeg` output <br/>
        /// formats, and defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// The quality of the image that will be generated. `high`, `medium` and `low` are only supported for `gpt-image-1`. `dall-e-2` only supports `standard` quality. Defaults to `auto`.<br/>
        /// Default Value: auto<br/>
        /// Example: high
        /// </summary>
        /// <example>high</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateImageEditRequestQualityJsonConverter))]
        public global::G.CreateImageEditRequestQuality? Quality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageEditRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image(s) to edit. Must be a supported image file or an array of images.<br/>
        /// For `gpt-image-1`, each image should be a `png`, `webp`, or `jpg` file less <br/>
        /// than 50MB. You can provide up to 16 images.<br/>
        /// For `dall-e-2`, you can only provide one image, and it should be a square <br/>
        /// `png` file less than 4MB.
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2`, and 32000 characters for `gpt-image-1`.<br/>
        /// Example: A cute baby sea otter wearing a beret
        /// </param>
        /// <param name="mask">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
        /// </param>
        /// <param name="maskname">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where `image` should be edited. If there are multiple images provided, the mask will be applied on the first image. Must be a valid PNG file, less than 4MB, and have the same dimensions as `image`.
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
        /// <param name="model">
        /// The model to use for image generation. Only `dall-e-2` and `gpt-image-1` are supported. Defaults to `dall-e-2` unless a parameter specific to `gpt-image-1` is used.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: gpt-image-1
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `1024x1024`, `1536x1024` (landscape), `1024x1536` (portrait), or `auto` (default value) for `gpt-image-1`, and one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="responseFormat">
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter is only supported for `dall-e-2`, as `gpt-image-1` will always return base64-encoded images.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </param>
        /// <param name="outputFormat">
        /// The format in which the generated images are returned. This parameter is<br/>
        /// only supported for `gpt-image-1`. Must be one of `png`, `jpeg`, or `webp`.<br/>
        /// The default value is `png`.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </param>
        /// <param name="outputCompression">
        /// The compression level (0-100%) for the generated images. This parameter <br/>
        /// is only supported for `gpt-image-1` with the `webp` or `jpeg` output <br/>
        /// formats, and defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated. `high`, `medium` and `low` are only supported for `gpt-image-1`. `dall-e-2` only supports `standard` quality. Defaults to `auto`.<br/>
        /// Default Value: auto<br/>
        /// Example: high
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateImageEditRequest(
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<byte[]>> image,
            string prompt,
            byte[]? mask,
            string? maskname,
            global::G.CreateImageEditRequestBackground? background,
            global::G.AnyOf<string, global::G.CreateImageEditRequestModel?>? model,
            int? n,
            global::G.CreateImageEditRequestSize? size,
            global::G.CreateImageEditRequestResponseFormat? responseFormat,
            global::G.CreateImageEditRequestOutputFormat? outputFormat,
            int? outputCompression,
            string? user,
            global::G.CreateImageEditRequestQuality? quality)
        {
            this.Image = image;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Mask = mask;
            this.Maskname = maskname;
            this.Background = background;
            this.Model = model;
            this.N = n;
            this.Size = size;
            this.ResponseFormat = responseFormat;
            this.OutputFormat = outputFormat;
            this.OutputCompression = outputCompression;
            this.User = user;
            this.Quality = quality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageEditRequest" /> class.
        /// </summary>
        public CreateImageEditRequest()
        {
        }
    }
}