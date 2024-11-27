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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folderIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> FolderIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> MemoIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkFoldersToMemosRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="folderIds"></param>
        /// <param name="memoIds"></param>
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