//HintName: G.Models.UpdateDropsEntitlementsBodyFulfillmentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The fulfillment status to set the entitlements to. Possible values are:  
    ///   
    /// * CLAIMED — The user claimed the benefit.
    /// * FULFILLED — The developer granted the benefit that the user claimed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateDropsEntitlementsBodyFulfillmentStatus
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