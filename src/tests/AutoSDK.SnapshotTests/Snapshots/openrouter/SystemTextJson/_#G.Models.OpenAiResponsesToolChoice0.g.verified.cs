//HintName: G.Models.OpenAiResponsesToolChoice0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponsesToolChoice0
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponsesToolChoice0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponsesToolChoice0 value)
        {
            return value switch
            {
                OpenAiResponsesToolChoice0.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponsesToolChoice0? ToEnum(string value)
        {
            return value switch
            {
                "auto" => OpenAiResponsesToolChoice0.Auto,
                _ => null,
            };
        }
    }
}