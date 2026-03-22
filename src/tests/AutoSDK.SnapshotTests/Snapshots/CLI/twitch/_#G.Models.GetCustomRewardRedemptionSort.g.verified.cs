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
        Newest,
        /// <summary>
        /// 
        /// </summary>
        Oldest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCustomRewardRedemptionSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCustomRewardRedemptionSort value)
        {
            return value switch
            {
                GetCustomRewardRedemptionSort.Newest => "NEWEST",
                GetCustomRewardRedemptionSort.Oldest => "OLDEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCustomRewardRedemptionSort? ToEnum(string value)
        {
            return value switch
            {
                "NEWEST" => GetCustomRewardRedemptionSort.Newest,
                "OLDEST" => GetCustomRewardRedemptionSort.Oldest,
                _ => null,
            };
        }
    }
}