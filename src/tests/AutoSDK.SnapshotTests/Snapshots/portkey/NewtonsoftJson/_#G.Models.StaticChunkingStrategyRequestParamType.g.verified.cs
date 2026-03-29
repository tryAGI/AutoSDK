//HintName: G.Models.StaticChunkingStrategyRequestParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `static`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StaticChunkingStrategyRequestParamType
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
    public static class StaticChunkingStrategyRequestParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StaticChunkingStrategyRequestParamType value)
        {
            return value switch
            {
                StaticChunkingStrategyRequestParamType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StaticChunkingStrategyRequestParamType? ToEnum(string value)
        {
            return value switch
            {
                "static" => StaticChunkingStrategyRequestParamType.Static,
                _ => null,
            };
        }
    }
}