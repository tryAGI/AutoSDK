//HintName: G.Models.OnlineScoreConfigScorerVariant2GlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OnlineScoreConfigScorerVariant2GlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnlineScoreConfigScorerVariant2GlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnlineScoreConfigScorerVariant2GlobalType value)
        {
            return value switch
            {
                OnlineScoreConfigScorerVariant2GlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnlineScoreConfigScorerVariant2GlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => OnlineScoreConfigScorerVariant2GlobalType.Global,
                _ => null,
            };
        }
    }
}