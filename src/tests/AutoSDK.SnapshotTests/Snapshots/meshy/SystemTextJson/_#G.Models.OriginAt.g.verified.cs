//HintName: G.Models.OriginAt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OriginAt
    {
        /// <summary>
        /// 
        /// </summary>
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        Center,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OriginAtExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OriginAt value)
        {
            return value switch
            {
                OriginAt.Bottom => "bottom",
                OriginAt.Center => "center",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OriginAt? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => OriginAt.Bottom,
                "center" => OriginAt.Center,
                _ => null,
            };
        }
    }
}