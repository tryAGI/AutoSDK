//HintName: G.Models.ThinkingContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: thinking
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ThinkingContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thinking")]
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingContentType value)
        {
            return value switch
            {
                ThinkingContentType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingContentType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => ThinkingContentType.Thinking,
                _ => null,
            };
        }
    }
}