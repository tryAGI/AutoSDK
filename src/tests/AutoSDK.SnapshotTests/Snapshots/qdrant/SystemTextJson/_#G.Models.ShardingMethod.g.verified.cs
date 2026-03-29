//HintName: G.Models.ShardingMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShardingMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShardingMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShardingMethod value)
        {
            return value switch
            {
                ShardingMethod.Auto => "auto",
                ShardingMethod.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShardingMethod? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ShardingMethod.Auto,
                "custom" => ShardingMethod.Custom,
                _ => null,
            };
        }
    }
}