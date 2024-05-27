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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public UpdateRedemptionStatusRequestStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}