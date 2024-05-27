//HintName: G.Models.CustomRewardRedemptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the redemption. Possible values are:  
    ///   
    /// * CANCELED
    /// * FULFILLED
    /// * UNFULFILLED
    /// </summary>
    public abstract class CustomRewardRedemptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string CANCELED = "CANCELED";
        /// <summary>
        /// 
        /// </summary>
        public const string FULFILLED = "FULFILLED";
        /// <summary>
        /// 
        /// </summary>
        public const string UNFULFILLED = "UNFULFILLED";
    }
}