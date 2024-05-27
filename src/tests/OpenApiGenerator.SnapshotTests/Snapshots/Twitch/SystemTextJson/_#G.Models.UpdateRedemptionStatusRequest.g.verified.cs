//HintName: G.Models.UpdateRedemptionStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRedemptionStatusRequest
    {
        /// <summary>
        /// The status to set the redemption to. Possible values are:  
        ///   
        /// * CANCELED
        /// * FULFILLED
        ///   
        /// Setting the status to CANCELED refunds the user’s channel points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}