﻿//HintName: G.Models.BroadcasterSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BroadcasterSubscription
    {
        /// <summary>
        /// An ID that identifies the broadcaster.
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
        /// The ID of the user that gifted the subscription to the user. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gifter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GifterId { get; set; }

        /// <summary>
        /// The gifter’s login name. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gifter_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GifterLogin { get; set; }

        /// <summary>
        /// The gifter’s display name. Is an empty string if `is_gift` is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gifter_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GifterName { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_gift")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsGift { get; set; }

        /// <summary>
        /// The name of the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanName { get; set; }

        /// <summary>
        /// The type of subscription. Possible values are:  <br/>
        ///   <br/>
        /// * 1000 — Tier 1<br/>
        /// * 2000 — Tier 2<br/>
        /// * 3000 — Tier 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BroadcasterSubscriptionTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BroadcasterSubscriptionTier Tier { get; set; }

        /// <summary>
        /// An ID that identifies the subscribing user.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcasterSubscription" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// An ID that identifies the broadcaster.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="gifterId">
        /// The ID of the user that gifted the subscription to the user. Is an empty string if `is_gift` is **false**.
        /// </param>
        /// <param name="gifterLogin">
        /// The gifter’s login name. Is an empty string if `is_gift` is **false**.
        /// </param>
        /// <param name="gifterName">
        /// The gifter’s display name. Is an empty string if `is_gift` is **false**.
        /// </param>
        /// <param name="isGift">
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </param>
        /// <param name="planName">
        /// The name of the subscription.
        /// </param>
        /// <param name="tier">
        /// The type of subscription. Possible values are:  <br/>
        ///   <br/>
        /// * 1000 — Tier 1<br/>
        /// * 2000 — Tier 2<br/>
        /// * 3000 — Tier 3
        /// </param>
        /// <param name="userId">
        /// An ID that identifies the subscribing user.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BroadcasterSubscription(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            string gifterId,
            string gifterLogin,
            string gifterName,
            bool isGift,
            string planName,
            global::G.BroadcasterSubscriptionTier tier,
            string userId,
            string userName,
            string userLogin)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.GifterId = gifterId ?? throw new global::System.ArgumentNullException(nameof(gifterId));
            this.GifterLogin = gifterLogin ?? throw new global::System.ArgumentNullException(nameof(gifterLogin));
            this.GifterName = gifterName ?? throw new global::System.ArgumentNullException(nameof(gifterName));
            this.IsGift = isGift;
            this.PlanName = planName ?? throw new global::System.ArgumentNullException(nameof(planName));
            this.Tier = tier;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcasterSubscription" /> class.
        /// </summary>
        public BroadcasterSubscription()
        {
        }
    }
}