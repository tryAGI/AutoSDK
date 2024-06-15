//HintName: G.Models.OtherChunkingStrategyResponseParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `other`.
    /// </summary>
    public enum OtherChunkingStrategyResponseParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OtherChunkingStrategyResponseParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OtherChunkingStrategyResponseParamType value)
        {
            return value switch
            {
                OtherChunkingStrategyResponseParamType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OtherChunkingStrategyResponseParamType? ToEnum(string value)
        {
            return value switch
            {
                "other" => OtherChunkingStrategyResponseParamType.Other,
                _ => null,
            };
        }
    }
}