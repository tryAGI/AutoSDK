//HintName: G.Models.SnowballType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SnowballType
    {
        /// <summary>
        /// 
        /// </summary>
        Snowball,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SnowballTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SnowballType value)
        {
            return value switch
            {
                SnowballType.Snowball => "snowball",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SnowballType? ToEnum(string value)
        {
            return value switch
            {
                "snowball" => SnowballType.Snowball,
                _ => null,
            };
        }
    }
}