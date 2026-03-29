//HintName: G.Models.StreamingTranscriptionResponseVariant4Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StreamingTranscriptionResponseVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingTranscriptionResponseVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingTranscriptionResponseVariant4Type value)
        {
            return value switch
            {
                StreamingTranscriptionResponseVariant4Type.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingTranscriptionResponseVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "error" => StreamingTranscriptionResponseVariant4Type.Error,
                _ => null,
            };
        }
    }
}