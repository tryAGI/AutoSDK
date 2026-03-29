//HintName: G.Models.LocalizeEnglishDialect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalizeEnglishDialect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="au")]
        Au,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in")]
        In,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="so")]
        So,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uk")]
        Uk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us")]
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