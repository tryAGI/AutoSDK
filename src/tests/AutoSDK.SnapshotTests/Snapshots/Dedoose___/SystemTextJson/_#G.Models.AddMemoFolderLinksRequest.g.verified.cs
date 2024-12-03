//HintName: G.Models.AddMemoFolderLinksRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddMemoFolderLinksRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("memoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folderIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FolderIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMemoFolderLinksRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="folderIds"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddMemoFolderLinksRequest(
            global::System.Guid projectId,
            string memoId,
            global::System.Collections.Generic.IList<string> folderIds)
        {
            this.ProjectId = projectId;
            this.MemoId = memoId ?? throw new global::System.ArgumentNullException(nameof(memoId));
            this.FolderIds = folderIds ?? throw new global::System.ArgumentNullException(nameof(folderIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMemoFolderLinksRequest" /> class.
        /// </summary>
        public AddMemoFolderLinksRequest()
        {
        }
    }
}