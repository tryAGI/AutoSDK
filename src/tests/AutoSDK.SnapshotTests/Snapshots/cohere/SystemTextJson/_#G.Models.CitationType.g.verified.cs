//HintName: G.Models.CitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of citation which indicates what part of the response the citation is for.
    /// </summary>
    public enum CitationType
    {
        /// <summary>
        /// 
        /// </summary>
        TEXTCONTENT,
        /// <summary>
        /// 
        /// </summary>
        PLAN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CitationType value)
        {
            return value switch
            {
                CitationType.TEXTCONTENT => "TEXT_CONTENT",
                CitationType.PLAN => "PLAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CitationType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT_CONTENT" => CitationType.TEXTCONTENT,
                "PLAN" => CitationType.PLAN,
                _ => null,
            };
        }
    }
}