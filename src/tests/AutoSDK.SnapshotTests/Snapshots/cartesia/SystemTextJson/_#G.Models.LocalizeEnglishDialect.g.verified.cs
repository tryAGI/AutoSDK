//HintName: G.Models.LocalizeEnglishDialect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LocalizeEnglishDialect
    {
        /// <summary>
        /// 
        /// </summary>
        Au,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        So,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalizeEnglishDialectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizeEnglishDialect value)
        {
            return value switch
            {
                LocalizeEnglishDialect.Au => "au",
                LocalizeEnglishDialect.In => "in",
                LocalizeEnglishDialect.So => "so",
                LocalizeEnglishDialect.Uk => "uk",
                LocalizeEnglishDialect.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizeEnglishDialect? ToEnum(string value)
        {
            return value switch
            {
                "au" => LocalizeEnglishDialect.Au,
                "in" => LocalizeEnglishDialect.In,
                "so" => LocalizeEnglishDialect.So,
                "uk" => LocalizeEnglishDialect.Uk,
                "us" => LocalizeEnglishDialect.Us,
                _ => null,
            };
        }
    }
}