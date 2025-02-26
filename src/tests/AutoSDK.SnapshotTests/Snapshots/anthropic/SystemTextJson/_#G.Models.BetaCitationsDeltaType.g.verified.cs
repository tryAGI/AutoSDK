//HintName: G.Models.BetaCitationsDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: citations_delta
    /// </summary>
    public enum BetaCitationsDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        CitationsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCitationsDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCitationsDeltaType value)
        {
            return value switch
            {
                BetaCitationsDeltaType.CitationsDelta => "citations_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCitationsDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "citations_delta" => BetaCitationsDeltaType.CitationsDelta,
                _ => null,
            };
        }
    }
}