﻿//HintName: G.Models.CustomRewardRedemption.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterLogin { get; set; }

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterName { get; set; }

        /// <summary>
        /// The ID that uniquely identifies this redemption..
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the user that redeemed the reward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserName { get; set; }

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// An object that describes the reward that the user redeemed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reward")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomRewardRedemptionReward Reward { get; set; }

        /// <summary>
        /// The text that the user entered at the prompt when they redeemed the reward; otherwise, an empty string if user input was not required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserInput { get; set; }

        /// <summary>
        /// The state of the redemption. Possible values are:  <br/>
        ///   <br/>
        /// * CANCELED<br/>
        /// * FULFILLED<br/>
        /// * UNFULFILLED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomRewardRedemptionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomRewardRedemptionStatus Status { get; set; }

        /// <summary>
        /// The date and time of when the reward was redeemed, in RFC3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redeemed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RedeemedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardRedemption" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID that uniquely identifies the broadcaster.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="id">
        /// The ID that uniquely identifies this redemption..
        /// </param>
        /// <param name="userId">
        /// The ID of the user that redeemed the reward.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        /// <param name="reward">
        /// An object that describes the reward that the user redeemed.
        /// </param>
        /// <param name="userInput">
        /// The text that the user entered at the prompt when they redeemed the reward; otherwise, an empty string if user input was not required.
        /// </param>
        /// <param name="status">
        /// The state of the redemption. Possible values are:  <br/>
        ///   <br/>
        /// * CANCELED<br/>
        /// * FULFILLED<br/>
        /// * UNFULFILLED
        /// </param>
        /// <param name="redeemedAt">
        /// The date and time of when the reward was redeemed, in RFC3339 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomRewardRedemption(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string id,
            string userId,
            string userName,
            string userLogin,
            global::G.CustomRewardRedemptionReward reward,
            string userInput,
            global::G.CustomRewardRedemptionStatus status,
            global::System.DateTime redeemedAt)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.Reward = reward ?? throw new global::System.ArgumentNullException(nameof(reward));
            this.UserInput = userInput ?? throw new global::System.ArgumentNullException(nameof(userInput));
            this.Status = status;
            this.RedeemedAt = redeemedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardRedemption" /> class.
        /// </summary>
        public CustomRewardRedemption()
        {
        }
    }
}