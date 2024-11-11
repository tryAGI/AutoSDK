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
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintainer")]
        public global::G.WebhooksSponsorshipMaintainer? Maintainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy_level", Required = global::Newtonsoft.Json.Required.Always)]
        public string PrivacyLevel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sponsor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksSponsorshipSponsor? Sponsor { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sponsorable", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksSponsorshipSponsorable? Sponsorable { get; set; } = default!;

        /// <summary>
        /// The `tier_changed` and `pending_tier_change` will include the original tier before the change or pending change. For more information, see the pending tier change payload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksSponsorshipTier Tier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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