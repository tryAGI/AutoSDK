//HintName: G.Models.WebhookRepositoryTransferredChangesOwnerFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryTransferredChangesOwnerFrom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.WebhookRepositoryTransferredChangesOwnerFromOrganization? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.WebhookRepositoryTransferredChangesOwnerFromUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChangesOwnerFrom" /> class.
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRepositoryTransferredChangesOwnerFrom(
            global::G.WebhookRepositoryTransferredChangesOwnerFromOrganization? organization,
            global::G.WebhookRepositoryTransferredChangesOwnerFromUser? user)
        {
            this.Organization = organization;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChangesOwnerFrom" /> class.
        /// </summary>
        public WebhookRepositoryTransferredChangesOwnerFrom()
        {
        }
    }
}