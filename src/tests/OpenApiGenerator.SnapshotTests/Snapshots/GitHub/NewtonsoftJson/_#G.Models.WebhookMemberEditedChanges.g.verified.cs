//HintName: G.Models.WebhookMemberEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the collaborator permissions
    /// </summary>
    public sealed partial class WebhookMemberEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_permission")]
        public WebhookMemberEditedChangesOldPermission? OldPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public WebhookMemberEditedChangesPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}