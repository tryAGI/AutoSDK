//HintName: G.Models.OpenAiResponsesToolChoiceOneOf3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponsesToolChoiceOneOf3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponsesToolChoiceOneOf3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponsesToolChoiceOneOf3Type value)
        {
            return value switch
            {
                OpenAiResponsesToolChoiceOneOf3Type.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponsesToolChoiceOneOf3Type? ToEnum(string value)
        {
            return value switch
            {
                "function" => OpenAiResponsesToolChoiceOneOf3Type.Function,
                _ => null,
            };
        }
    }
}