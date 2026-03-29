//HintName: G.Models.StreamTextResponseEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is always set to `text_generation` for this event.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamTextResponseEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_generation")]
        TextGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamTextResponseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamTextResponseEventType value)
        {
            return value switch
            {
                StreamTextResponseEventType.TextGeneration => "text_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamTextResponseEventType? ToEnum(string value)
        {
            return value switch
            {
                "text_generation" => StreamTextResponseEventType.TextGeneration,
                _ => null,
            };
        }
    }
}