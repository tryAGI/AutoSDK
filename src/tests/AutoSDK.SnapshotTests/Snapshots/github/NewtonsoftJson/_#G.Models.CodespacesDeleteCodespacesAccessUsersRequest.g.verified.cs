//HintName: G.Models.CodespacesDeleteCodespacesAccessUsersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesDeleteCodespacesAccessUsersRequest
    {
        /// <summary>
        /// The usernames of the organization members whose codespaces should not be billed to the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_usernames", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SelectedUsernames { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesDeleteCodespacesAccessUsersRequest" /> class.
        /// </summary>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members whose codespaces should not be billed to the organization.
        /// </param>
        public CodespacesDeleteCodespacesAccessUsersRequest(
            global::System.Collections.Generic.IList<string> selectedUsernames)
        {
            this.SelectedUsernames = selectedUsernames ?? throw new global::System.ArgumentNullException(nameof(selectedUsernames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesDeleteCodespacesAccessUsersRequest" /> class.
        /// </summary>
        public CodespacesDeleteCodespacesAccessUsersRequest()
        {
        }
    }
}