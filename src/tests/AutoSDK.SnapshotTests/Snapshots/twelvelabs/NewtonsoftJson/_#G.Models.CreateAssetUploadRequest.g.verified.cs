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
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The type of asset you want to upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateAssetUploadRequestType Type { get; set; }

        /// <summary>
        /// The total size of the file in bytes. The platform uses this value to:<br/>
        /// - Calculate the optimal chunk size.<br/>
        /// - Determine the total number of chunks required<br/>
        /// - Generate the initial set of presigned URLs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long TotalSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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