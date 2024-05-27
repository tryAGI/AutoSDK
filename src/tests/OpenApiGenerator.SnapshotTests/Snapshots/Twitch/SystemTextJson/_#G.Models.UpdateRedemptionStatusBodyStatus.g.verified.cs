//HintName: G.Models.UpdateRedemptionStatusBodyStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status to set the redemption to. Possible values are:  
    ///   
    /// * CANCELED
    /// * FULFILLED
    ///   
    /// Setting the status to CANCELED refunds the user’s channel points.
    /// </summary>
    public abstract class UpdateRedemptionStatusBodyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string CANCELED = "CANCELED";
        /// <summary>
        /// 
        /// </summary>
        public const string FULFILLED = "FULFILLED";
    }
}