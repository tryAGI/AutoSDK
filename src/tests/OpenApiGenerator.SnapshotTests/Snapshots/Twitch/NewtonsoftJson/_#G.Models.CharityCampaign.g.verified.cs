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
        public CharityCampaignCurrentAmount CurrentAmount { get; set; } = default!;

        /// <summary>
        /// The campaign’s fundraising goal. This field is **null** if the broadcaster has not defined a fundraising goal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_amount", Required = global::Newtonsoft.Json.Required.Always)]
        public CharityCampaignTargetAmount TargetAmount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}