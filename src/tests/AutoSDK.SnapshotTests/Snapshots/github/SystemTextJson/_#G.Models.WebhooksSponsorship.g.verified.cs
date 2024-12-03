//HintName: G.Models.WebhooksSponsorship.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksSponsorship
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainer")]
        public global::G.WebhooksSponsorshipMaintainer? Maintainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy_level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrivacyLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sponsor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksSponsorshipSponsor? Sponsor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sponsorable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksSponsorshipSponsorable? Sponsorable { get; set; }

        /// <summary>
        /// The `tier_changed` and `pending_tier_change` will include the original tier before the change or pending change. For more information, see the pending tier change payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhooksSponsorshipTier Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSponsorship" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="maintainer"></param>
        /// <param name="nodeId"></param>
        /// <param name="privacyLevel"></param>
        /// <param name="sponsor"></param>
        /// <param name="sponsorable"></param>
        /// <param name="tier">
        /// The `tier_changed` and `pending_tier_change` will include the original tier before the change or pending change. For more information, see the pending tier change payload.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhooksSponsorship(
            string createdAt,
            string nodeId,
            string privacyLevel,
            global::G.WebhooksSponsorshipSponsor? sponsor,
            global::G.WebhooksSponsorshipSponsorable? sponsorable,
            global::G.WebhooksSponsorshipTier tier,
            global::G.WebhooksSponsorshipMaintainer? maintainer)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.PrivacyLevel = privacyLevel ?? throw new global::System.ArgumentNullException(nameof(privacyLevel));
            this.Sponsor = sponsor ?? throw new global::System.ArgumentNullException(nameof(sponsor));
            this.Sponsorable = sponsorable ?? throw new global::System.ArgumentNullException(nameof(sponsorable));
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.Maintainer = maintainer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksSponsorship" /> class.
        /// </summary>
        public WebhooksSponsorship()
        {
        }
    }
}