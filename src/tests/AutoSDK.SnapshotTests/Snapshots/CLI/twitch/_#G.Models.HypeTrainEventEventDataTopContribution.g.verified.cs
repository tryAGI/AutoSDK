﻿//HintName: G.Models.HypeTrainEventEventDataTopContribution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HypeTrainEventEventDataTopContribution
    {
        /// <summary>
        /// The total amount contributed. If `type` is BITS, `total` represents the amount of Bits used. If `type` is SUBS, `total` is 500, 1000, or 2500 to represent tier 1, 2, or 3 subscriptions, respectively.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// The contribution method used. Possible values are:  <br/>
        ///   <br/>
        /// * BITS — Cheering with Bits.<br/>
        /// * SUBS — Subscription activity like subscribing or gifting subscriptions.<br/>
        /// * OTHER — Covers other contribution methods not listed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HypeTrainEventEventDataTopContributionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HypeTrainEventEventDataTopContributionType Type { get; set; }

        /// <summary>
        /// The ID of the user that made the contribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrainEventEventDataTopContribution" /> class.
        /// </summary>
        /// <param name="total">
        /// The total amount contributed. If `type` is BITS, `total` represents the amount of Bits used. If `type` is SUBS, `total` is 500, 1000, or 2500 to represent tier 1, 2, or 3 subscriptions, respectively.
        /// </param>
        /// <param name="type">
        /// The contribution method used. Possible values are:  <br/>
        ///   <br/>
        /// * BITS — Cheering with Bits.<br/>
        /// * SUBS — Subscription activity like subscribing or gifting subscriptions.<br/>
        /// * OTHER — Covers other contribution methods not listed.
        /// </param>
        /// <param name="user">
        /// The ID of the user that made the contribution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HypeTrainEventEventDataTopContribution(
            int total,
            global::G.HypeTrainEventEventDataTopContributionType type,
            string user)
        {
            this.Total = total;
            this.Type = type;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HypeTrainEventEventDataTopContribution" /> class.
        /// </summary>
        public HypeTrainEventEventDataTopContribution()
        {
        }
    }
}