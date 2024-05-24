//HintName: G.Models.WebhookMemberAddedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMemberAddedChanges
    {
        /// <summary>
        /// This field is included for legacy purposes; use the `role_name` field instead. The `maintain`
        /// role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role
        /// assigned to the collaborator, use the `role_name` field instead, which will provide the full
        /// role name, including custom roles.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public WebhookMemberAddedChangesPermission? Permission { get; set; }

        /// <summary>
        /// The role assigned to the collaborator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_name")]
        public WebhookMemberAddedChangesRoleName? RoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}