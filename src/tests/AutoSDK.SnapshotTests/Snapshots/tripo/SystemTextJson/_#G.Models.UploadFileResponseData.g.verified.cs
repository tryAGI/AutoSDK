//HintName: G.Models.UploadFileResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadFileResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileResponseData" /> class.
        /// </summary>
        /// <param name="imageToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadFileResponseData(
            string imageToken)
        {
            this.ImageToken = imageToken ?? throw new global::System.ArgumentNullException(nameof(imageToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileResponseData" /> class.
        /// </summary>
        public UploadFileResponseData()
        {
        }
    }
}