//HintName: G.Models.CharityCampaign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharityCampaign
    {
        /// <summary>
        /// An ID that identifies the charity campaign.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the broadcaster that’s running the campaign.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The charity’s name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charity_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CharityName { get; set; } = default!;

        /// <summary>
        /// A description of the charity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charity_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string CharityDescription { get; set; } = default!;

        /// <summary>
        /// A URL to an image of the charity’s logo. The image’s type is PNG and its size is 100px X 100px.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charity_logo", Required = global::Newtonsoft.Json.Required.Always)]
        public string CharityLogo { get; set; } = default!;

        /// <summary>
        /// A URL to the charity’s website.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charity_website", Required = global::Newtonsoft.Json.Required.Always)]
        public string CharityWebsite { get; set; } = default!;

        /// <summary>
        /// The current amount of donations that the campaign has received.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_amount", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CharityCampaignCurrentAmount CurrentAmount { get; set; } = default!;

        /// <summary>
        /// The campaign’s fundraising goal. This field is **null** if the broadcaster has not defined a fundraising goal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_amount", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CharityCampaignTargetAmount TargetAmount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharityCampaign" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the charity campaign.
        /// </param>
        /// <param name="broadcasterId">
        /// An ID that identifies the broadcaster that’s running the campaign.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="charityName">
        /// The charity’s name.
        /// </param>
        /// <param name="charityDescription">
        /// A description of the charity.
        /// </param>
        /// <param name="charityLogo">
        /// A URL to an image of the charity’s logo. The image’s type is PNG and its size is 100px X 100px.
        /// </param>
        /// <param name="charityWebsite">
        /// A URL to the charity’s website.
        /// </param>
        /// <param name="currentAmount">
        /// The current amount of donations that the campaign has received.
        /// </param>
        /// <param name="targetAmount">
        /// The campaign’s fundraising goal. This field is **null** if the broadcaster has not defined a fundraising goal.
        /// </param>
        public CharityCampaign(
            string id,
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string charityName,
            string charityDescription,
            string charityLogo,
            string charityWebsite,
            global::G.CharityCampaignCurrentAmount currentAmount,
            global::G.CharityCampaignTargetAmount targetAmount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.CharityName = charityName ?? throw new global::System.ArgumentNullException(nameof(charityName));
            this.CharityDescription = charityDescription ?? throw new global::System.ArgumentNullException(nameof(charityDescription));
            this.CharityLogo = charityLogo ?? throw new global::System.ArgumentNullException(nameof(charityLogo));
            this.CharityWebsite = charityWebsite ?? throw new global::System.ArgumentNullException(nameof(charityWebsite));
            this.CurrentAmount = currentAmount ?? throw new global::System.ArgumentNullException(nameof(currentAmount));
            this.TargetAmount = targetAmount ?? throw new global::System.ArgumentNullException(nameof(targetAmount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharityCampaign" /> class.
        /// </summary>
        public CharityCampaign()
        {
        }
    }
}