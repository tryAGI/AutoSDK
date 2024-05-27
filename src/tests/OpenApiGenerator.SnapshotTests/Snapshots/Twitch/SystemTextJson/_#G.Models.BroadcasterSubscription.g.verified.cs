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
        /// The type of subscription. Possible values are:  
        ///   
        /// * 1000 — Tier 1
        /// * 2000 — Tier 2
        /// * 3000 — Tier 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tier { get; set; }

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
    }
}