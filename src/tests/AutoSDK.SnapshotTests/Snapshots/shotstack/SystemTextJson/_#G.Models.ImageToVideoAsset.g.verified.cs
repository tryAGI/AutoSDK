//HintName: G.Models.ImageToVideoAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ImageToVideoAsset lets you create a video from an image and a text prompt.
    /// </summary>
    public sealed partial class ImageToVideoAsset
    {
        /// <summary>
        /// The type of asset to generate - set to `image-to-video` for image-to-video.<br/>
        /// Default Value: image-to-video
        /// </summary>
        /// <default>global::G.ImageToVideoAssetType.ImageToVideo</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageToVideoAssetTypeJsonConverter))]
        public global::G.ImageToVideoAssetType Type { get; set; } = global::G.ImageToVideoAssetType.ImageToVideo;

        /// <summary>
        /// The image source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// The instructions for modifying the image into a video sequence.<br/>
        /// Example: Slowly zoom out and orbit left around the object.
        /// </summary>
        /// <example>Slowly zoom out and orbit left around the object.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The aspect ratio (shape) of the video output.<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageToVideoAssetAspectRatioJsonConverter))]
        public global::G.ImageToVideoAssetAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Adjust the playback speed of the video clip between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to  adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire video (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire video (i.e. original length / 2).<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        public global::G.Crop? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The image source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </param>
        /// <param name="prompt">
        /// The instructions for modifying the image into a video sequence.<br/>
        /// Example: Slowly zoom out and orbit left around the object.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio (shape) of the video output.<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="speed">
        /// Adjust the playback speed of the video clip between 0 (paused) and 10 (10x normal speed) where 1 is normal speed (defaults to 1). Adjusting the speed will also adjust the duration of the clip and may require you to  adjust the Clip length. For example, if you set speed to 0.5, the clip will need to be 2x as long to play the entire video (i.e. original length / 0.5). If you set speed to 2, the clip will need to be half as long to play the entire video (i.e. original length / 2).<br/>
        /// Example: 1
        /// </param>
        /// <param name="crop">
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </param>
        /// <param name="type">
        /// The type of asset to generate - set to `image-to-video` for image-to-video.<br/>
        /// Default Value: image-to-video
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageToVideoAsset(
            string src,
            string? prompt,
            global::G.ImageToVideoAssetAspectRatio? aspectRatio,
            float? speed,
            global::G.Crop? crop,
            global::G.ImageToVideoAssetType type = global::G.ImageToVideoAssetType.ImageToVideo)
        {
            this.Type = type;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Prompt = prompt;
            this.AspectRatio = aspectRatio;
            this.Speed = speed;
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToVideoAsset" /> class.
        /// </summary>
        public ImageToVideoAsset()
        {
        }
    }
}