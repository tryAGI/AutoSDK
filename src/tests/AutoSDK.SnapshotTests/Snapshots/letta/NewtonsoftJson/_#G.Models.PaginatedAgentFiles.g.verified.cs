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
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentFileAttachment> Files { get; set; } = default!;

        /// <summary>
        /// Cursor for fetching the next page (file-agent relationship ID)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more results exist after this page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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