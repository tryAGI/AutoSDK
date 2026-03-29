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
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryFilesRequest" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// The unique identifier of the files to retry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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