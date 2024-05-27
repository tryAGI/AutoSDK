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
    public abstract class UpdateDropsEntitlementsBodyFulfillmentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string CLAIMED = "CLAIMED";
        /// <summary>
        /// 
        /// </summary>
        public const string FULFILLED = "FULFILLED";
    }
}