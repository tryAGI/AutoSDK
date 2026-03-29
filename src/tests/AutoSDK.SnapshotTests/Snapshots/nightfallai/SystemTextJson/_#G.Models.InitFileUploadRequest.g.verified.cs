//HintName: G.Models.InitFileUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitFileUploadRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSizeBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitFileUploadRequest" /> class.
        /// </summary>
        /// <param name="fileSizeBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitFileUploadRequest(
            long fileSizeBytes)
        {
            this.FileSizeBytes = fileSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitFileUploadRequest" /> class.
        /// </summary>
        public InitFileUploadRequest()
        {
        }
    }
}