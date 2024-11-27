//HintName: G.Models.StartCopyMemosToDocumentsJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartCopyMemosToDocumentsJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> MemoIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCopyMemosToDocumentsJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="memoIds"></param>
        public StartCopyMemosToDocumentsJobRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Collections.Generic.IList<global::System.Guid> memoIds)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.MemoIds = memoIds ?? throw new global::System.ArgumentNullException(nameof(memoIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCopyMemosToDocumentsJobRequest" /> class.
        /// </summary>
        public StartCopyMemosToDocumentsJobRequest()
        {
        }
    }
}