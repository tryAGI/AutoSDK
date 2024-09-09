//HintName: G.Models.AutoChunkingStrategyRequestParamType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `auto`.
    /// </summary>
    public enum AutoChunkingStrategyRequestParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoChunkingStrategyRequestParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoChunkingStrategyRequestParamType value)
        {
            return value switch
            {
                AutoChunkingStrategyRequestParamType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoChunkingStrategyRequestParamType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AutoChunkingStrategyRequestParamType.Auto,
                _ => null,
            };
        }
    }
}