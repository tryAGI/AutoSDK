//HintName: G.Models.IssuesUpdateRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesUpdateRequest
    {
        /// <summary>
        /// The title of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::G.OneOf<string, int?>? Title { get; set; }

        /// <summary>
        /// The contents of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Username to assign to this issue. **This field is deprecated.**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public string? Assignee { get; set; }

        /// <summary>
        /// The open or closed state of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IssuesUpdateRequestStateJsonConverter))]
        public global::G.IssuesUpdateRequestState? State { get; set; }

        /// <summary>
        /// The reason for the state change. Ignored unless `state` is changed.<br/>
        /// Example: not_planned
        /// </summary>
        /// <example>not_planned</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IssuesUpdateRequestStateReasonJsonConverter))]
        public global::G.IssuesUpdateRequestStateReason? StateReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::G.OneOf<string, int?>? Milestone { get; set; }

        /// <summary>
        /// Labels to associate with this issue. Pass one or more labels to _replace_ the set of labels on this issue. Send an empty array (`[]`) to clear all labels from the issue. Only users with push access can set labels for issues. Without push access to the repository, label changes are silently dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.IssuesUpdateRequestLabel>>? Labels { get; set; }

        /// <summary>
        /// Usernames to assign to this issue. Pass one or more user logins to _replace_ the set of assignees on this issue. Send an empty array (`[]`) to clear all assignees from the issue. Only users with push access can set assignees for new issues. Without push access to the repository, assignee changes are silently dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<string>? Assignees { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the issue.
        /// </param>
        /// <param name="body">
        /// The contents of the issue.
        /// </param>
        /// <param name="assignee">
        /// Username to assign to this issue. **This field is deprecated.**
        /// </param>
        /// <param name="state">
        /// The open or closed state of the issue.
        /// </param>
        /// <param name="stateReason">
        /// The reason for the state change. Ignored unless `state` is changed.<br/>
        /// Example: not_planned
        /// </param>
        /// <param name="milestone"></param>
        /// <param name="labels">
        /// Labels to associate with this issue. Pass one or more labels to _replace_ the set of labels on this issue. Send an empty array (`[]`) to clear all labels from the issue. Only users with push access can set labels for issues. Without push access to the repository, label changes are silently dropped.
        /// </param>
        /// <param name="assignees">
        /// Usernames to assign to this issue. Pass one or more user logins to _replace_ the set of assignees on this issue. Send an empty array (`[]`) to clear all assignees from the issue. Only users with push access can set assignees for new issues. Without push access to the repository, assignee changes are silently dropped.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public IssuesUpdateRequest(
            global::G.OneOf<string, int?>? title,
            string? body,
            string? assignee,
            global::G.IssuesUpdateRequestState? state,
            global::G.IssuesUpdateRequestStateReason? stateReason,
            global::G.OneOf<string, int?>? milestone,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.IssuesUpdateRequestLabel>>? labels,
            global::System.Collections.Generic.IList<string>? assignees)
        {
            this.Title = title;
            this.Body = body;
            this.Assignee = assignee;
            this.State = state;
            this.StateReason = stateReason;
            this.Milestone = milestone;
            this.Labels = labels;
            this.Assignees = assignees;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequest" /> class.
        /// </summary>
        public IssuesUpdateRequest()
        {
        }
    }
}