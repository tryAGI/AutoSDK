//HintName: G.Models.ImageAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ImageAsset is used to create video from images to compose an image. The src must be a publicly accessible URL to an image resource such as a jpg or png file.
    /// </summary>
    public sealed partial class ImageAsset
    {
        /// <summary>
        /// The type of asset - set to `image` for images.<br/>
        /// Default Value: image
        /// </summary>
        /// <default>global::G.ImageAssetType.Image</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageAssetTypeJsonConverter))]
        public global::G.ImageAssetType Type { get; set; } = global::G.ImageAssetType.Image;

        /// <summary>
        /// The image source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

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
        /// Initializes a new instance of the <see cref="ImageAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The image source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/image.jpg
        /// </param>
        /// <param name="crop">
        /// Crop the sides of an asset by a relative amount. The size of the crop is specified using a scale between 0 and 1, relative to the screen width - i.e a left crop of 0.5 will crop half of the asset from the left, a top crop  of 0.25 will crop the top by quarter of the asset.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `image` for images.<br/>
        /// Default Value: image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageAsset(
            string src,
            global::G.Crop? crop,
            global::G.ImageAssetType type = global::G.ImageAssetType.Image)
        {
            this.Type = type;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAsset" /> class.
        /// </summary>
        public ImageAsset()
        {
        }
    }
}