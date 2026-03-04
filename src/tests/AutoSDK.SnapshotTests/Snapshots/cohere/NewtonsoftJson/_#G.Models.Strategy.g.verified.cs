//HintName: G.Models.Strategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The possible strategy used to serve a fine-tuned models.<br/>
    ///  - STRATEGY_UNSPECIFIED: Unspecified strategy.<br/>
    ///  - STRATEGY_VANILLA: Deprecated: Serve the fine-tuned model on a dedicated GPU.<br/>
    ///  - STRATEGY_TFEW: Deprecated: Serve the fine-tuned model on a shared GPU.<br/>
    /// Default Value: STRATEGY_UNSPECIFIED
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Strategy
    {
        /// <summary>
        /// Unspecified strategy.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STRATEGY_UNSPECIFIED")]
        Unspecified,
        /// <summary>
        /// Deprecated: Serve the fine-tuned model on a dedicated GPU.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STRATEGY_VANILLA")]
        Vanilla,
        /// <summary>
        /// Deprecated: Serve the fine-tuned model on a shared GPU.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STRATEGY_TFEW")]
        Tfew,
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
                Strategy.Unspecified => "STRATEGY_UNSPECIFIED",
                Strategy.Vanilla => "STRATEGY_VANILLA",
                Strategy.Tfew => "STRATEGY_TFEW",
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
                "STRATEGY_UNSPECIFIED" => Strategy.Unspecified,
                "STRATEGY_VANILLA" => Strategy.Vanilla,
                "STRATEGY_TFEW" => Strategy.Tfew,
                _ => null,
            };
        }
    }
}