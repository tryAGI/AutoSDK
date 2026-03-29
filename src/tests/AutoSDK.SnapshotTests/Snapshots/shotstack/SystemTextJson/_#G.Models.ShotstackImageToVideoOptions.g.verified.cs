//HintName: G.Models.ShotstackImageToVideoOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for the Shotstack image-to-video service. Set the URL of an image to convert in to a video. The output will be generated as an MP4 file available at the URL returned in the response.
    /// </summary>
    public sealed partial class ShotstackImageToVideoOptions
    {
        /// <summary>
        /// The type of asset to generate - set to `image-to-video` for image-to-video.<br/>
        /// Default Value: image-to-video
        /// </summary>
        /// <default>global::G.ShotstackImageToVideoOptionsType.ImageToVideo</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShotstackImageToVideoOptionsTypeJsonConverter))]
        public global::G.ShotstackImageToVideoOptionsType Type { get; set; } = global::G.ShotstackImageToVideoOptionsType.ImageToVideo;

        /// <summary>
        /// The URL of the image to convert to video. The URL must be publicly accessible or include credentials. The image dimensions must exactly match one of the following: 1024px x 576px, 576px x 1024px or 768px x 768px.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// The guidance scale determines how closely the generated video will match the image. Lower numbers allow for more creative freedom. A number between 0 and 10.<br/>
        /// Default Value: 1.8F<br/>
        /// Example: 1.8F
        /// </summary>
        /// <example>1.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidanceScale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// The amount of motion in the video. A number between 1 and 255.<br/>
        /// Default Value: 127<br/>
        /// Example: 127
        /// </summary>
        /// <example>127</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("motion")]
        public int? Motion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackImageToVideoOptions" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// The URL of the image to convert to video. The URL must be publicly accessible or include credentials. The image dimensions must exactly match one of the following: 1024px x 576px, 576px x 1024px or 768px x 768px.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </param>
        /// <param name="guidanceScale">
        /// The guidance scale determines how closely the generated video will match the image. Lower numbers allow for more creative freedom. A number between 0 and 10.<br/>
        /// Default Value: 1.8F<br/>
        /// Example: 1.8F
        /// </param>
        /// <param name="motion">
        /// The amount of motion in the video. A number between 1 and 255.<br/>
        /// Default Value: 127<br/>
        /// Example: 127
        /// </param>
        /// <param name="type">
        /// The type of asset to generate - set to `image-to-video` for image-to-video.<br/>
        /// Default Value: image-to-video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShotstackImageToVideoOptions(
            string imageUrl,
            double? guidanceScale,
            int? motion,
            global::G.ShotstackImageToVideoOptionsType type = global::G.ShotstackImageToVideoOptionsType.ImageToVideo)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.GuidanceScale = guidanceScale;
            this.Motion = motion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShotstackImageToVideoOptions" /> class.
        /// </summary>
        public ShotstackImageToVideoOptions()
        {
        }
    }
}