//HintName: G.Models.FineTuneReinforcementHyperparametersLearningRateMultiplier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneReinforcementHyperparametersLearningRateMultiplier
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneReinforcementHyperparametersLearningRateMultiplierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneReinforcementHyperparametersLearningRateMultiplier value)
        {
            return value switch
            {
                FineTuneReinforcementHyperparametersLearningRateMultiplier.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneReinforcementHyperparametersLearningRateMultiplier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneReinforcementHyperparametersLearningRateMultiplier.Auto,
                _ => null,
            };
        }
    }
}