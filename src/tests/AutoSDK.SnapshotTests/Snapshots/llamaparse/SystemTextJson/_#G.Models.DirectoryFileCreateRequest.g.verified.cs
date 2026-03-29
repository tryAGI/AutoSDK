//HintName: G.Models.DirectoryFileCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request schema for creating a directory file.
    /// </summary>
    public sealed partial class DirectoryFileCreateRequest
    {
        /// <summary>
        /// File ID for the storage location (required).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Unique identifier for the file in the directory. If not provided, will use the file's external_file_id or name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// Display name for the file. If not provided, will use the file's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileCreateRequest" /> class.
        /// </summary>
        /// <param name="fileId">
        /// File ID for the storage location (required).
        /// </param>
        /// <param name="uniqueId">
        /// Unique identifier for the file in the directory. If not provided, will use the file's external_file_id or name.
        /// </param>
        /// <param name="displayName">
        /// Display name for the file. If not provided, will use the file's name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryFileCreateRequest(
            string fileId,
            string? uniqueId,
            string? displayName)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.UniqueId = uniqueId;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileCreateRequest" /> class.
        /// </summary>
        public DirectoryFileCreateRequest()
        {
        }
    }
}