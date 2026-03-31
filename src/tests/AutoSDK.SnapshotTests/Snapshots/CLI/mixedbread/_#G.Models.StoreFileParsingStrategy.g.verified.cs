//HintName: G.Models.StoreFileParsingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Strategy for adding a file to a store.
    /// </summary>
    public enum StoreFileParsingStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        HighQuality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreFileParsingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreFileParsingStrategy value)
        {
            return value switch
            {
                StoreFileParsingStrategy.Fast => "fast",
                StoreFileParsingStrategy.HighQuality => "high_quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreFileParsingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "fast" => StoreFileParsingStrategy.Fast,
                "high_quality" => StoreFileParsingStrategy.HighQuality,
                _ => null,
            };
        }
    }
}