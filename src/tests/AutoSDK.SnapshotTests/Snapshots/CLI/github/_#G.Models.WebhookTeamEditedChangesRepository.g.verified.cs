//HintName: G.Models.WebhookTeamEditedChangesRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTeamEditedChangesRepository
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookTeamEditedChangesRepositoryPermissions Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChangesRepository" /> class.
        /// </summary>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTeamEditedChangesRepository(
            global::G.WebhookTeamEditedChangesRepositoryPermissions permissions)
        {
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChangesRepository" /> class.
        /// </summary>
        public WebhookTeamEditedChangesRepository()
        {
        }
    }
}