//HintName: G.Models.UploadModelAssetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadModelAssetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadModelAsset")]
        public global::G.UploadModelAssetResponseUploadModelAsset? UploadModelAsset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelAssetResponse" /> class.
        /// </summary>
        /// <param name="uploadModelAsset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadModelAssetResponse(
            global::G.UploadModelAssetResponseUploadModelAsset? uploadModelAsset)
        {
            this.UploadModelAsset = uploadModelAsset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadModelAssetResponse" /> class.
        /// </summary>
        public UploadModelAssetResponse()
        {
        }
    }
}