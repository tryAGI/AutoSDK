//HintName: G.Models.CreateAssetResponseUploadUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presigned S3 URL for uploading the asset file using HTTP PUT. Only present when the asset type is VIDEO.
    /// </summary>
    public sealed partial class CreateAssetResponseUploadUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}