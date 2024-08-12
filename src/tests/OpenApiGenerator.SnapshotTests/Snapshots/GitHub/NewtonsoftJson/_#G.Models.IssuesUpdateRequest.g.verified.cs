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
        [global::Newtonsoft.Json.JsonProperty("title")]
        public global::System.OneOf<string?, int?>? Title { get; set; }

        /// <summary>
        /// The contents of the issue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Username to assign to this issue. **This field is deprecated.**
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee")]
        public string? Assignee { get; set; }

        /// <summary>
        /// The open or closed state of the issue.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.IssuesUpdateRequestState? State { get; set; }

        /// <summary>
        /// The reason for the state change. Ignored unless `state` is changed.<br/>
        /// Example: not_planned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state_reason")]
        public global::G.IssuesUpdateRequestStateReason? StateReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("milestone")]
        public global::System.OneOf<string?, int?>? Milestone { get; set; }

        /// <summary>
        /// Labels to associate with this issue. Pass one or more labels to _replace_ the set of labels on this issue. Send an empty array (`[]`) to clear all labels from the issue. Only users with push access can set labels for issues. Without push access to the repository, label changes are silently dropped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<global::System.OneOf<string?, global::G.IssuesUpdateRequestLabel>>? Labels { get; set; }

        /// <summary>
        /// Usernames to assign to this issue. Pass one or more user logins to _replace_ the set of assignees on this issue. Send an empty array (`[]`) to clear all assignees from the issue. Only users with push access can set assignees for new issues. Without push access to the repository, assignee changes are silently dropped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees")]
        public global::System.Collections.Generic.IList<string>? Assignees { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}