//HintName: G.Models.ReferenceChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: reference
    /// </summary>
    public enum ReferenceChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        Reference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReferenceChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReferenceChunkType value)
        {
            return value switch
            {
                ReferenceChunkType.Reference => "reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReferenceChunkType? ToEnum(string value)
        {
            return value switch
            {
                "reference" => ReferenceChunkType.Reference,
                _ => null,
            };
        }
    }
}