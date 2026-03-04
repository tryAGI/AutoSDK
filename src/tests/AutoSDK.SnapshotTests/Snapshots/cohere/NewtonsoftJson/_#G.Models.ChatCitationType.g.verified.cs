//HintName: G.Models.ChatCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of citation which indicates what part of the response the citation is for.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TEXT_CONTENT")]
        TextContent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAN")]
        Plan,
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
                ChatCitationType.TextContent => "TEXT_CONTENT",
                ChatCitationType.Plan => "PLAN",
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
                "TEXT_CONTENT" => ChatCitationType.TextContent,
                "PLAN" => ChatCitationType.Plan,
                _ => null,
            };
        }
    }
}