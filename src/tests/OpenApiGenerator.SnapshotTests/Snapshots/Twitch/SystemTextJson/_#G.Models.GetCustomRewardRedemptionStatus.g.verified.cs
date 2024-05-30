//HintName: G.Models.GetCustomRewardRedemptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCustomRewardRedemptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        CANCELED,
        /// <summary>
        /// 
        /// </summary>
        FULFILLED,
        /// <summary>
        /// 
        /// </summary>
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