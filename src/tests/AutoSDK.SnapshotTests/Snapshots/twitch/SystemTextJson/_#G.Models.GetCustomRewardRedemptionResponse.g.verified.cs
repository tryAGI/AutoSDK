//HintName: G.Models.GetCustomRewardRedemptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCustomRewardRedemptionResponse
    {
        /// <summary>
        /// The list of redemptions for the specified reward. The list is empty if there are no redemptions that match the redemption criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CustomRewardRedemption> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomRewardRedemptionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of redemptions for the specified reward. The list is empty if there are no redemptions that match the redemption criteria.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCustomRewardRedemptionResponse(
            global::System.Collections.Generic.IList<global::G.CustomRewardRedemption> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomRewardRedemptionResponse" /> class.
        /// </summary>
        public GetCustomRewardRedemptionResponse()
        {
        }
    }
}