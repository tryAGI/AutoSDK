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

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForTeamsRequest" /> class.
        /// </summary>
        /// <param name="selectedTeams">
        /// List of team names within the organization to which to grant access to GitHub Copilot.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotAddCopilotSeatsForTeamsRequest(
            global::System.Collections.Generic.IList<string> selectedTeams)
        {
            this.SelectedTeams = selectedTeams ?? throw new global::System.ArgumentNullException(nameof(selectedTeams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForTeamsRequest" /> class.
        /// </summary>
        public CopilotAddCopilotSeatsForTeamsRequest()
        {
        }
    }
}