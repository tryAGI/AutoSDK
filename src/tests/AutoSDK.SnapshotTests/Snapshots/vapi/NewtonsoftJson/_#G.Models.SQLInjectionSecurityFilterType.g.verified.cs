//HintName: G.Models.SQLInjectionSecurityFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of security threat to filter.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SQLInjectionSecurityFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sql-injection")]
        SqlInjection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SQLInjectionSecurityFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SQLInjectionSecurityFilterType value)
        {
            return value switch
            {
                SQLInjectionSecurityFilterType.SqlInjection => "sql-injection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SQLInjectionSecurityFilterType? ToEnum(string value)
        {
            return value switch
            {
                "sql-injection" => SQLInjectionSecurityFilterType.SqlInjection,
                _ => null,
            };
        }
    }
}