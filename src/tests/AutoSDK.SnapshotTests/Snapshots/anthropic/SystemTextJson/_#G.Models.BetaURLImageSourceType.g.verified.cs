//HintName: G.Models.BetaURLImageSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaURLImageSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaURLImageSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaURLImageSourceType value)
        {
            return value switch
            {
                BetaURLImageSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaURLImageSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => BetaURLImageSourceType.Url,
                _ => null,
            };
        }
    }
}