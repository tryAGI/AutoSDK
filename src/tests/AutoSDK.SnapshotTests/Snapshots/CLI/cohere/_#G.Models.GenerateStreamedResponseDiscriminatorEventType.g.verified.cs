//HintName: G.Models.GenerateStreamedResponseDiscriminatorEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateStreamedResponseDiscriminatorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        TextGeneration,
        /// <summary>
        /// 
        /// </summary>
        StreamEnd,
        /// <summary>
        /// 
        /// </summary>
        StreamError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateStreamedResponseDiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateStreamedResponseDiscriminatorEventType value)
        {
            return value switch
            {
                GenerateStreamedResponseDiscriminatorEventType.TextGeneration => "text-generation",
                GenerateStreamedResponseDiscriminatorEventType.StreamEnd => "stream-end",
                GenerateStreamedResponseDiscriminatorEventType.StreamError => "stream-error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateStreamedResponseDiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "text-generation" => GenerateStreamedResponseDiscriminatorEventType.TextGeneration,
                "stream-end" => GenerateStreamedResponseDiscriminatorEventType.StreamEnd,
                "stream-error" => GenerateStreamedResponseDiscriminatorEventType.StreamError,
                _ => null,
            };
        }
    }
}