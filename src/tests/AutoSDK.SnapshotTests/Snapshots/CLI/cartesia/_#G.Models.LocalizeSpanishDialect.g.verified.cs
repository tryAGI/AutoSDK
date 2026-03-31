//HintName: G.Models.LocalizeSpanishDialect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalizeSpanishDialect
    {
        /// <summary>
        /// 
        /// </summary>
        Mx,
        /// <summary>
        /// 
        /// </summary>
        Pe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalizeSpanishDialectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizeSpanishDialect value)
        {
            return value switch
            {
                LocalizeSpanishDialect.Mx => "mx",
                LocalizeSpanishDialect.Pe => "pe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizeSpanishDialect? ToEnum(string value)
        {
            return value switch
            {
                "mx" => LocalizeSpanishDialect.Mx,
                "pe" => LocalizeSpanishDialect.Pe,
                _ => null,
            };
        }
    }
}