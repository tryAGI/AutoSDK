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
        [global::Newtonsoft.Json.JsonProperty("selected_teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SelectedTeams { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}