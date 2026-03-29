//HintName: G.Models.OpenAiResponsesToolChoiceOneOf4Type0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponsesToolChoiceOneOf4Type0
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchPreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponsesToolChoiceOneOf4Type0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponsesToolChoiceOneOf4Type0 value)
        {
            return value switch
            {
                OpenAiResponsesToolChoiceOneOf4Type0.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponsesToolChoiceOneOf4Type0? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview_2025_03_11" => OpenAiResponsesToolChoiceOneOf4Type0.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}