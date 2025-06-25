//HintName: G.Models.ChatCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of citation which indicates what part of the response the citation is for.
    /// </summary>
    public enum ChatCitationType
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
    public static class ChatCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCitationType value)
        {
            return value switch
            {
                ChatCitationType.TEXTCONTENT => "TEXT_CONTENT",
                ChatCitationType.PLAN => "PLAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCitationType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT_CONTENT" => ChatCitationType.TEXTCONTENT,
                "PLAN" => ChatCitationType.PLAN,
                _ => null,
            };
        }
    }
}