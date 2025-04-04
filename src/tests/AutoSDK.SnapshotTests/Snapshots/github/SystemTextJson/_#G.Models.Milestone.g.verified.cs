﻿//HintName: G.Models.Milestone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A collection of related issues and pull requests.
    /// </summary>
    public sealed partial class Milestone
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/milestones/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/milestones/v1.0
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/milestones/v1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/milestones/1/labels
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/milestones/1/labels</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LabelsUrl { get; set; }

        /// <summary>
        /// Example: 1002604
        /// </summary>
        /// <example>1002604</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDk6TWlsZXN0b25lMTAwMjYwNA==
        /// </summary>
        /// <example>MDk6TWlsZXN0b25lMTAwMjYwNA==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The number of the milestone.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// The state of the milestone.<br/>
        /// Default Value: open<br/>
        /// Example: open
        /// </summary>
        /// <default>global::G.MilestoneState.Open</default>
        /// <example>open</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MilestoneStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MilestoneState State { get; set; } = global::G.MilestoneState.Open;

        /// <summary>
        /// The title of the milestone.<br/>
        /// Example: v1.0
        /// </summary>
        /// <example>v1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Example: Tracking milestone for version 1.0
        /// </summary>
        /// <example>Tracking milestone for version 1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Creator { get; set; }

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenIssues { get; set; }

        /// <summary>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClosedIssues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("due_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? DueOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Milestone" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Milestone(
            string url,
            string htmlUrl,
            string labelsUrl,
            int id,
            string nodeId,
            int number,
            global::G.MilestoneState state,
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
        /// Initializes a new instance of the <see cref="Milestone" /> class.
        /// </summary>
        public Milestone()
        {
        }
    }
}