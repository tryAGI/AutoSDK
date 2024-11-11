//HintName: G.Models.UpdateRedemptionStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRedemptionStatusResponse
    {
        /// <summary>
        /// The list contains the single redemption that you updated.
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
        /// Initializes a new instance of the <see cref="UpdateRedemptionStatusResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list contains the single redemption that you updated.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateRedemptionStatusResponse(
            global::System.Collections.Generic.IList<global::G.CustomRewardRedemption> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRedemptionStatusResponse" /> class.
        /// </summary>
        public UpdateRedemptionStatusResponse()
        {
        }
    }
}