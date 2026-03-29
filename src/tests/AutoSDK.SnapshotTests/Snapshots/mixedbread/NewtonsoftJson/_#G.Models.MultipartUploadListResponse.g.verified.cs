//HintName: G.Models.MultipartUploadListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultipartUploadListResponse
    {
        /// <summary>
        /// List of in-progress multipart uploads
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MultipartUploadObject> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of in-progress multipart uploads
        /// </param>
        public MultipartUploadListResponse(
            global::System.Collections.Generic.IList<global::G.MultipartUploadObject> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartUploadListResponse" /> class.
        /// </summary>
        public MultipartUploadListResponse()
        {
        }
    }
}