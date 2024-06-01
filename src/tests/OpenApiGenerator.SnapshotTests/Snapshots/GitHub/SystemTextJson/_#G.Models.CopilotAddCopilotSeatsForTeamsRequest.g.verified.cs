//HintName: G.Models.CopilotAddCopilotSeatsForTeamsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotAddCopilotSeatsForTeamsRequest
    {
        /// <summary>
        /// List of team names within the organization to which to grant access to GitHub Copilot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SelectedTeams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}