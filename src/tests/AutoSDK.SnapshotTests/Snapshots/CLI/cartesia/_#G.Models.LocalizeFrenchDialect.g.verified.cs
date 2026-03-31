//HintName: G.Models.LocalizeFrenchDialect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalizeFrenchDialect
    {
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Eu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalizeFrenchDialectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizeFrenchDialect value)
        {
            return value switch
            {
                LocalizeFrenchDialect.Ca => "ca",
                LocalizeFrenchDialect.Eu => "eu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizeFrenchDialect? ToEnum(string value)
        {
            return value switch
            {
                "ca" => LocalizeFrenchDialect.Ca,
                "eu" => LocalizeFrenchDialect.Eu,
                _ => null,
            };
        }
    }
}