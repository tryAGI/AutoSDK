//HintName: G.Models.GetSpeechHistorySortDirection2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetSpeechHistorySortDirection2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSpeechHistorySortDirection2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpeechHistorySortDirection2 value)
        {
            return value switch
            {
                GetSpeechHistorySortDirection2.Asc => "asc",
                GetSpeechHistorySortDirection2.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpeechHistorySortDirection2? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSpeechHistorySortDirection2.Asc,
                "desc" => GetSpeechHistorySortDirection2.Desc,
                _ => null,
            };
        }
    }
}