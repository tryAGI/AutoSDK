//HintName: G.Models.LocalizePortugueseDialect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalizePortugueseDialect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="br")]
        Br,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eu")]
        Eu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalizePortugueseDialectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalizePortugueseDialect value)
        {
            return value switch
            {
                LocalizePortugueseDialect.Br => "br",
                LocalizePortugueseDialect.Eu => "eu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalizePortugueseDialect? ToEnum(string value)
        {
            return value switch
            {
                "br" => LocalizePortugueseDialect.Br,
                "eu" => LocalizePortugueseDialect.Eu,
                _ => null,
            };
        }
    }
}