//HintName: G.Models.LinkFoldersToMemosRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LinkFoldersToMemosRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FolderIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MemoIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkFoldersToMemosRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="folderIds"></param>
        /// <param name="memoIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkFoldersToMemosRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<string> folderIds,
            global::System.Collections.Generic.IList<string> memoIds)
        {
            this.ProjectId = projectId;
            this.FolderIds = folderIds ?? throw new global::System.ArgumentNullException(nameof(folderIds));
            this.MemoIds = memoIds ?? throw new global::System.ArgumentNullException(nameof(memoIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkFoldersToMemosRequest" /> class.
        /// </summary>
        public LinkFoldersToMemosRequest()
        {
        }
    }
}