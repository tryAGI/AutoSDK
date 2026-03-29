//HintName: G.Models.ChatFormatGrammarConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatFormatGrammarConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFormatGrammarConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFormatGrammarConfigType value)
        {
            return value switch
            {
                ChatFormatGrammarConfigType.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFormatGrammarConfigType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => ChatFormatGrammarConfigType.Grammar,
                _ => null,
            };
        }
    }
}