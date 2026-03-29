//HintName: G.Models.OpenAiResponsesToolChoiceOneOf4Type1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponsesToolChoiceOneOf4Type1
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponsesToolChoiceOneOf4Type1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponsesToolChoiceOneOf4Type1 value)
        {
            return value switch
            {
                OpenAiResponsesToolChoiceOneOf4Type1.WebSearchPreview => "web_search_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponsesToolChoiceOneOf4Type1? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview" => OpenAiResponsesToolChoiceOneOf4Type1.WebSearchPreview,
                _ => null,
            };
        }
    }
}