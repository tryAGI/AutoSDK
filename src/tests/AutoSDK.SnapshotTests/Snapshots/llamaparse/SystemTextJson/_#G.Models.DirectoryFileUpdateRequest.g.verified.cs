//HintName: G.Models.DirectoryFileUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request schema for updating a directory file.
    /// </summary>
    public sealed partial class DirectoryFileUpdateRequest
    {
        /// <summary>
        /// Updated unique identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_id")]
        public string? UniqueId { get; set; }

        /// <summary>
        /// Updated display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Move file to a different directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_id")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileUpdateRequest" /> class.
        /// </summary>
        /// <param name="uniqueId">
        /// Updated unique identifier.
        /// </param>
        /// <param name="displayName">
        /// Updated display name.
        /// </param>
        /// <param name="directoryId">
        /// Move file to a different directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryFileUpdateRequest(
            string? uniqueId,
            string? displayName,
            string? directoryId)
        {
            this.UniqueId = uniqueId;
            this.DisplayName = displayName;
            this.DirectoryId = directoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryFileUpdateRequest" /> class.
        /// </summary>
        public DirectoryFileUpdateRequest()
        {
        }
    }
}