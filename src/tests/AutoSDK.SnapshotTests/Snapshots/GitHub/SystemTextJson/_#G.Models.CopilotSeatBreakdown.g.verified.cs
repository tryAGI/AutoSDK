//HintName: G.Models.CopilotSeatBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The breakdown of Copilot Business seats for the organization.
    /// </summary>
    public sealed partial class CopilotSeatBreakdown
    {
        /// <summary>
        /// The total number of seats being billed for the organization as of the current billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// Seats added during the current billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_this_cycle")]
        public int AddedThisCycle { get; set; }

        /// <summary>
        /// The number of seats that are pending cancellation at the end of the current billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_cancellation")]
        public int PendingCancellation { get; set; }

        /// <summary>
        /// The number of seats that have been assigned to users that have not yet accepted an invitation to this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_invitation")]
        public int PendingInvitation { get; set; }

        /// <summary>
        /// The number of seats that have used Copilot during the current billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_this_cycle")]
        public int ActiveThisCycle { get; set; }

        /// <summary>
        /// The number of seats that have not used Copilot during the current billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactive_this_cycle")]
        public int InactiveThisCycle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}