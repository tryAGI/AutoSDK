//HintName: G.Models.NullableMilestone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A collection of related issues and pull requests.
    /// </summary>
    public sealed partial class NullableMilestone
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/milestones/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/milestones/v1.0
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/milestones/v1.0</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones/1/labels
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/milestones/1/labels</example>
        [global::Newtonsoft.Json.JsonProperty("labels_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LabelsUrl { get; set; } = default!;

        /// <summary>
        /// Example: 1002604
        /// </summary>
        /// <example>1002604</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDk6TWlsZXN0b25lMTAwMjYwNA==
        /// </summary>
        /// <example>MDk6TWlsZXN0b25lMTAwMjYwNA==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The number of the milestone.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// The state of the milestone.<br/>
        /// Default Value: open<br/>
        /// Example: open
        /// </summary>
        /// <default>global::G.NullableMilestoneState.Open</default>
        /// <example>open</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableMilestoneState State { get; set; } = default!;

        /// <summary>
        /// The title of the milestone.<br/>
        /// Example: v1.0
        /// </summary>
        /// <example>v1.0</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Example: Tracking milestone for version 1.0
        /// </summary>
        /// <example>Tracking milestone for version 1.0</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Creator { get; set; } = default!;

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::Newtonsoft.Json.JsonProperty("open_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public int OpenIssues { get; set; } = default!;

        /// <summary>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::Newtonsoft.Json.JsonProperty("closed_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClosedIssues { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ClosedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("due_on", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? DueOn { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableMilestone" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones/1
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/milestones/v1.0
        /// </param>
        /// <param name="labelsUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones/1/labels
        /// </param>
        /// <param name="id">
        /// Example: 1002604
        /// </param>
        /// <param name="nodeId">
        /// Example: MDk6TWlsZXN0b25lMTAwMjYwNA==
        /// </param>
        /// <param name="number">
        /// The number of the milestone.<br/>
        /// Example: 42
        /// </param>
        /// <param name="state">
        /// The state of the milestone.<br/>
        /// Default Value: open<br/>
        /// Example: open
        /// </param>
        /// <param name="title">
        /// The title of the milestone.<br/>
        /// Example: v1.0
        /// </param>
        /// <param name="description">
        /// Example: Tracking milestone for version 1.0
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="openIssues">
        /// Example: 4
        /// </param>
        /// <param name="closedIssues">
        /// Example: 8
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="closedAt"></param>
        /// <param name="dueOn"></param>
        public NullableMilestone(
            string url,
            string htmlUrl,
            string labelsUrl,
            int id,
            string nodeId,
            int number,
            global::G.NullableMilestoneState state,
            string title,
            string? description,
            global::G.NullableSimpleUser? creator,
            int openIssues,
            int closedIssues,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? closedAt,
            global::System.DateTime? dueOn)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.LabelsUrl = labelsUrl ?? throw new global::System.ArgumentNullException(nameof(labelsUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.State = state;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.OpenIssues = openIssues;
            this.ClosedIssues = closedIssues;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ClosedAt = closedAt;
            this.DueOn = dueOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableMilestone" /> class.
        /// </summary>
        public NullableMilestone()
        {
        }
    }
}