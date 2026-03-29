//HintName: G.Models.CreateAssetUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetUploadRequest
    {
        /// <summary>
        /// The original file name of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The type of asset you want to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAssetUploadRequestTypeJsonConverter))]
        public global::G.CreateAssetUploadRequestType Type { get; set; }

        /// <summary>
        /// The total size of the file in bytes. The platform uses this value to:<br/>
        /// - Calculate the optimal chunk size.<br/>
        /// - Determine the total number of chunks required<br/>
        /// - Generate the initial set of presigned URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetUploadRequest" /> class.
        /// </summary>
        /// <param name="filename">
        /// The original file name of the asset.
        /// </param>
        /// <param name="totalSize">
        /// The total size of the file in bytes. The platform uses this value to:<br/>
        /// - Calculate the optimal chunk size.<br/>
        /// - Determine the total number of chunks required<br/>
        /// - Generate the initial set of presigned URLs
        /// </param>
        /// <param name="type">
        /// The type of asset you want to upload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetUploadRequest(
            string filename,
            long totalSize,
            global::G.CreateAssetUploadRequestType type)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Type = type;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetUploadRequest" /> class.
        /// </summary>
        public CreateAssetUploadRequest()
        {
        }
    }
}