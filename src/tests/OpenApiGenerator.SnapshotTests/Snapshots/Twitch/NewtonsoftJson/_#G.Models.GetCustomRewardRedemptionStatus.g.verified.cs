//HintName: G.Models.GetCustomRewardRedemptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetCustomRewardRedemptionStatus
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

    public static class GetCustomRewardRedemptionStatusExtensions
    {
        public static string ToValueString(this GetCustomRewardRedemptionStatus value)
        {
            return value switch
            {
                GetCustomRewardRedemptionStatus.CANCELED => "CANCELED",
                GetCustomRewardRedemptionStatus.FULFILLED => "FULFILLED",
                GetCustomRewardRedemptionStatus.UNFULFILLED => "UNFULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetCustomRewardRedemptionStatus ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetCustomRewardRedemptionStatus.CANCELED,
                "FULFILLED" => GetCustomRewardRedemptionStatus.FULFILLED,
                "UNFULFILLED" => GetCustomRewardRedemptionStatus.UNFULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetCustomRewardRedemptionStatus ToEnum(int value)
        {
            return value switch
            {
                0 => GetCustomRewardRedemptionStatus.CANCELED,
                1 => GetCustomRewardRedemptionStatus.FULFILLED,
                2 => GetCustomRewardRedemptionStatus.UNFULFILLED,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}