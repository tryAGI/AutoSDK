//HintName: G.Models.CodespacesSetCodespacesAccessUsersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesSetCodespacesAccessUsersRequest
    {
        /// <summary>
        /// The usernames of the organization members whose codespaces be billed to the organization.
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
        /// Initializes a new instance of the <see cref="CodespacesSetCodespacesAccessUsersRequest" /> class.
        /// </summary>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members whose codespaces be billed to the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesSetCodespacesAccessUsersRequest(
            global::System.Collections.Generic.IList<string> selectedUsernames)
        {
            this.SelectedUsernames = selectedUsernames ?? throw new global::System.ArgumentNullException(nameof(selectedUsernames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesSetCodespacesAccessUsersRequest" /> class.
        /// </summary>
        public CodespacesSetCodespacesAccessUsersRequest()
        {
        }
    }
}