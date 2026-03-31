//HintName: G.Models.OnlineScoreConfigScorerVariant2FunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OnlineScoreConfigScorerVariant2FunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OnlineScoreConfigScorerVariant2FunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OnlineScoreConfigScorerVariant2FunctionType value)
        {
            return value switch
            {
                OnlineScoreConfigScorerVariant2FunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OnlineScoreConfigScorerVariant2FunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => OnlineScoreConfigScorerVariant2FunctionType.Function,
                _ => null,
            };
        }
    }
}