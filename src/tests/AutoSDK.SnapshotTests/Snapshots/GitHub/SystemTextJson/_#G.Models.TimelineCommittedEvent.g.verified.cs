//HintName: G.Models.TimelineCommittedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timeline Committed Event
    /// </summary>
    public sealed partial class TimelineCommittedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// SHA for the commit<br/>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </summary>
        /// <example>7638417db6d59f3c431d3e1f261cc637155684cd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Identifying information for the git-user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimelineCommittedEventAuthor Author { get; set; }

        /// <summary>
        /// Identifying information for the git-user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimelineCommittedEventCommitter Committer { get; set; }

        /// <summary>
        /// Message describing the purpose of the commit<br/>
        /// Example: Fix #42
        /// </summary>
        /// <example>Fix #42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimelineCommittedEventTree Tree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TimelineCommittedEventParent> Parents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimelineCommittedEventVerification Verification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEvent" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="sha">
        /// SHA for the commit<br/>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="author">
        /// Identifying information for the git-user
        /// </param>
        /// <param name="committer">
        /// Identifying information for the git-user
        /// </param>
        /// <param name="message">
        /// Message describing the purpose of the commit<br/>
        /// Example: Fix #42
        /// </param>
        /// <param name="tree"></param>
        /// <param name="parents"></param>
        /// <param name="verification"></param>
        /// <param name="htmlUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TimelineCommittedEvent(
            string sha,
            string nodeId,
            string url,
            global::G.TimelineCommittedEventAuthor author,
            global::G.TimelineCommittedEventCommitter committer,
            string message,
            global::G.TimelineCommittedEventTree tree,
            global::System.Collections.Generic.IList<global::G.TimelineCommittedEventParent> parents,
            global::G.TimelineCommittedEventVerification verification,
            string htmlUrl,
            string? @event)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.Parents = parents ?? throw new global::System.ArgumentNullException(nameof(parents));
            this.Verification = verification ?? throw new global::System.ArgumentNullException(nameof(verification));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEvent" /> class.
        /// </summary>
        public TimelineCommittedEvent()
        {
        }
    }
}