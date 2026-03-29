//HintName: G.Models.PaginatedAgentFiles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated response for agent files
    /// </summary>
    public sealed partial class PaginatedAgentFiles
    {
        /// <summary>
        /// List of file attachments for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentFileAttachment> Files { get; set; }

        /// <summary>
        /// Cursor for fetching the next page (file-agent relationship ID)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more results exist after this page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedAgentFiles" /> class.
        /// </summary>
        /// <param name="files">
        /// List of file attachments for the agent
        /// </param>
        /// <param name="hasMore">
        /// Whether more results exist after this page
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page (file-agent relationship ID)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedAgentFiles(
            global::System.Collections.Generic.IList<global::G.AgentFileAttachment> files,
            bool hasMore,
            string? nextCursor)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedAgentFiles" /> class.
        /// </summary>
        public PaginatedAgentFiles()
        {
        }
    }
}