//HintName: G.Models.CopilotAddCopilotSeatsForUsersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotAddCopilotSeatsForUsersRequest
    {
        /// <summary>
        /// The usernames of the organization members to be granted access to GitHub Copilot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_usernames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SelectedUsernames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForUsersRequest" /> class.
        /// </summary>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members to be granted access to GitHub Copilot.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotAddCopilotSeatsForUsersRequest(
            global::System.Collections.Generic.IList<string> selectedUsernames)
        {
            this.SelectedUsernames = selectedUsernames ?? throw new global::System.ArgumentNullException(nameof(selectedUsernames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForUsersRequest" /> class.
        /// </summary>
        public CopilotAddCopilotSeatsForUsersRequest()
        {
        }
    }
}