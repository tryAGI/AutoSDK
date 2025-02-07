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
        [global::System.Text.Json.Serialization.JsonPropertyName("old_permission")]
        public global::G.WebhookMemberEditedChangesOldPermission? OldPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::G.WebhookMemberEditedChangesPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMemberEditedChanges" /> class.
        /// </summary>
        /// <param name="oldPermission"></param>
        /// <param name="permission"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookMemberEditedChanges(
            global::G.WebhookMemberEditedChangesOldPermission? oldPermission,
            global::G.WebhookMemberEditedChangesPermission? permission)
        {
            this.OldPermission = oldPermission;
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMemberEditedChanges" /> class.
        /// </summary>
        public WebhookMemberEditedChanges()
        {
        }
    }
}