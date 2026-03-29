//HintName: G.Models.DubbedAssetThumbnail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbedAssetThumbnail
    {
        /// <summary>
        /// A time-limited URL which may be used to download the video thumbnail.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// A time-limited URL which may be used to download the video animated GIF thumbnail.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gif")]
        public string? Gif { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetThumbnail" /> class.
        /// </summary>
        /// <param name="image">
        /// A time-limited URL which may be used to download the video thumbnail.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="gif">
        /// A time-limited URL which may be used to download the video animated GIF thumbnail.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbedAssetThumbnail(
            string? image,
            string? gif)
        {
            this.Image = image;
            this.Gif = gif;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetThumbnail" /> class.
        /// </summary>
        public DubbedAssetThumbnail()
        {
        }
    }
}