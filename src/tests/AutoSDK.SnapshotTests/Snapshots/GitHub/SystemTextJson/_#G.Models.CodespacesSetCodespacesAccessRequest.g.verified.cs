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
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.CodespacesSetCodespacesAccessRequestVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodespacesSetCodespacesAccessRequestVisibility Visibility { get; set; }

        /// <summary>
        /// The usernames of the organization members who should have access to codespaces in the organization. Required when `visibility` is `selected_members`. The provided list of usernames will replace any existing value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_usernames")]
        public global::System.Collections.Generic.IList<string>? SelectedUsernames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}