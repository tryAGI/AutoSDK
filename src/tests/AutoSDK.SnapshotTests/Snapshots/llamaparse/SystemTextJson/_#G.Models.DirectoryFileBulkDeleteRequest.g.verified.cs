//HintName: G.Models.DirectoryFileBulkDeleteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request schema for bulk deleting directory files.
    /// </summary>
    public sealed partial class DirectoryFileBulkDeleteRequest
    {
        /// <summary>
        /// List of directory file IDs to delete (max 100).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_file_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DirectoryFileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileBulkDeleteRequest" /> class.
        /// </summary>
        /// <param name="directoryFileIds">
        /// List of directory file IDs to delete (max 100).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryFileBulkDeleteRequest(
            global::System.Collections.Generic.IList<string> directoryFileIds)
        {
            this.DirectoryFileIds = directoryFileIds ?? throw new global::System.ArgumentNullException(nameof(directoryFileIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileBulkDeleteRequest" /> class.
        /// </summary>
        public DirectoryFileBulkDeleteRequest()
        {
        }
    }
}