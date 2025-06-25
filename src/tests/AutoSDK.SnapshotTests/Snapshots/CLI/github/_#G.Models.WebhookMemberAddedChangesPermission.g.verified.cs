//HintName: G.Models.WebhookMemberAddedChangesPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is included for legacy purposes; use the `role_name` field instead. The `maintain`<br/>
    /// role is mapped to `write` and the `triage` role is mapped to `read`. To determine the role<br/>
    /// assigned to the collaborator, use the `role_name` field instead, which will provide the full<br/>
    /// role name, including custom roles.
    /// </summary>
    public sealed partial class WebhookMemberAddedChangesPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookMemberAddedChangesPermissionToJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookMemberAddedChangesPermissionTo To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMemberAddedChangesPermission" /> class.
        /// </summary>
        /// <param name="to"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookMemberAddedChangesPermission(
            global::G.WebhookMemberAddedChangesPermissionTo to)
        {
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMemberAddedChangesPermission" /> class.
        /// </summary>
        public WebhookMemberAddedChangesPermission()
        {
        }
    }
}