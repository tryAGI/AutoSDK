//HintName: G.Models.MessagesRequestToolChoiceOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolChoiceOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolChoiceOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolChoiceOneOf3Type value)
        {
            return value switch
            {
                MessagesRequestToolChoiceOneOf3Type.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolChoiceOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "tool" => MessagesRequestToolChoiceOneOf3Type.Tool,
                _ => null,
            };
        }
    }
}