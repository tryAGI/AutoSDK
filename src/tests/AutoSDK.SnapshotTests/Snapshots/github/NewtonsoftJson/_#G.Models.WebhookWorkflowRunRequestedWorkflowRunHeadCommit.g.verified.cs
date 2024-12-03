//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunHeadCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowRunRequestedWorkflowRunHeadCommit
    {
        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowRunRequestedWorkflowRunHeadCommitAuthor Author { get; set; } = default!;

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowRunRequestedWorkflowRunHeadCommitCommitter Committer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TreeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunRequestedWorkflowRunHeadCommit" /> class.
        /// </summary>
        /// <param name="author">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="committer">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <param name="treeId"></param>
        public WebhookWorkflowRunRequestedWorkflowRunHeadCommit(
            global::G.WebhookWorkflowRunRequestedWorkflowRunHeadCommitAuthor author,
            global::G.WebhookWorkflowRunRequestedWorkflowRunHeadCommitCommitter committer,
            string id,
            string message,
            string timestamp,
            string treeId)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.TreeId = treeId ?? throw new global::System.ArgumentNullException(nameof(treeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunRequestedWorkflowRunHeadCommit" /> class.
        /// </summary>
        public WebhookWorkflowRunRequestedWorkflowRunHeadCommit()
        {
        }
    }
}