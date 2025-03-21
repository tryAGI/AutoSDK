//HintName: G.Models.CompleteUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompleteUploadRequest
    {
        /// <summary>
        /// The ordered list of Part IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PartIds { get; set; }

        /// <summary>
        /// The optional md5 checksum for the file contents to verify if the bytes uploaded matches what you expect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md5")]
        public string? Md5 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteUploadRequest" /> class.
        /// </summary>
        /// <param name="partIds">
        /// The ordered list of Part IDs.
        /// </param>
        /// <param name="md5">
        /// The optional md5 checksum for the file contents to verify if the bytes uploaded matches what you expect.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompleteUploadRequest(
            global::System.Collections.Generic.IList<string> partIds,
            string? md5)
        {
            this.PartIds = partIds ?? throw new global::System.ArgumentNullException(nameof(partIds));
            this.Md5 = md5;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteUploadRequest" /> class.
        /// </summary>
        public CompleteUploadRequest()
        {
        }
    }
}