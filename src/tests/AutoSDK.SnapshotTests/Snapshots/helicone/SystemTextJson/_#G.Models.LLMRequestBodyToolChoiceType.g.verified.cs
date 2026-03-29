//HintName: G.Models.LLMRequestBodyToolChoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMRequestBodyToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMRequestBodyToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMRequestBodyToolChoiceType value)
        {
            return value switch
            {
                LLMRequestBodyToolChoiceType.Any => "any",
                LLMRequestBodyToolChoiceType.Auto => "auto",
                LLMRequestBodyToolChoiceType.None => "none",
                LLMRequestBodyToolChoiceType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMRequestBodyToolChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "any" => LLMRequestBodyToolChoiceType.Any,
                "auto" => LLMRequestBodyToolChoiceType.Auto,
                "none" => LLMRequestBodyToolChoiceType.None,
                "tool" => LLMRequestBodyToolChoiceType.Tool,
                _ => null,
            };
        }
    }
}