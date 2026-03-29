//HintName: G.Models.StreamingResponseVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingResponseVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chunk")]
        Chunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingResponseVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingResponseVariant1Type value)
        {
            return value switch
            {
                StreamingResponseVariant1Type.Chunk => "chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingResponseVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => StreamingResponseVariant1Type.Chunk,
                _ => null,
            };
        }
    }
}