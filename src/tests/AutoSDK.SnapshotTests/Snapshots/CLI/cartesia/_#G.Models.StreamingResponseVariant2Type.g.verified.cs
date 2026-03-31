//HintName: G.Models.StreamingResponseVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamingResponseVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingResponseVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingResponseVariant2Type value)
        {
            return value switch
            {
                StreamingResponseVariant2Type.Done => "done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingResponseVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "done" => StreamingResponseVariant2Type.Done,
                _ => null,
            };
        }
    }
}