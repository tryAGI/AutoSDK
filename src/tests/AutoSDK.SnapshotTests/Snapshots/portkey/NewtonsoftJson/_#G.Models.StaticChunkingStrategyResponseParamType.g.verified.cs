//HintName: G.Models.StaticChunkingStrategyResponseParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `static`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StaticChunkingStrategyResponseParamType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static")]
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StaticChunkingStrategyResponseParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StaticChunkingStrategyResponseParamType value)
        {
            return value switch
            {
                StaticChunkingStrategyResponseParamType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StaticChunkingStrategyResponseParamType? ToEnum(string value)
        {
            return value switch
            {
                "static" => StaticChunkingStrategyResponseParamType.Static,
                _ => null,
            };
        }
    }
}