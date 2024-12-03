//HintName: G.Models.WebhookTeamEditedChangesRepositoryPermissionsFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTeamEditedChangesRepositoryPermissionsFrom
    {
        /// <summary>
        /// The previous version of the team member's `admin` permission on a repository, if the action was `edited`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin")]
        public bool? Admin { get; set; }

        /// <summary>
        /// The previous version of the team member's `pull` permission on a repository, if the action was `edited`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull")]
        public bool? Pull { get; set; }

        /// <summary>
        /// The previous version of the team member's `push` permission on a repository, if the action was `edited`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push")]
        public bool? Push { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChangesRepositoryPermissionsFrom" /> class.
        /// </summary>
        /// <param name="admin">
        /// The previous version of the team member's `admin` permission on a repository, if the action was `edited`.
        /// </param>
        /// <param name="pull">
        /// The previous version of the team member's `pull` permission on a repository, if the action was `edited`.
        /// </param>
        /// <param name="push">
        /// The previous version of the team member's `push` permission on a repository, if the action was `edited`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookTeamEditedChangesRepositoryPermissionsFrom(
            bool? admin,
            bool? pull,
            bool? push)
        {
            this.Admin = admin;
            this.Pull = pull;
            this.Push = push;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChangesRepositoryPermissionsFrom" /> class.
        /// </summary>
        public WebhookTeamEditedChangesRepositoryPermissionsFrom()
        {
        }
    }
}