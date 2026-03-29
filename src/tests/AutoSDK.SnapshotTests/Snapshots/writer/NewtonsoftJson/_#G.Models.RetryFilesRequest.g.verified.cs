//HintName: G.Models.RetryFilesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetryFilesRequest
    {
        /// <summary>
        /// The unique identifier of the files to retry.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> FileIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryFilesRequest" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// The unique identifier of the files to retry.
        /// </param>
        public RetryFilesRequest(
            global::System.Collections.Generic.IList<global::System.Guid> fileIds)
        {
            this.FileIds = fileIds ?? throw new global::System.ArgumentNullException(nameof(fileIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryFilesRequest" /> class.
        /// </summary>
        public RetryFilesRequest()
        {
        }
    }
}