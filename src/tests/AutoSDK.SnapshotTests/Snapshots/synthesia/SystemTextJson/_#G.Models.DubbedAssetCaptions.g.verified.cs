//HintName: G.Models.DubbedAssetCaptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbedAssetCaptions
    {
        /// <summary>
        /// A time-limited URL which may be used to download the video captions in srt format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srt")]
        public string? Srt { get; set; }

        /// <summary>
        /// A time-limited URL which may be used to download the video captions in vtt format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vtt")]
        public string? Vtt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetCaptions" /> class.
        /// </summary>
        /// <param name="srt">
        /// A time-limited URL which may be used to download the video captions in srt format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="vtt">
        /// A time-limited URL which may be used to download the video captions in vtt format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbedAssetCaptions(
            string? srt,
            string? vtt)
        {
            this.Srt = srt;
            this.Vtt = vtt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetCaptions" /> class.
        /// </summary>
        public DubbedAssetCaptions()
        {
        }
    }
}