//HintName: G.Models.MessagesRequestToolChoiceOneOf2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolChoiceOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolChoiceOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolChoiceOneOf2Type value)
        {
            return value switch
            {
                MessagesRequestToolChoiceOneOf2Type.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolChoiceOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "none" => MessagesRequestToolChoiceOneOf2Type.None,
                _ => null,
            };
        }
    }
}