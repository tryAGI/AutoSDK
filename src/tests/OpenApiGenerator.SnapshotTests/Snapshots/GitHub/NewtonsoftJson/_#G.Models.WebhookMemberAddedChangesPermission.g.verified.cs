//HintName: G.Models.WebhookMemberAddedChangesPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is included for legacy purposes; use the `role_name` field instead. The `maintain`
    /// role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role
    /// assigned to the collaborator, use the `role_name` field instead, which will provide the full
    /// role name, including custom roles.
    /// </summary>
    public sealed partial class WebhookMemberAddedChangesPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookMemberAddedChangesPermissionTo To { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}