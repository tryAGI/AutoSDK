//HintName: G.Models.FinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for the generation to finish.<br/>
    /// - `stop`: The generation stopped because the model reached the end of the output text.<br/>
    /// - `length`: The generation stopped because the model reached the maximum number of tokens. For JSON responses, this may result in truncated, invalid JSON that fails to parse.
    /// </summary>
    public enum FinishReason
    {
        /// <summary>
        /// The generation stopped because the model reached the maximum number of tokens. For JSON responses, this may result in truncated, invalid JSON that fails to parse.
        /// </summary>
        Length,
        /// <summary>
        /// The generation stopped because the model reached the end of the output text.
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason value)
        {
            return value switch
            {
                FinishReason.Length => "length",
                FinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason? ToEnum(string value)
        {
            return value switch
            {
                "length" => FinishReason.Length,
                "stop" => FinishReason.Stop,
                _ => null,
            };
        }
    }
}