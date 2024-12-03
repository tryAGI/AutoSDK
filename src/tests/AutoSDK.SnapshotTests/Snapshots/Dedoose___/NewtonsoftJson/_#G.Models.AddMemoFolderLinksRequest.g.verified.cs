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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoId", Required = global::Newtonsoft.Json.Required.Always)]
        public string MemoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folderIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> FolderIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMemoFolderLinksRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="folderIds"></param>
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