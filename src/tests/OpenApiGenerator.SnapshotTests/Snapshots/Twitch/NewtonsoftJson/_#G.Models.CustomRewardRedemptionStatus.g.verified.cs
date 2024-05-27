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
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomRewardRedemptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        CANCELED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FULFILLED")]
        FULFILLED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNFULFILLED")]
        UNFULFILLED,
    }
}