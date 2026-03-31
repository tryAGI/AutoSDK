//HintName: G.Models.StreamingResponseVariant3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamingResponseVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingResponseVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingResponseVariant3Type value)
        {
            return value switch
            {
                StreamingResponseVariant3Type.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingResponseVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "error" => StreamingResponseVariant3Type.Error,
                _ => null,
            };
        }
    }
}