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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomRewardRedemption> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRedemptionStatusResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list contains the single redemption that you updated.
        /// </param>
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