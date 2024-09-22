//HintName: G.Models.Strategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The possible strategy used to serve a fine-tuned models.<br/>
    ///  - STRATEGY_UNSPECIFIED: Unspecified strategy.<br/>
    ///  - STRATEGY_VANILLA: Serve the fine-tuned model on a dedicated GPU.<br/>
    ///  - STRATEGY_TFEW: Serve the fine-tuned model on a shared GPU.<br/>
    /// Default Value: STRATEGY_UNSPECIFIED
    /// </summary>
    public enum Strategy
    {
        /// <summary>
        /// Unspecified strategy.
        /// </summary>
        STRATEGYUNSPECIFIED,
        /// <summary>
        /// Serve the fine-tuned model on a dedicated GPU.
        /// </summary>
        STRATEGYVANILLA,
        /// <summary>
        /// Serve the fine-tuned model on a shared GPU.
        /// </summary>
        STRATEGYTFEW,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Strategy value)
        {
            return value switch
            {
                Strategy.STRATEGYUNSPECIFIED => "STRATEGY_UNSPECIFIED",
                Strategy.STRATEGYVANILLA => "STRATEGY_VANILLA",
                Strategy.STRATEGYTFEW => "STRATEGY_TFEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Strategy? ToEnum(string value)
        {
            return value switch
            {
                "STRATEGY_UNSPECIFIED" => Strategy.STRATEGYUNSPECIFIED,
                "STRATEGY_VANILLA" => Strategy.STRATEGYVANILLA,
                "STRATEGY_TFEW" => Strategy.STRATEGYTFEW,
                _ => null,
            };
        }
    }
}