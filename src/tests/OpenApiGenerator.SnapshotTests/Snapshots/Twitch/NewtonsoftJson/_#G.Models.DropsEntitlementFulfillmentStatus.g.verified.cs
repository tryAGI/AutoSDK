//HintName: G.Models.DropsEntitlementFulfillmentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entitlement’s fulfillment status. Possible values are:   
    ///   
    /// * CLAIMED
    /// * FULFILLED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DropsEntitlementFulfillmentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CLAIMED")]
        CLAIMED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FULFILLED")]
        FULFILLED,
    }
}