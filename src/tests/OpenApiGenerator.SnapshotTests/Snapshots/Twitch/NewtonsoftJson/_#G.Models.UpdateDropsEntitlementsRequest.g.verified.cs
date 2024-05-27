//HintName: G.Models.UpdateDropsEntitlementsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDropsEntitlementsRequest
    {
        /// <summary>
        /// A list of IDs that identify the entitlements to update. You may specify a maximum of 100 IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entitlement_ids")]
        public global::System.Collections.Generic.IList<string?>? EntitlementIds { get; set; }

        /// <summary>
        /// The fulfillment status to set the entitlements to. Possible values are:  
        ///   
        /// * CLAIMED — The user claimed the benefit.
        /// * FULFILLED — The developer granted the benefit that the user claimed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fulfillment_status")]
        public UpdateDropsEntitlementsRequestFulfillmentStatus? FulfillmentStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}