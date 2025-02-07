//HintName: G.Models.BodyDeleteExistingInvitationV1WorkspaceInvitesDelete.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteExistingInvitationV1WorkspaceInvitesDelete
    {
        /// <summary>
        /// Email of the target user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteExistingInvitationV1WorkspaceInvitesDelete" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the target user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDeleteExistingInvitationV1WorkspaceInvitesDelete(
            string email)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteExistingInvitationV1WorkspaceInvitesDelete" /> class.
        /// </summary>
        public BodyDeleteExistingInvitationV1WorkspaceInvitesDelete()
        {
        }
    }
}