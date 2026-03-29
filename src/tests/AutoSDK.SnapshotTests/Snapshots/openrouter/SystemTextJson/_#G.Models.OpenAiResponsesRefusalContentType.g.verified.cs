//HintName: G.Models.OpenAiResponsesRefusalContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponsesRefusalContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponsesRefusalContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponsesRefusalContentType value)
        {
            return value switch
            {
                OpenAiResponsesRefusalContentType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponsesRefusalContentType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => OpenAiResponsesRefusalContentType.Refusal,
                _ => null,
            };
        }
    }
}