//HintName: G.Models.FineTuneReinforcementHyperparametersEvalInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneReinforcementHyperparametersEvalInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneReinforcementHyperparametersEvalIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneReinforcementHyperparametersEvalInterval value)
        {
            return value switch
            {
                FineTuneReinforcementHyperparametersEvalInterval.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneReinforcementHyperparametersEvalInterval? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneReinforcementHyperparametersEvalInterval.Auto,
                _ => null,
            };
        }
    }
}