//HintName: G.Models.GetCustomRewardRedemptionSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCustomRewardRedemptionSort
    {
        /// <summary>
        /// 
        /// </summary>
        OLDEST,
        /// <summary>
        /// 
        /// </summary>
        NEWEST,
    }

    public static class GetCustomRewardRedemptionSortExtensions
    {
        public static string ToValueString(this GetCustomRewardRedemptionSort value)
        {
            return value switch
            {
                GetCustomRewardRedemptionSort.OLDEST => "OLDEST",
                GetCustomRewardRedemptionSort.NEWEST => "NEWEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetCustomRewardRedemptionSort ToEnum(string value)
        {
            return value switch
            {
                "OLDEST" => GetCustomRewardRedemptionSort.OLDEST,
                "NEWEST" => GetCustomRewardRedemptionSort.NEWEST,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetCustomRewardRedemptionSort ToEnum(int value)
        {
            return value switch
            {
                0 => GetCustomRewardRedemptionSort.OLDEST,
                1 => GetCustomRewardRedemptionSort.NEWEST,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}