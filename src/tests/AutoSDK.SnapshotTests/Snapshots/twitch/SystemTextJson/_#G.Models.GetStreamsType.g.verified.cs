//HintName: G.Models.GetStreamsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetStreamsType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStreamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStreamsType value)
        {
            return value switch
            {
                GetStreamsType.All => "all",
                GetStreamsType.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStreamsType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetStreamsType.All,
                "live" => GetStreamsType.Live,
                _ => null,
            };
        }
    }
}