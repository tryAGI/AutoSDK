//HintName: G.Models.HumanMessageChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: HumanMessageChunk
    /// </summary>
    public enum HumanMessageChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        HumanMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HumanMessageChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HumanMessageChunkType value)
        {
            return value switch
            {
                HumanMessageChunkType.HumanMessageChunk => "HumanMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HumanMessageChunkType? ToEnum(string value)
        {
            return value switch
            {
                "HumanMessageChunk" => HumanMessageChunkType.HumanMessageChunk,
                _ => null,
            };
        }
    }
}