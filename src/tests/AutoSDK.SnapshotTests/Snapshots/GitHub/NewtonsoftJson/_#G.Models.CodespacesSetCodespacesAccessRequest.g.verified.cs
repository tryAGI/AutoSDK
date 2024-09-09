//HintName: G.Models.CodespacesSetCodespacesAccessRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesSetCodespacesAccessRequest
    {
        /// <summary>
        /// Which users can access codespaces in the organization. `disabled` means that no users can access codespaces in the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodespacesSetCodespacesAccessRequestVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// The usernames of the organization members who should have access to codespaces in the organization. Required when `visibility` is `selected_members`. The provided list of usernames will replace any existing value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_usernames")]
        public global::System.Collections.Generic.IList<string>? SelectedUsernames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}