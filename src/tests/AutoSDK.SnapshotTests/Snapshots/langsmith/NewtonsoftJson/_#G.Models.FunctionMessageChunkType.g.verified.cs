//HintName: G.Models.FunctionMessageChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: FunctionMessageChunk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionMessageChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FunctionMessageChunk")]
        FunctionMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionMessageChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionMessageChunkType value)
        {
            return value switch
            {
                FunctionMessageChunkType.FunctionMessageChunk => "FunctionMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionMessageChunkType? ToEnum(string value)
        {
            return value switch
            {
                "FunctionMessageChunk" => FunctionMessageChunkType.FunctionMessageChunk,
                _ => null,
            };
        }
    }
}