//HintName: G.Models.OpenAiResponsesToolChoice2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponsesToolChoice2
    {
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponsesToolChoice2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponsesToolChoice2 value)
        {
            return value switch
            {
                OpenAiResponsesToolChoice2.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponsesToolChoice2? ToEnum(string value)
        {
            return value switch
            {
                "required" => OpenAiResponsesToolChoice2.Required,
                _ => null,
            };
        }
    }
}