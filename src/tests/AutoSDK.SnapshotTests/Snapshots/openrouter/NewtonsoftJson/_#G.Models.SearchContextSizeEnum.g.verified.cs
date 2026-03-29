//HintName: G.Models.SearchContextSizeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Size of the search context for web search tools
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchContextSizeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchContextSizeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchContextSizeEnum value)
        {
            return value switch
            {
                SearchContextSizeEnum.High => "high",
                SearchContextSizeEnum.Low => "low",
                SearchContextSizeEnum.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchContextSizeEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchContextSizeEnum.High,
                "low" => SearchContextSizeEnum.Low,
                "medium" => SearchContextSizeEnum.Medium,
                _ => null,
            };
        }
    }
}