//HintName: G.Models.CopilotSeatDetails.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Information about a Copilot Business seat assignment for a user, team, or organization.
    /// </summary>
    public sealed partial class CopilotSeatDetails
    {
        /// <summary>
        /// The assignee that has been granted access to GitHub Copilot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignee", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.SimpleUser, global::G.Team, global::G.Organization> Assignee { get; set; } = default!;

        /// <summary>
        /// The team that granted access to GitHub Copilot to the assignee. This will be null if the user was assigned a seat individually.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigning_team")]
        public global::G.OneOf<global::G.Team>? AssigningTeam { get; set; }

        /// <summary>
        /// The pending cancellation date for the seat, in `YYYY-MM-DD` format. This will be null unless the assignee's Copilot access has been canceled during the current billing cycle. If the seat has been cancelled, this corresponds to the start of the organization's next billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pending_cancellation_date")]
        public global::System.DateTime? PendingCancellationDate { get; set; }

        /// <summary>
        /// Timestamp of user's last GitHub Copilot activity, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_activity_at")]
        public global::System.DateTime? LastActivityAt { get; set; }

        /// <summary>
        /// Last editor that was used by the user for a GitHub Copilot completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_activity_editor")]
        public string? LastActivityEditor { get; set; }

        /// <summary>
        /// Timestamp of when the assignee was last granted access to GitHub Copilot, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp of when the assignee's GitHub Copilot access was last updated, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}