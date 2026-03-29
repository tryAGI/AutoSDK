//HintName: G.Models.KeywordIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum KeywordIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="keyword")]
        Keyword,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeywordIndexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeywordIndexType value)
        {
            return value switch
            {
                KeywordIndexType.Keyword => "keyword",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeywordIndexType? ToEnum(string value)
        {
            return value switch
            {
                "keyword" => KeywordIndexType.Keyword,
                _ => null,
            };
        }
    }
}