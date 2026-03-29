//HintName: G.Models.LumaAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The LumaAsset is used to create luma matte masks, transitions and effects between other assets. A luma matte is a grey scale image or animated video where the black areas are transparent and the white areas solid. The luma matte animation should be provided as an mp4 video file. The src must be a publicly accessible URL to the file.
    /// </summary>
    public sealed partial class LumaAsset
    {
        /// <summary>
        /// The type of asset - set to `luma` for luma mattes.<br/>
        /// Default Value: luma
        /// </summary>
        /// <default>global::G.LumaAssetType.Luma</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LumaAssetTypeJsonConverter))]
        public global::G.LumaAssetType Type { get; set; } = global::G.LumaAssetType.Luma;

        /// <summary>
        /// The luma matte source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/mask.mp4
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/mask.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// The start trim point of the luma matte clip, in seconds (defaults to 0). Videos will start from the in trim point. A luma matte video will play until the file ends or the Clip length is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim")]
        public double? Trim { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LumaAsset" /> class.
        /// </summary>
        /// <param name="src">
        /// The luma matte source URL. The URL must be publicly accessible or include credentials.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/mask.mp4
        /// </param>
        /// <param name="trim">
        /// The start trim point of the luma matte clip, in seconds (defaults to 0). Videos will start from the in trim point. A luma matte video will play until the file ends or the Clip length is reached.
        /// </param>
        /// <param name="type">
        /// The type of asset - set to `luma` for luma mattes.<br/>
        /// Default Value: luma
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LumaAsset(
            string src,
            double? trim,
            global::G.LumaAssetType type = global::G.LumaAssetType.Luma)
        {
            this.Type = type;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Trim = trim;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LumaAsset" /> class.
        /// </summary>
        public LumaAsset()
        {
        }
    }
}