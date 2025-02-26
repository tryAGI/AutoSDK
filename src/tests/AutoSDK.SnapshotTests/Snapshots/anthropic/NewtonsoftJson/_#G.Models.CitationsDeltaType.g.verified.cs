//HintName: G.Models.CitationsDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: citations_delta
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CitationsDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citations_delta")]
        CitationsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationsDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationsDeltaType value)
        {
            return value switch
            {
                CitationsDeltaType.CitationsDelta => "citations_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationsDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "citations_delta" => CitationsDeltaType.CitationsDelta,
                _ => null,
            };
        }
    }
}