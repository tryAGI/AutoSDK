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
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Assignee { get; set; }

        /// <summary>
        /// A GitHub organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.NullableOrganizationSimple? Organization { get; set; }

        /// <summary>
        /// The team through which the assignee is granted access to GitHub Copilot, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigning_team")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::G.Team, global::G.EnterpriseTeam>? AssigningTeam { get; set; }

        /// <summary>
        /// The pending cancellation date for the seat, in `YYYY-MM-DD` format. This will be null unless the assignee's Copilot access has been canceled during the current billing cycle. If the seat has been cancelled, this corresponds to the start of the organization's next billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_cancellation_date")]
        public global::System.DateTime? PendingCancellationDate { get; set; }

        /// <summary>
        /// Timestamp of user's last GitHub Copilot activity, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activity_at")]
        public global::System.DateTime? LastActivityAt { get; set; }

        /// <summary>
        /// Last editor that was used by the user for a GitHub Copilot completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activity_editor")]
        public string? LastActivityEditor { get; set; }

        /// <summary>
        /// Timestamp of when the assignee was last granted access to GitHub Copilot, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the assignee's GitHub Copilot access was last updated, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The Copilot plan of the organization, or the parent enterprise, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CopilotSeatDetailsPlanTypeJsonConverter))]
        public global::G.CopilotSeatDetailsPlanType? PlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSeatDetails" /> class.
        /// </summary>
        /// <param name="assignee">
        /// A GitHub user.
        /// </param>
        /// <param name="organization">
        /// A GitHub organization.
        /// </param>
        /// <param name="assigningTeam">
        /// The team through which the assignee is granted access to GitHub Copilot, if applicable.
        /// </param>
        /// <param name="pendingCancellationDate">
        /// The pending cancellation date for the seat, in `YYYY-MM-DD` format. This will be null unless the assignee's Copilot access has been canceled during the current billing cycle. If the seat has been cancelled, this corresponds to the start of the organization's next billing cycle.
        /// </param>
        /// <param name="lastActivityAt">
        /// Timestamp of user's last GitHub Copilot activity, in ISO 8601 format.
        /// </param>
        /// <param name="lastActivityEditor">
        /// Last editor that was used by the user for a GitHub Copilot completion.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the assignee was last granted access to GitHub Copilot, in ISO 8601 format.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the assignee's GitHub Copilot access was last updated, in ISO 8601 format.
        /// </param>
        /// <param name="planType">
        /// The Copilot plan of the organization, or the parent enterprise, when applicable.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotSeatDetails(
            global::G.SimpleUser assignee,
            global::System.DateTime createdAt,
            global::G.NullableOrganizationSimple? organization,
            global::G.OneOf<global::G.Team, global::G.EnterpriseTeam>? assigningTeam,
            global::System.DateTime? pendingCancellationDate,
            global::System.DateTime? lastActivityAt,
            string? lastActivityEditor,
            global::System.DateTime? updatedAt,
            global::G.CopilotSeatDetailsPlanType? planType)
        {
            this.Assignee = assignee ?? throw new global::System.ArgumentNullException(nameof(assignee));
            this.CreatedAt = createdAt;
            this.Organization = organization;
            this.AssigningTeam = assigningTeam;
            this.PendingCancellationDate = pendingCancellationDate;
            this.LastActivityAt = lastActivityAt;
            this.LastActivityEditor = lastActivityEditor;
            this.UpdatedAt = updatedAt;
            this.PlanType = planType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSeatDetails" /> class.
        /// </summary>
        public CopilotSeatDetails()
        {
        }
    }
}