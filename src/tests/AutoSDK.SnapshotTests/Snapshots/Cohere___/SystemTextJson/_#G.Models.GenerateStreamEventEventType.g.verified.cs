//HintName: G.Models.GenerateStreamEventEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateStreamEventEventType
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
    public static class GenerateStreamEventEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateStreamEventEventType value)
        {
            return value switch
            {
                GenerateStreamEventEventType.TextGeneration => "text-generation",
                GenerateStreamEventEventType.StreamEnd => "stream-end",
                GenerateStreamEventEventType.StreamError => "stream-error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateStreamEventEventType? ToEnum(string value)
        {
            return value switch
            {
                "text-generation" => GenerateStreamEventEventType.TextGeneration,
                "stream-end" => GenerateStreamEventEventType.StreamEnd,
                "stream-error" => GenerateStreamEventEventType.StreamError,
                _ => null,
            };
        }
    }
}