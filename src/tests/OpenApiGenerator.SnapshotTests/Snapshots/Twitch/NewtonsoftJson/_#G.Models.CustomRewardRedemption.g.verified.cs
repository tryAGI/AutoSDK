//HintName: G.Models.CustomRewardRedemption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomRewardRedemption
    {
        /// <summary>
        /// The ID that uniquely identifies the broadcaster.
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
        /// The ID that uniquely identifies this redemption..
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the user that redeemed the reward.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// An object that describes the reward that the user redeemed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reward", Required = global::Newtonsoft.Json.Required.Always)]
        public CustomRewardRedemptionReward Reward { get; set; } = default!;

        /// <summary>
        /// The text that the user entered at the prompt when they redeemed the reward; otherwise, an empty string if user input was not required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_input", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserInput { get; set; } = default!;

        /// <summary>
        /// The state of the redemption. Possible values are:  
        ///   
        /// * CANCELED
        /// * FULFILLED
        /// * UNFULFILLED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public CustomRewardRedemptionStatus Status { get; set; } = default!;

        /// <summary>
        /// The date and time of when the reward was redeemed, in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redeemed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime RedeemedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}