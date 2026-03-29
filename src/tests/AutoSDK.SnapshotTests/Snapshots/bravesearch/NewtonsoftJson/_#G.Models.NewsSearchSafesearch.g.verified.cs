//HintName: G.Models.NewsSearchSafesearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: moderate
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NewsSearchSafesearch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moderate")]
        Moderate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="strict")]
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewsSearchSafesearchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewsSearchSafesearch value)
        {
            return value switch
            {
                NewsSearchSafesearch.Moderate => "moderate",
                NewsSearchSafesearch.Off => "off",
                NewsSearchSafesearch.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewsSearchSafesearch? ToEnum(string value)
        {
            return value switch
            {
                "moderate" => NewsSearchSafesearch.Moderate,
                "off" => NewsSearchSafesearch.Off,
                "strict" => NewsSearchSafesearch.Strict,
                _ => null,
            };
        }
    }
}