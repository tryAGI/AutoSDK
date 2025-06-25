﻿//HintName: G.Models.DropsEntitlement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DropsEntitlement
    {
        /// <summary>
        /// An ID that identifies the entitlement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An ID that identifies the benefit (reward).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("benefit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BenefitId { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the entitlement was granted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// An ID that identifies the user who was granted the entitlement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// An ID that identifies the game the user was playing when the reward was entitled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("game_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GameId { get; set; }

        /// <summary>
        /// The entitlement’s fulfillment status. Possible values are:   <br/>
        ///   <br/>
        /// * CLAIMED<br/>
        /// * FULFILLED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fulfillment_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DropsEntitlementFulfillmentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DropsEntitlementFulfillmentStatus FulfillmentStatus { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the entitlement was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUpdated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DropsEntitlement" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies the entitlement.
        /// </param>
        /// <param name="benefitId">
        /// An ID that identifies the benefit (reward).
        /// </param>
        /// <param name="timestamp">
        /// The UTC date and time (in RFC3339 format) of when the entitlement was granted.
        /// </param>
        /// <param name="userId">
        /// An ID that identifies the user who was granted the entitlement.
        /// </param>
        /// <param name="gameId">
        /// An ID that identifies the game the user was playing when the reward was entitled.
        /// </param>
        /// <param name="fulfillmentStatus">
        /// The entitlement’s fulfillment status. Possible values are:   <br/>
        ///   <br/>
        /// * CLAIMED<br/>
        /// * FULFILLED
        /// </param>
        /// <param name="lastUpdated">
        /// The UTC date and time (in RFC3339 format) of when the entitlement was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DropsEntitlement(
            string id,
            string benefitId,
            global::System.DateTime timestamp,
            string userId,
            string gameId,
            global::G.DropsEntitlementFulfillmentStatus fulfillmentStatus,
            global::System.DateTime lastUpdated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BenefitId = benefitId ?? throw new global::System.ArgumentNullException(nameof(benefitId));
            this.Timestamp = timestamp;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.GameId = gameId ?? throw new global::System.ArgumentNullException(nameof(gameId));
            this.FulfillmentStatus = fulfillmentStatus;
            this.LastUpdated = lastUpdated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DropsEntitlement" /> class.
        /// </summary>
        public DropsEntitlement()
        {
        }
    }
}