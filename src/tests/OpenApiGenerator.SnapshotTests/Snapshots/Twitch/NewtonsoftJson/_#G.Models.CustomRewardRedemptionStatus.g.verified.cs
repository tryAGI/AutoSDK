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

    public static class CustomRewardRedemptionStatusExtensions
    {
        public static string ToValueString(this CustomRewardRedemptionStatus value)
        {
            return value switch
            {
                CustomRewardRedemptionStatus.CANCELED => "CANCELED",
                CustomRewardRedemptionStatus.FULFILLED => "FULFILLED",
                CustomRewardRedemptionStatus.UNFULFILLED => "UNFULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CustomRewardRedemptionStatus ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => CustomRewardRedemptionStatus.CANCELED,
                "FULFILLED" => CustomRewardRedemptionStatus.FULFILLED,
                "UNFULFILLED" => CustomRewardRedemptionStatus.UNFULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CustomRewardRedemptionStatus ToEnum(int value)
        {
            return value switch
            {
                0 => CustomRewardRedemptionStatus.CANCELED,
                1 => CustomRewardRedemptionStatus.FULFILLED,
                2 => CustomRewardRedemptionStatus.UNFULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}